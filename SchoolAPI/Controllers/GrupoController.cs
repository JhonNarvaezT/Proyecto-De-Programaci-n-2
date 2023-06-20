using ActaNotasAPI.Models.Dto;
using ActaNotasAPI.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;

namespace ActaNotasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoController : ControllerBase
    {
        private readonly ILogger<GrupoController> _logger;
        private readonly IGrupoRepository _grupoRepo;
        private readonly IMapper _mapper;

        public GrupoController(ILogger<GrupoController> logger, IGrupoRepository grupoRepo
            , IMapper mapper)
        {
            _logger = logger;
            _grupoRepo = grupoRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GrupoDto>>> GetGrupo()
        {
            _logger.LogInformation("Obtener los Grupos");

            var grupoList = await _grupoRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<GrupoDto>>(grupoList));
        }

        [HttpGet("{id:int}", Name = "GetGrupo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GrupoDto>> GetGrupo(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer el Grupo con Id {id}");
                return BadRequest();
            }
            var grupo = await _grupoRepo.Get(s => s.GrupoId == id);

            if (grupo == null)
            {
                _logger.LogError($"Error al traer el Estudiante con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<GrupoDto>(grupo));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<GrupoDto>> AddGrupo([FromBody] GrupoCreateDto grupoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _grupoRepo.Get(s => s.Nombre.ToLower() == grupoDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Grupo con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (grupoDto == null)
            {
                return BadRequest(grupoDto);
            }

            Grupo modelo = _mapper.Map<Grupo>(grupoDto);

            await _grupoRepo.Add(modelo);

            return CreatedAtRoute("GetGrupo", new { id = modelo.GrupoId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteGrupo(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var grupo = await _grupoRepo.Get(s => s.GrupoId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _grupoRepo.Remove(grupo);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateGrupo(int id, [FromBody] GrupoUpdateDto grupoDto)
        {
            if (grupoDto == null || id != grupoDto.GrupoId)
            {
                return BadRequest();
            }

            Grupo modelo = _mapper.Map<Grupo>(grupoDto);

            await _grupoRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialGrupo(int id, JsonPatchDocument<GrupoUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var grupo = await _grupoRepo.Get(s => s.GrupoId == id, tracked: false);

            GrupoUpdateDto grupoDto = _mapper.Map<GrupoUpdateDto>(grupo);

            if (grupo == null) return BadRequest();

            patchDto.ApplyTo(grupoDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Grupo modelo = _mapper.Map<Grupo>(grupoDto);

            await _grupoRepo.Update(modelo);

            return NoContent();
        }

    }
}

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
    public class AsignaturaController : ControllerBase
    {

        private readonly ILogger<AsignaturaController> _logger;
        private readonly IAsignaturaRepository _asignaturaRepo;
        private readonly IMapper _mapper;

        public AsignaturaController(ILogger<AsignaturaController> logger, IAsignaturaRepository asignaturaRepo
            , IMapper mapper)
        {
            _logger = logger;
            _asignaturaRepo = asignaturaRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AsignaturaDto>>> GetGrupo()
        {
            _logger.LogInformation("Obtener los Grupos");

            var asignaturaList = await _asignaturaRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<AsignaturaDto>>(asignaturaList));
        }

        [HttpGet("{id:int}", Name = "GetAsignatura")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<AsignaturaDto>> GetAsignatura(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer la Asignatura con Id {id}");
                return BadRequest();
            }
            var asignatura = await _asignaturaRepo.Get(s => s.AsignaturaId == id);

            if (asignatura == null)
            {
                _logger.LogError($"Error al traer la Asignatura con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<AsignaturaDto>(asignatura));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<AsignaturaDto>> AddAsignatura([FromBody] AsignaturaCreateDto asignaturaDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _asignaturaRepo.Get(s => s.AsignaturaNombre.ToLower() == asignaturaDto.AsignaturaNombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡La Asignatura con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (asignaturaDto == null)
            {
                return BadRequest(asignaturaDto);
            }

            Asignatura modelo = _mapper.Map<Asignatura>(asignaturaDto);

            await _asignaturaRepo.Add(modelo);

            return CreatedAtRoute("GetAsignatura", new { id = modelo.AsignaturaId}, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteAsignatura(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var asignatura = await _asignaturaRepo.Get(s => s.AsignaturaId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _asignaturaRepo.Remove(asignatura);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateAsignatura(int id, [FromBody] AsignaturaUpdateDto asignaturaDto)
        {
            if (asignaturaDto == null || id != asignaturaDto.AsignaturaId)
            {
                return BadRequest();
            }

            Asignatura modelo = _mapper.Map<Asignatura>(asignaturaDto);

            await _asignaturaRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialAsignatura(int id, JsonPatchDocument<AsignaturaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var grupo = await _asignaturaRepo.Get(s => s.AsignaturaId == id, tracked: false);

            AsignaturaUpdateDto asignaturaDto = _mapper.Map<AsignaturaUpdateDto>(grupo);

            if (grupo == null) return BadRequest();

            patchDto.ApplyTo(asignaturaDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Asignatura modelo = _mapper.Map<Asignatura>(asignaturaDto);

            await _asignaturaRepo.Update(modelo);

            return NoContent();
        }


    }
}

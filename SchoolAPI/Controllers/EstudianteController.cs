using ActaNotasAPI.Models.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Models.Dto;
using SchoolAPI.Repository.IRepository;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly ILogger<EstudianteController> _logger;
        private readonly IEstudianteRepository _estudianteRepo;
        private readonly IMapper _mapper;

        public EstudianteController(ILogger<EstudianteController> logger, IEstudianteRepository estudianteRepo
            , IMapper mapper)
        {
            _logger = logger;
            _estudianteRepo = estudianteRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<EstudianteDto>>> GetEstudiante()
        {
            _logger.LogInformation("Obtener los Estudiantes");

            var estudianteList = await _estudianteRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<EstudianteDto>>(estudianteList));
        }

        [HttpGet("{id:int}", Name = "GetEstudiante")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<EstudianteDto>> GetEstudiante(int id)
        {
            if(id == 0)
            {
                _logger.LogError($"Error al traer el Estudiante con Id {id}");
                return BadRequest();
            }
            var student = await _estudianteRepo.Get(s => s.EstudianteId == id);

            if(student == null)
            {
                _logger.LogError($"Error al traer el Estudiante con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<EstudianteDto>(student));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<EstudianteDto>> AddEstudiante([FromBody] EstudianteCreateDto estudianteDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _estudianteRepo.Get(s => s.Nombre.ToLower() == estudianteDto.Nombre.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El estudiante con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (estudianteDto == null)
            {
                return BadRequest(estudianteDto);
            }

            Estudiante modelo = _mapper.Map<Estudiante>(estudianteDto);

            await _estudianteRepo.Add(modelo);

            return CreatedAtRoute("GetEstudiante", new { id = modelo.EstudianteId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteEstudiante(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }

            var estudiante = await _estudianteRepo.Get(s => s.EstudianteId == id);

            if(id == null)
            {
                return NotFound();
            }

            await _estudianteRepo.Remove(estudiante);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateEstudiante(int id, [FromBody] EstudianteUpdateDto estudianteDto)
        {
            if(estudianteDto == null || id != estudianteDto.EstudianteId)
            {
                return BadRequest();
            }

            Estudiante modelo = _mapper.Map<Estudiante>(estudianteDto);

            await _estudianteRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialEstudiante(int id, JsonPatchDocument<EstudianteUpdateDto> patchDto)
        {
            if(patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var estudiante = await _estudianteRepo.Get(s => s.EstudianteId == id, tracked:false);

            EstudianteUpdateDto estudianteDto = _mapper.Map<EstudianteUpdateDto>(estudiante);

            if(estudiante == null) return BadRequest();

            patchDto.ApplyTo(estudianteDto, ModelState);

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Estudiante modelo = _mapper.Map<Estudiante>(estudianteDto);

            await _estudianteRepo.Update(modelo);

            return NoContent();
        }
    }
}

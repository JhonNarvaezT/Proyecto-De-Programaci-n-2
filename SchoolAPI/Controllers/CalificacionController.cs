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
    public class CalificacionController : ControllerBase
    {

        private readonly ILogger<CalificacionController> _logger;
        private readonly ICalificacionRepository _calificacionRepo;
        private readonly IMapper _mapper;

        public CalificacionController(ILogger<CalificacionController> logger, ICalificacionRepository calificacionRepo
            , IMapper mapper)
        {
            _logger = logger;
            _calificacionRepo = calificacionRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<CalificacionDto>>> GetCalificacion()
        {
            _logger.LogInformation("Obtener las Calificaciones");

            var calificacionList = await _calificacionRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<CalificacionDto>>(calificacionList));
        }

        [HttpGet("{id:int}", Name = "GetCalificacion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CalificacionDto>> GetCalificacion(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer la Calificacion con Id {id}");
                return BadRequest();
            }
            var calificacion = await _calificacionRepo.Get(s => s.CalificacionId == id);

            if (calificacion == null)
            {
                _logger.LogError($"Error al traer la Calificacion con Id {id}");
                return NotFound();
            }

            return Ok(_mapper.Map<CalificacionDto>(calificacion));
        }
        //
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<CalificacionDto>> AddCalificacion([FromBody] CalificacionCreateDto calificacionDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          

            if (calificacionDto == null)
            {
                return BadRequest(calificacionDto);
            }

            Calificacion modelo = _mapper.Map<Calificacion>(calificacionDto);

            await _calificacionRepo.Add(modelo);

            return CreatedAtRoute("GetCalificacion", new { id = modelo.CalificacionId }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCalificacion(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var calificacion = await _calificacionRepo.Get(s => s.CalificacionId == id);

            if (id == null)
            {
                return NotFound();
            }

            await _calificacionRepo.Remove(calificacion);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCalificacion(int id, [FromBody] CalificacionUpdateDto calificacionDto)
        {
            if (calificacionDto == null || id != calificacionDto.CalificacionId)
            {
                return BadRequest();
            }

            Calificacion modelo = _mapper.Map<Calificacion>(calificacionDto);

            await _calificacionRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialCalificacion(int id, JsonPatchDocument<CalificacionUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var grupo = await _calificacionRepo.Get(s => s.CalificacionId == id, tracked: false);

            CalificacionUpdateDto calificacionDto = _mapper.Map<CalificacionUpdateDto>(grupo);

            if (grupo == null) return BadRequest();

            patchDto.ApplyTo(calificacionDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Calificacion modelo = _mapper.Map<Calificacion>(calificacionDto);

            await _calificacionRepo.Update(modelo);

            return NoContent();
        }

    }
}

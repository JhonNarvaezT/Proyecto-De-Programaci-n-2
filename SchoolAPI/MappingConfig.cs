using ActaNotasAPI.Models.Dto;
using AutoMapper;
using SchoolAPI.Models;
using SchoolAPI.Models.Dto;

namespace SchoolAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Estudiante, EstudianteDto>();
            CreateMap<EstudianteDto, Estudiante>();

            CreateMap<Estudiante, EstudianteCreateDto>().ReverseMap();
            CreateMap<Estudiante, EstudianteUpdateDto>().ReverseMap();

            CreateMap<Grupo, GrupoDto>();
            CreateMap<GrupoDto, Grupo>();

            CreateMap<Grupo, GrupoCreateDto>().ReverseMap();
            CreateMap<Grupo, GrupoUpdateDto>().ReverseMap();

            CreateMap<Asignatura, AsignaturaDto>();
            CreateMap<AsignaturaDto, Asignatura>();

            CreateMap<Asignatura, AsignaturaCreateDto>().ReverseMap();
            CreateMap<Asignatura, AsignaturaUpdateDto>().ReverseMap();

            CreateMap<Calificacion, CalificacionDto>();
            CreateMap<AsignaturaDto, Asignatura>();

            CreateMap<Calificacion, CalificacionCreateDto>().ReverseMap();
            CreateMap<Calificacion, CalificacionUpdateDto>().ReverseMap();
        }
    }
}

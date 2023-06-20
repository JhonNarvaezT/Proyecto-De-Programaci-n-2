using SchoolAPI.Models;
using SchoolAPI.Repository.IRepository;

namespace ActaNotasAPI.Repository.IRepository
{
    public interface ICalificacionRepository : IRepository<Calificacion>
    {
        Task<Calificacion> Update(Calificacion entity);



    }
}

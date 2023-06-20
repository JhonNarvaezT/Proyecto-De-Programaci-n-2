using SchoolAPI.Models;
using SchoolAPI.Repository.IRepository;

namespace ActaNotasAPI.Repository.IRepository
{
    public interface IAsignaturaRepository : IRepository<Asignatura>
    {
        Task<Asignatura> Update(Asignatura entity);
    }
}

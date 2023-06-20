using SchoolAPI.Models;

namespace SchoolAPI.Repository.IRepository
{
    public interface IEstudianteRepository : IRepository<Estudiante>
    {
        Task<Estudiante> Update(Estudiante entity);  
    }
}

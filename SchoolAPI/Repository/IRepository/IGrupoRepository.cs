
using SchoolAPI.Models;
using SchoolAPI.Repository.IRepository;

namespace ActaNotasAPI.Repository.IRepository
{
    public interface IGrupoRepository : IRepository<Grupo>
    {
        Task<Grupo> Update(Grupo entity);

    }
}

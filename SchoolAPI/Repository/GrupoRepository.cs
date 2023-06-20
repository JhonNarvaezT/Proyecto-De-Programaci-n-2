using ActaNotasAPI.Repository.IRepository;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Repository;

namespace ActaNotasAPI.Repository
{
    public class GrupoRepository : Repository<Grupo>, IGrupoRepository
    {
        private readonly ActaNotasContext _db;

        public GrupoRepository(ActaNotasContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Grupo> Update(Grupo entity)
        {
            _db.Grupos.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

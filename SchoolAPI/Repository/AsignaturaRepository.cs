using ActaNotasAPI.Repository.IRepository;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Repository;

namespace ActaNotasAPI.Repository
{
    public class AsignaturaRepository : Repository<Asignatura>, IAsignaturaRepository
    {
        private readonly ActaNotasContext _db;

    public AsignaturaRepository(ActaNotasContext db) : base(db)
    {
        _db = db;
    }
    
        public async Task<Asignatura> Update(Asignatura entity)
        {
            _db.Asignaturas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

using ActaNotasAPI.Repository.IRepository;
using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Repository;

namespace ActaNotasAPI.Repository
{
    public class CalificacionRepository : Repository<Calificacion>, ICalificacionRepository
    {
        private readonly ActaNotasContext _db;

        public CalificacionRepository(ActaNotasContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Calificacion> Update(Calificacion entity)
        {
            _db.Calificacions.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }

}

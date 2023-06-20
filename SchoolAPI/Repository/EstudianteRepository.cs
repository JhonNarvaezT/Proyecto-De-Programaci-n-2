using SchoolAPI.Data;
using SchoolAPI.Models;
using SchoolAPI.Repository.IRepository;

namespace SchoolAPI.Repository
{
    public class EstudianteRepository : Repository<Estudiante>, IEstudianteRepository
    {
        private readonly ActaNotasContext _db;

        public EstudianteRepository(ActaNotasContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Estudiante> Update(Estudiante entity)
        {
            _db.Estudiantes.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}

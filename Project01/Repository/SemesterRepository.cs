using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class SemesterRepository : ISemesterRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public SemesterRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int SMT_Id)
        {
            var delete = _context.Semesters.Find(SMT_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Semesters.Remove(delete);
            return true;
        }

        public List<SemesterDTO> GetAll()
        {
            var list = _context.Semesters.ToList();
            return gmap.Map<List<SemesterDTO>>(list);
        }

        public SemesterDTO GetById(int SMT_Id)
        {
            var id = _context.Semesters.Find(SMT_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<SemesterDTO>(id);
        }

        public bool Insert(SemesterDTO semester)
        {
            var insert = _context.Semesters.Find(semester.SMT_Id);
            if (insert == null)
            {
                _context.Semesters.Add(gmap.Map<Semester>(semester));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(SemesterDTO semester)
        {
            var update = _context.Semesters.Find(semester.SMT_Id);
            if (update != null)
            {
                _context.Semesters.Update(gmap.Map(semester, update));
                return true;
            }
            return false;
        }
    }
}

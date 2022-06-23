using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class GradeRepository : IGradeRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public GradeRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int G_Id)
        {
            var delete = _context.Grades.Find(G_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Grades.Remove(delete);
            return true;
        }

        public List<GradeDTO> GetAll()
        {
            var list = _context.Grades.ToList();
            return gmap.Map<List<GradeDTO>>(list);
        }

        public GradeDTO GetById(int G_Id)
        {
            var id = _context.Grades.Find(G_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<GradeDTO>(id);
        }

        public bool Insert(GradeDTO grades)
        {
            var insert = _context.Grades.Find(grades.G_Id);
            if (insert == null)
            {
                _context.Grades.Add(gmap.Map<Grade>(grades));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(GradeDTO grades)
        {
            var update = _context.Grades.Find(grades.G_Id);
            if (update != null)
            {
                _context.Grades.Update(gmap.Map(grades, update));
                return true;
            }
            return false;
        }
    }
}

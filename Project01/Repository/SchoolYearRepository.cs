using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class SchoolYearRepository : ISchoolYearRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public SchoolYearRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int SY_Id)
        {
            var delete = _context.SchoolYears.Find(SY_Id);
            if (delete == null)
            {
                return false;
            }
            _context.SchoolYears.Remove(delete);
            return true;
        }

        public List<SchoolYearDTO> GetAll()
        {
            var list = _context.SchoolYears.ToList();
            return gmap.Map<List<SchoolYearDTO>>(list);
        }

        public SchoolYearDTO GetById(int SY_Id)
        {
            var id = _context.SchoolYears.Find(SY_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<SchoolYearDTO>(id);
        }

        public bool Insert(SchoolYearDTO schoolYear)
        {
            var insert = _context.SchoolYears.Find(schoolYear.SY_Id);
            if (insert == null)
            {
                _context.SchoolYears.Add(gmap.Map<SchoolYear>(schoolYear));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(SchoolYearDTO schoolYear)
        {
            var update = _context.SchoolYears.Find(schoolYear.SY_Id);
            if (update != null)
            {
                _context.SchoolYears.Update(gmap.Map(schoolYear, update));
                return true;
            }
            return false;
        }
    }
}

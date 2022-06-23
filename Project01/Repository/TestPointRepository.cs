using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class TestPointRepository : ITestPointRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public TestPointRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int TP_Id)
        {
            var delete = _context.TestPoints.Find(TP_Id);
            if (delete == null)
            {
                return false;
            }
            _context.TestPoints.Remove(delete);
            return true;
        }

        public List<TestPointDTO> GetAll()
        {
            var list = _context.TestPoints.ToList();
            return gmap.Map<List<TestPointDTO>>(list);
        }

        public TestPointDTO GetById(int TP_Id)
        {
            var id = _context.TestPoints.Find(TP_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<TestPointDTO>(id);
        }

        public bool Insert(TestPointDTO testPoint)
        {
            var insert = _context.TestPoints.Find(testPoint.TD_Id);
            if (insert == null)
            {
                _context.TestPoints.Add(gmap.Map<TestPoint>(testPoint));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(TestPointDTO testPoint)
        {
            var update = _context.TestPoints.Find(testPoint.TP_Id);
            if (update != null)
            {
                _context.TestPoints.Update(gmap.Map(testPoint, update));
                return true;
            }
            return false;
        }
    }
}

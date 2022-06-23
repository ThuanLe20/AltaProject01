using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class TestsRepository : ITestRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public TestsRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int T_Id)
        {
            var delete = _context.Tests.Find(T_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Tests.Remove(delete);
            return true;
        }

        public List<TestDTO> GetAll()
        {
            var list = _context.Tests.ToList();
            return gmap.Map<List<TestDTO>>(list);
        }

        public TestDTO GetById(int T_Id)
        {
            var id = _context.Tests.Find(T_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<TestDTO>(id);
        }

        public bool Insert(TestDTO test)
        {
            var insert = _context.Tests.Find(test.T_Id);
            if (insert == null)
            {
                _context.Tests.Add(gmap.Map<Test>(test));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(TestDTO test)
        {
            var update = _context.Tests.Find(test.T_Id);
            if (update != null)
            {
                _context.Tests.Update(gmap.Map(test, update));
                return true;
            }
            return false;
        }
    }
}

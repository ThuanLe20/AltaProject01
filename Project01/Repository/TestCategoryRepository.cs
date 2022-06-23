using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class TestCategoryRepository : ITestCategoryRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public TestCategoryRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int TC_Id)
        {
            var delete = _context.TestCategories.Find(TC_Id);
            if (delete == null)
            {
                return false;
            }
            _context.TestCategories.Remove(delete);
            return true;
        }

        public List<TestCategoryDTO> GetAll()
        {
            var list = _context.TestCategories.ToList();
            return gmap.Map<List<TestCategoryDTO>>(list);
        }

        public TestCategoryDTO GetById(int TC_Id)
        {
            var id = _context.TestCategories.Find(TC_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<TestCategoryDTO>(id);
        }

        public bool Insert(TestCategoryDTO testCategory)
        {
            var insert = _context.TestCategories.Find(testCategory.TC_Id);
            if (insert == null)
            {
                _context.TestCategories.Add(gmap.Map<TestCategory>(testCategory));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(TestCategoryDTO testCategory)
        {
            var update = _context.TestCategories.Find(testCategory.TC_Id);
            if (update != null)
            {
                _context.TestCategories.Update(gmap.Map(testCategory, update));
                return true;
            }
            return false;
        }
    }
}

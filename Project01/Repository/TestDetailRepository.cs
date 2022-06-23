using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class TestDetailRepository : ITestDetailRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public TestDetailRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int TD_Id)
        {
            var delete = _context.TestDetails.Find(TD_Id);
            if (delete == null)
            {
                return false;
            }
            _context.TestDetails.Remove(delete);
            return true;
        }

        public List<TestDetailDTO> GetAll()
        {
            var list = _context.TestDetails.ToList();
            return gmap.Map<List<TestDetailDTO>>(list);
        }

        public TestDetailDTO GetById(int TD_Id)
        {
            var id = _context.TestDetails.Find(TD_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<TestDetailDTO>(id);
        }

        public bool Insert(TestDetailDTO testDetail)
        {
            var insert = _context.TestDetails.Find(testDetail.TD_Id);
            if (insert == null)
            {
                _context.TestDetails.Add(gmap.Map<TestDetail>(testDetail));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(TestDetailDTO testDetail)
        {
            var update = _context.TestDetails.Find(testDetail.TD_Id);
            if (update != null)
            {
                _context.TestDetails.Update(gmap.Map(testDetail, update));
                return true;
            }
            return false;
        }
    }
}

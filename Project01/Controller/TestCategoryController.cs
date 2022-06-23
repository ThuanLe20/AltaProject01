using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/TestCategory")]
    [ApiController]
    public class TestCategoryController : ControllerBase
    {
        private IMapper cmap;
        private ITestCategoryRepository _testCategoryRepository;

        public TestCategoryController(ITestCategoryRepository testCategoryRepository, IMapper mapper)
        {
            cmap = mapper;
            _testCategoryRepository = testCategoryRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<TestCategoryDTO>>> Index()
        {
            var model = _testCategoryRepository.GetAll();
            if (model == null)
            {
                return new List<TestCategoryDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSubject(TestCategoryDTO testCategory)
        {
            var add = _testCategoryRepository.Insert(testCategory);
            _testCategoryRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateSubject(TestCategoryDTO testCategory)
        {
            var update = _testCategoryRepository.Update(testCategory);
            _testCategoryRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSubject(int TC_Id)
        {
            var delete = _testCategoryRepository.Delete(TC_Id);
            _testCategoryRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IMapper cmap;
        private ITestRepository _testRepository;

        public TestController(ITestRepository testRepository, IMapper mapper)
        {
            cmap = mapper;
            _testRepository = testRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<TestDTO>>> Index()
        {
            var model = _testRepository.GetAll();
            if (model == null)
            {
                return new List<TestDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddT(TestDTO test)
        {
            var add = _testRepository.Insert(test);
            _testRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateT(TestDTO test)
        {
            var update = _testRepository.Update(test);
            _testRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteT(int T_Id)
        {
            var delete = _testRepository.Delete(T_Id);
            _testRepository.Save();
            return delete;
        }
    }
}

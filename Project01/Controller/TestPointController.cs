using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/TestDetail")]
    [ApiController]
    public class TestPointController : ControllerBase
    {
        private IMapper cmap;
        private ITestPointRepository _testPointRepository;

        public TestPointController(ITestPointRepository testPointRepository, IMapper mapper)
        {
            cmap = mapper;
            _testPointRepository = testPointRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<TestPointDTO>>> Index()
        {
            var model = _testPointRepository.GetAll();
            if (model == null)
            {
                return new List<TestPointDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddTP(TestPointDTO testPoint)
        {
            var add = _testPointRepository.Insert(testPoint);
            _testPointRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateTP(TestPointDTO testPoint)
        {
            var update = _testPointRepository.Update(testPoint);
            _testPointRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTP(int TP_Id)
        {
            var delete = _testPointRepository.Delete(TP_Id);
            _testPointRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/TestDetail")]
    [ApiController]
    public class TestDetailController : ControllerBase
    {
        private IMapper cmap;
        private ITestDetailRepository _testDetailRepository;

        public TestDetailController(ITestDetailRepository testDetailRepository, IMapper mapper)
        {
            cmap = mapper;
            _testDetailRepository = testDetailRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<TestDetailDTO>>> Index()
        {
            var model = _testDetailRepository.GetAll();
            if (model == null)
            {
                return new List<TestDetailDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddTD(TestDetailDTO testDetail)
        {
            var add = _testDetailRepository.Insert(testDetail);
            _testDetailRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateTD(TestDetailDTO testDetail)
        {
            var update = _testDetailRepository.Update(testDetail);
            _testDetailRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTD(int TD_Id)
        {
            var delete = _testDetailRepository.Delete(TD_Id);
            _testDetailRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Semester")]
    [ApiController]
    public class SemesterController : ControllerBase
    {
        private IMapper cmap;
        private ISemesterRepository _semesterRepository;

        public SemesterController(ISemesterRepository semesterRepository, IMapper mapper)
        {
            cmap = mapper;
            _semesterRepository = semesterRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<SemesterDTO>>> Index()
        {
            var model = _semesterRepository.GetAll();
            if (model == null)
            {
                return new List<SemesterDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSemester(SemesterDTO semester)
        {
            var add = _semesterRepository.Insert(semester);
            _semesterRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateSemester(SemesterDTO semester)
        {
            var update = _semesterRepository.Update(semester);
            _semesterRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSemester(int SMT_Id)
        {
            var delete = _semesterRepository.Delete(SMT_Id);
            _semesterRepository.Save();
            return delete;
        }
    }
}

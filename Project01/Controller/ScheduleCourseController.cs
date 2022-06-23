using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/ScheduleCourse")]
    [ApiController]
    public class ScheduleCourseController : ControllerBase
    {
        private IMapper admap;
        private IScheduleCourseRepository _scheduleCourseRepository;

        public ScheduleCourseController(IScheduleCourseRepository scheduleCourseRepository, IMapper mapper)
        {
            admap = mapper;
            _scheduleCourseRepository = scheduleCourseRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<ScheduleCourseDTO>>> Index()
        {
            var model = _scheduleCourseRepository.GetAll();
            if (model == null)
            {
                return new List<ScheduleCourseDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddAdmin(ScheduleCourseDTO scheduleCourse)
        {
            var add = _scheduleCourseRepository.Insert(scheduleCourse);
            _scheduleCourseRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateAdmin(ScheduleCourseDTO scheduleCourse)
        {
            var update = _scheduleCourseRepository.Update(scheduleCourse);
            _scheduleCourseRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteAdmin(int SC_Id)
        {
            var delete = _scheduleCourseRepository.Delete(SC_Id);
            _scheduleCourseRepository.Save();
            return delete;
        }
    }
}

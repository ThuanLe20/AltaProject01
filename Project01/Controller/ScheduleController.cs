using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Schedule")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private IMapper cmap;
        private IScheduleRepository _scheduleRepository;

        public ScheduleController(IScheduleRepository scheduleRepository, IMapper mapper)
        {
            cmap = mapper;
            _scheduleRepository = scheduleRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<ScheduleDTO>>> Index()
        {
            var model = _scheduleRepository.GetAll();
            if (model == null)
            {
                return new List<ScheduleDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSchedule(ScheduleDTO schedule)
        {
            var add = _scheduleRepository.Insert(schedule);
            _scheduleRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateSchedule(ScheduleDTO schedule)
        {
            var update = _scheduleRepository.Update(schedule);
            _scheduleRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSchedule(int SD_Id)
        {
            var delete = _scheduleRepository.Delete(SD_Id);
            _scheduleRepository.Save();
            return delete;
        }
    }
}

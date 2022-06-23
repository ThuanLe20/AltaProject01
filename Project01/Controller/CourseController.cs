using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Course")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private IMapper cmap;
        private ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository, IMapper mapper)
        {
            cmap = mapper;
            _courseRepository = courseRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<CourseDTO>>> Index()
        {
            var model = _courseRepository.GetAll();
            if (model == null)
            {
                return new List<CourseDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddCourse(CourseDTO course)
        {
            var add = _courseRepository.Insert(course);
            _courseRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateCourse(CourseDTO course)
        {
            var update = _courseRepository.Update(course);
            _courseRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteCourse(int CR_Id)
        {
            var delete = _courseRepository.Delete(CR_Id);
            _courseRepository.Save();
            return delete;
        }
    }
}

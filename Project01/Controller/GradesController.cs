using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Grade")]
    [ApiController]
    public class GradesController : ControllerBase
    {
        private IMapper cmap;
        private IGradeRepository _gradeRepository;

        public GradesController(IGradeRepository gradeRepository, IMapper mapper)
        {
            cmap = mapper;
            _gradeRepository = gradeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<GradeDTO>>> Index()
        {
            var model = _gradeRepository.GetAll();
            if (model == null)
            {
                return new List<GradeDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddGrade(GradeDTO grades)
        {
            var add = _gradeRepository.Insert(grades);
            _gradeRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateGrade(GradeDTO grades)
        {
            var update = _gradeRepository.Update(grades);
            _gradeRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteGrade(int G_Id)
        {
            var delete = _gradeRepository.Delete(G_Id);
            _gradeRepository.Save();
            return delete;
        }
    }
}

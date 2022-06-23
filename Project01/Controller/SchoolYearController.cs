using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/SchoolYear")]
    [ApiController]
    public class SchoolYearController : ControllerBase
    {
        private IMapper cmap;
        private ISchoolYearRepository _schoolYearRepository;

        public SchoolYearController(ISchoolYearRepository schoolYearRepository, IMapper mapper)
        {
            cmap = mapper;
            _schoolYearRepository = schoolYearRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<SchoolYearDTO>>> Index()
        {
            var model = _schoolYearRepository.GetAll();
            if (model == null)
            {
                return new List<SchoolYearDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSchoolYear(SchoolYearDTO schoolYear)
        {
            var add = _schoolYearRepository.Insert(schoolYear);
            _schoolYearRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateSchoolYear(SchoolYearDTO schoolYear)
        {
            var update = _schoolYearRepository.Update(schoolYear);
            _schoolYearRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSchoolYear(int SY_Id)
        {
            var delete = _schoolYearRepository.Delete(SY_Id);
            _schoolYearRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Class")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private IMapper cmap;
        private IClassRepository _classRepository;

        public ClassesController(IClassRepository classRepository, IMapper mapper)
        {
            cmap = mapper;
            _classRepository = classRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<ClassDTO>>> Index()
        {
            var model = _classRepository.GetAll();
            if (model == null)
            {
                return new List<ClassDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddClass(ClassDTO classes)
        {
            var add = _classRepository.Insert(classes);
            _classRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateClass(ClassDTO classes)
        {
            var update = _classRepository.Update(classes);
            _classRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteClass(int C_Id)
        {
            var delete = _classRepository.Delete(C_Id);
            _classRepository.Save();
            return delete;
        }

    }
}

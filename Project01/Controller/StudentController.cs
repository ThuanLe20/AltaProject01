using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IMapper cmap;
        private IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            cmap = mapper;
            _studentRepository = studentRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<StudentDTO>>> Index()
        {
            var model = _studentRepository.GetAll();
            if (model == null)
            {
                return new List<StudentDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddStudent(StudentDTO student)
        {
            var add = _studentRepository.Insert(student);
            _studentRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateStudent(StudentDTO student)
        {
            var update = _studentRepository.Update(student);
            _studentRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteStudent(int S_Id)
        {
            var delete = _studentRepository.Delete(S_Id);
            _studentRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Subject")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private IMapper cmap;
        private ISubjectRepository _subjectRepository;

        public SubjectController(ISubjectRepository subjectRepository, IMapper mapper)
        {
            cmap = mapper;
            _subjectRepository = subjectRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<SubjectDTO>>> Index()
        {
            var model = _subjectRepository.GetAll();
            if (model == null)
            {
                return new List<SubjectDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddSubject(SubjectDTO subject)
        {
            var add = _subjectRepository.Insert(subject);
            _subjectRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateSubject(SubjectDTO subject)
        {
            var update = _subjectRepository.Update(subject);
            _subjectRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteSubject(int SJ_Id)
        {
            var delete = _subjectRepository.Delete(SJ_Id);
            _subjectRepository.Save();
            return delete;
        }
    }
}

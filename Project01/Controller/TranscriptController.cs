using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Transcript")]
    [ApiController]
    public class TranscriptController : ControllerBase
    {
        private IMapper cmap;
        private ITranscriptRepository _transcriptRepository;

        public TranscriptController(ITranscriptRepository transcriptRepository, IMapper mapper)
        {
            cmap = mapper;
            _transcriptRepository = transcriptRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<TranscriptDTO>>> Index()
        {
            var model = _transcriptRepository.GetAll();
            if (model == null)
            {
                return new List<TranscriptDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddTS(TranscriptDTO transcript)
        {
            var add = _transcriptRepository.Insert(transcript);
            _transcriptRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateTS(TranscriptDTO transcript)
        {
            var update = _transcriptRepository.Update(transcript);
            _transcriptRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteTS(int TS_Id)
        {
            var delete = _transcriptRepository.Delete(TS_Id);
            _transcriptRepository.Save();
            return delete;
        }
    }
}

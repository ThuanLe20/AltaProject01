using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Document")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private IMapper cmap;
        private IDocumentRepository _documentRepository;

        public DocumentController(IDocumentRepository documentRepository, IMapper mapper)
        {
            cmap = mapper;
            _documentRepository = documentRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<DocumentDTO>>> Index()
        {
            var model = _documentRepository.GetAll();
            if (model == null)
            {
                return new List<DocumentDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddDocument(DocumentDTO document)
        {
            var add = _documentRepository.Insert(document);
            _documentRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateDocument(DocumentDTO document)
        {
            var update = _documentRepository.Update(document);
            _documentRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteDocument(int D_Id)
        {
            var delete = _documentRepository.Delete(D_Id);
            _documentRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly IMapper dmap;
        private readonly ProjectDbContext _context;

        public DocumentRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            dmap = mapper;
        }

        public bool Delete(int D_Id)
        {
            var delete = _context.Documents.Find(D_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Documents.Remove(delete);
            return true;
        }

        public List<DocumentDTO> GetAll()
        {
            var list = _context.Grades.ToList();
            return dmap.Map<List<DocumentDTO>>(list);
        }

        public DocumentDTO GetById(int D_Id)
        {
            var id = _context.Documents.Find(D_Id);
            if (id == null)
            {
                return null;
            }
            return dmap.Map<DocumentDTO>(id);
        }

        public bool Insert(DocumentDTO document)
        {
            var insert = _context.Documents.Find(document.D_Id);
            if (insert == null)
            {
                _context.Documents.Add(dmap.Map<Document>(document));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(DocumentDTO document)
        {
            var update = _context.Documents.Find(document.D_Id);
            if (update != null)
            {
                _context.Documents.Update(dmap.Map(document, update));
                return true;
            }
            return false;
        }
    }
}

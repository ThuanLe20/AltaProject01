using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class TranscriptRepository : ITranscriptRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public TranscriptRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int TS_Id)
        {
            var delete = _context.Transcripts.Find(TS_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Transcripts.Remove(delete);
            return true;
        }

        public List<TranscriptDTO> GetAll()
        {
            var list = _context.Transcripts.ToList();
            return gmap.Map<List<TranscriptDTO>>(list);
        }

        public TranscriptDTO GetById(int TS_Id)
        {
            var id = _context.Transcripts.Find(TS_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<TranscriptDTO>(id);
        }

        public bool Insert(TranscriptDTO test)
        {
            var insert = _context.Transcripts.Find(test.TS_Id);
            if (insert == null)
            {
                _context.Transcripts.Add(gmap.Map<Transcript>(test));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(TranscriptDTO test)
        {
            var update = _context.Transcripts.Find(test.TS_Id);
            if (update != null)
            {
                _context.Transcripts.Update(gmap.Map(test, update));
                return true;
            }
            return false;
        }
    }
}

using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public SubjectRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int SJ_Id)
        {
            var delete = _context.Subjects.Find(SJ_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Subjects.Remove(delete);
            return true;
        }

        public List<SubjectDTO> GetAll()
        {
            var list = _context.Subjects.ToList();
            return gmap.Map<List<SubjectDTO>>(list);
        }

        public SubjectDTO GetById(int SJ_Id)
        {
            var id = _context.Subjects.Find(SJ_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<SubjectDTO>(id);
        }

        public bool Insert(SubjectDTO subject)
        {
            var insert = _context.Subjects.Find(subject.SJ_Id);
            if (insert == null)
            {
                _context.Subjects.Add(gmap.Map<Subject>(subject));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(SubjectDTO subject)
        {
            var update = _context.Subjects.Find(subject.SJ_Id);
            if (update != null)
            {
                _context.Subjects.Update(gmap.Map(subject, update));
                return true;
            }
            return false;
        }
    }
}

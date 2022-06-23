using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public StudentRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int S_Id)
        {
            var delete = _context.Students.Find(S_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Students.Remove(delete);
            return true;
        }

        public List<StudentDTO> GetAll()
        {
            var list = _context.Students.ToList();
            return gmap.Map<List<StudentDTO>>(list);
        }

        public StudentDTO GetById(int S_Id)
        {
            var id = _context.Students.Find(S_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<StudentDTO>(id);
        }

        public bool Insert(StudentDTO student)
        {
            var insert = _context.Students.Find(student.S_Id);
            if (insert == null)
            {
                _context.Students.Add(gmap.Map<Student>(student));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(StudentDTO student)
        {
            var update = _context.Students.Find(student.S_Id);
            if (update != null)
            {
                _context.Students.Update(gmap.Map(student, update));
                return true;
            }
            return false;
        }
    }
}

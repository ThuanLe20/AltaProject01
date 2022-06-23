using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly IMapper cmap;
        private readonly ProjectDbContext _context;

        public CourseRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            cmap = mapper;
        }

        public bool Delete(int CR_Id)
        {
            var delete = _context.Courses.Find(CR_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Courses.Remove(delete);
            return true;
        }

        public List<CourseDTO> GetAll()
        {
            var list = _context.Courses.ToList();
            return cmap.Map<List<CourseDTO>>(list);
        }

        public CourseDTO GetById(int CR_Id)
        {
            var id = _context.Courses.Find(CR_Id);
            if (id == null)
            {
                return null;
            }
            return cmap.Map<CourseDTO>(id);
        }

        public bool Insert(CourseDTO course)
        {
            var insert = _context.Courses.Find(course.CR_Id);
            if (insert == null)
            {
                _context.Courses.Add(cmap.Map<Course>(course));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(CourseDTO course)
        {
            var update = _context.Courses.Find(course.CR_Id);
            if (update != null)
            {
                _context.Courses.Update(cmap.Map(course, update));
                return true;
            }
            return false;
        }
    }
}

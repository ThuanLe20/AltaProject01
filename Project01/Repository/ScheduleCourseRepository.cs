using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class ScheduleCourseRepository : IScheduleCourseRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public ScheduleCourseRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int SC_Id)
        {
            var delete = _context.ScheduleCourses.Find(SC_Id);
            if (delete == null)
            {
                return false;
            }
            _context.ScheduleCourses.Remove(delete);
            return true;
        }

        public List<ScheduleCourseDTO> GetAll()
        {
            var list = _context.ScheduleCourses.ToList();
            return gmap.Map<List<ScheduleCourseDTO>>(list);
        }

        public ScheduleCourseDTO GetById(int SC_Id)
        {
            var id = _context.ScheduleCourses.Find(SC_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<ScheduleCourseDTO>(id);
        }

        public bool Insert(ScheduleCourseDTO scheduleCourse)
        {
            var insert = _context.ScheduleCourses.Find(scheduleCourse.SC_Id);
            if (insert == null)
            {
                _context.ScheduleCourses.Add(gmap.Map<ScheduleCourse>(scheduleCourse));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(ScheduleCourseDTO scheduleCourse)
        {
            var update = _context.ScheduleCourses.Find(scheduleCourse.SC_Id);
            if (update != null)
            {
                _context.ScheduleCourses.Update(gmap.Map(scheduleCourse, update));
                return true;
            }
            return false;
        }
    }
}

using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public ScheduleRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int SD_Id)
        {
            var delete = _context.Schedules.Find(SD_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Schedules.Remove(delete);
            return true;
        }

        public List<ScheduleDTO> GetAll()
        {
            var list = _context.Schedules.ToList();
            return gmap.Map<List<ScheduleDTO>>(list);
        }

        public ScheduleDTO GetById(int SD_Id)
        {
            var id = _context.Schedules.Find(SD_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<ScheduleDTO>(id);
        }

        public bool Insert(ScheduleDTO schedule)
        {
            var insert = _context.Schedules.Find(schedule.SD_Id);
            if (insert == null)
            {
                _context.Schedules.Add(gmap.Map<Schedule>(schedule));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(ScheduleDTO schedule)
        {
            var update = _context.Schedules.Find(schedule.SD_Id);
            if (update != null)
            {
                _context.Schedules.Update(gmap.Map(schedule, update));
                return true;
            }
            return false;
        }
    }
}

using AutoMapper;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class PositionRepository : IPositionRepository
    {
        private readonly IMapper gmap;
        private readonly ProjectDbContext _context;

        public PositionRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            gmap = mapper;
        }

        public bool Delete(int PST_Id)
        {
            var delete = _context.Positions.Find(PST_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Positions.Remove(delete);
            return true;
        }

        public List<PositionDTO> GetAll()
        {
            var list = _context.Positions.ToList();
            return gmap.Map<List<PositionDTO>>(list);
        }

        public PositionDTO GetById(int PST_Id)
        {
            var id = _context.Positions.Find(PST_Id);
            if (id == null)
            {
                return null;
            }
            return gmap.Map<PositionDTO>(id);
        }

        public bool Insert(PositionDTO position)
        {
            var insert = _context.Positions.Find(position.PST_Id);
            if (insert == null)
            {
                _context.Positions.Add(gmap.Map<Position>(position));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(PositionDTO position)
        {
            var update = _context.Positions.Find(position.PST_Id);
            if (update != null)
            {
                _context.Positions.Update(gmap.Map(position, update));
                return true;
            }
            return false;
        }
    }
}

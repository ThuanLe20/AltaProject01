using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly IMapper cmap;
        private readonly ProjectDbContext _context;

        public ClassRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            cmap = mapper;
        }

        public bool Delete(int C_Id)
        {
            var delete = _context.Classes.Find(C_Id);
            if (delete == null)
            {
                return false;
            }
            _context.Classes.Remove(delete);
            return true;
        }

        public List<ClassDTO> GetAll()
        {
            var list = _context.Classes.ToList();
            return cmap.Map<List<ClassDTO>>(list);
        }

        public ClassDTO GetById(int C_Id)
        {
            var id = _context.Classes.Find(C_Id);
            if (id == null)
            {
                return null;
            }
            return cmap.Map<ClassDTO>(id);
        }

        public bool Insert(ClassDTO classes)
        {
            var insert = _context.Classes.Find(classes.C_Id);
            if (insert == null)
            {
                _context.Classes.Add(cmap.Map<Class>(classes));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(ClassDTO classes)
        {
            var update = _context.Classes.Find(classes.C_Id);
            if (update != null)
            {
                _context.Classes.Update(cmap.Map(classes, update));
                return true;
            }
            return false;
        }
    }
}

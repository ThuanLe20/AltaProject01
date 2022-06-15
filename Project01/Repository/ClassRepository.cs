using Microsoft.EntityFrameworkCore;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class ClassRepository : IClassRepository
    {
        private readonly ProjectDbContext _context;

        public ClassRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public void Delete(int C_Id)
        {
            Class classes = _context.Classes.Find(C_Id);
            _context.Classes.Remove(classes);
        }

        public IEnumerable<Class> GetAll()
        {
            return _context.Classes.ToList();
        }

        public Class GetById(int C_Id)
        {
            return _context.Classes.Find(C_Id);
        }

        public void Insert(Class classes)
        {
            _context.Classes.Add(classes);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Class classes)
        {
            _context.Entry(classes).State = EntityState.Modified;
        }
    }
}

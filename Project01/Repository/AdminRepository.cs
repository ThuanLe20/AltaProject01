using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper admap;

        public AdminRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            admap = mapper;
        }

        public bool Delete(int AD_Id)
        {
            var delete = _context.Admins.Find(AD_Id);
            if(delete == null)
            {
                return false;
            }
            _context.Remove(delete);
            return true;
        }

        public List<AdminDTO> GetAll()
        {
            var list = _context.Admins.ToList();
            return admap.Map<List<AdminDTO>>(list);
        }

        public AdminDTO GetById(int AD_Id)
        {
            var id = _context.Admins.Find(AD_Id);
            if(id== null)
            {
                return null;
            }
            return admap.Map<AdminDTO>(id);
        }

        public bool Insert(AdminDTO admin)
        {
            var insert = _context.Admins.Find(admin.AD_Id);
            if(insert == null)
            {
                _context.Admins.Add(admap.Map<Admin>(admin));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public bool Update(AdminDTO admin)
        {
            var update = _context.Admins.Find(admin.AD_Id);
            if (update != null)
            {
                _context.Admins.Update(admap.Map(admin,update));
                return true;
            }
            return false;
        }
    }
}

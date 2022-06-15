using Project01.DTO;
using Project01.Entity;

namespace Project01.Interface
{
    public interface IAdminRepository
    {
        List<AdminDTO> GetAll();
        AdminDTO GetById(int AD_Id);

        bool Insert(AdminDTO admin);

        bool Update(AdminDTO admin);

        bool Delete(int AD_Id);

        void Save();
    }
}

using Project01.DTO;
using Project01.Entity;

namespace Project01.Interface
{
    public interface IClassRepository
    {
        List<ClassDTO> GetAll();
        ClassDTO GetById(int C_Id);

        bool Insert(ClassDTO classes);

        bool Update(ClassDTO classes);

        bool Delete(int C_Id);

        void Save();
    }
}

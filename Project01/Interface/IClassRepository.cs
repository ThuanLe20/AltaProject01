using Project01.Entity;

namespace Project01.Interface
{
    public interface IClassRepository
    {
        IEnumerable<Class> GetAll();
        Class GetById(int C_Id);

        void Insert(Class classes);

        void Update(Class classes);

        void Delete(int C_Id);

        void Save();
    }
}

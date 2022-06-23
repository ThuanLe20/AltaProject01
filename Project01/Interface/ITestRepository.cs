using Project01.DTO;

namespace Project01.Interface
{
    public interface ITestRepository
    {
        List<TestDTO> GetAll();
        TestDTO GetById(int T_Id);

        bool Insert(TestDTO test);

        bool Update(TestDTO test);

        bool Delete(int T_Id);

        void Save();
    }
}

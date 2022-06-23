using Project01.DTO;

namespace Project01.Interface
{
    public interface ITestPointRepository
    {
        List<TestPointDTO> GetAll();
        TestPointDTO GetById(int TP_Id);

        bool Insert(TestPointDTO testPoint);

        bool Update(TestPointDTO testPoint);

        bool Delete(int TP_Id);

        void Save();
    }
}

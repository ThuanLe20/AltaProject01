using Project01.DTO;

namespace Project01.Interface
{
    public interface ITestDetailRepository
    {
        List<TestDetailDTO> GetAll();
        TestDetailDTO GetById(int TD_Id);

        bool Insert(TestDetailDTO testDetail);

        bool Update(TestDetailDTO testDetail);

        bool Delete(int TD_Id);

        void Save();
    }
}

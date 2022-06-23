using Project01.DTO;

namespace Project01.Interface
{
    public interface ITestCategoryRepository
    {
        List<TestCategoryDTO> GetAll();
        TestCategoryDTO GetById(int TC_Id);

        bool Insert(TestCategoryDTO testCategory);

        bool Update(TestCategoryDTO testCategory);

        bool Delete(int TC_Id);

        void Save();
    }
}

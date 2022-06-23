using Project01.DTO;

namespace Project01.Interface
{
    public interface IGradeRepository
    {
        List<GradeDTO> GetAll();
        GradeDTO GetById(int G_Id);

        bool Insert(GradeDTO grades);

        bool Update(GradeDTO grades);

        bool Delete(int G_Id);

        void Save();
    }
}

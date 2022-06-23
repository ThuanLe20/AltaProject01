using Project01.DTO;

namespace Project01.Interface
{
    public interface ISchoolYearRepository
    {
        List<SchoolYearDTO> GetAll();
        SchoolYearDTO GetById(int SY_Id);

        bool Insert(SchoolYearDTO schoolYear);

        bool Update(SchoolYearDTO schoolYear);

        bool Delete(int SY_Id);

        void Save();
    }
}

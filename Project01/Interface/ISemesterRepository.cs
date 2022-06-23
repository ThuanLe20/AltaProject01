using Project01.DTO;

namespace Project01.Interface
{
    public interface ISemesterRepository
    {
        List<SemesterDTO> GetAll();
        SemesterDTO GetById(int SMT_Id);

        bool Insert(SemesterDTO semester);

        bool Update(SemesterDTO semester);

        bool Delete(int SMT_Id);

        void Save();
    }
}

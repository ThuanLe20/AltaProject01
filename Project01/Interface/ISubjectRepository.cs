using Project01.DTO;

namespace Project01.Interface
{
    public interface ISubjectRepository
    {
        List<SubjectDTO> GetAll();
        SubjectDTO GetById(int SJ_Id);

        bool Insert(SubjectDTO subject);

        bool Update(SubjectDTO subject);

        bool Delete(int SJ_Id);

        void Save();
    }
}

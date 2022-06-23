using Project01.DTO;

namespace Project01.Interface
{
    public interface IStudentRepository
    {
        List<StudentDTO> GetAll();
        StudentDTO GetById(int S_Id);

        bool Insert(StudentDTO student);

        bool Update(StudentDTO student);

        bool Delete(int S_Id);

        void Save();
    }
}

using Project01.DTO;

namespace Project01.Interface
{
    public interface ICourseRepository
    {
        List<CourseDTO> GetAll();
        CourseDTO GetById(int CR_Id);

        bool Insert(CourseDTO course);

        bool Update(CourseDTO course);

        bool Delete(int CR_Id);

        void Save();
    }
}

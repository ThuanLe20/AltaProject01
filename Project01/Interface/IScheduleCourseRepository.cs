using Project01.DTO;

namespace Project01.Interface
{
    public interface IScheduleCourseRepository
    {
        List<ScheduleCourseDTO> GetAll();
        ScheduleCourseDTO GetById(int SC_Id);

        bool Insert(ScheduleCourseDTO scheduleCourse);

        bool Update(ScheduleCourseDTO scheduleCourse);

        bool Delete(int SC_Id);

        void Save();
    }
}

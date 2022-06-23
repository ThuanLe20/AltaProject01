using Project01.DTO;

namespace Project01.Interface
{
    public interface IScheduleRepository
    {
        List<ScheduleDTO> GetAll();
        ScheduleDTO GetById(int SD_Id);

        bool Insert(ScheduleDTO schedule);

        bool Update(ScheduleDTO schedule);

        bool Delete(int SD_Id);

        void Save();
    }
}

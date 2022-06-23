using Project01.DTO;

namespace Project01.Interface
{
    public interface IPositionRepository
    {
        List<PositionDTO> GetAll();
        PositionDTO GetById(int PST_Id);

        bool Insert(PositionDTO position);

        bool Update(PositionDTO position);

        bool Delete(int PST_Id);

        void Save();
    }
}

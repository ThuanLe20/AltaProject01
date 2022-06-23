using Project01.DTO;

namespace Project01.Interface
{
    public interface ITranscriptRepository
    {
        List<TranscriptDTO> GetAll();
        TranscriptDTO GetById(int TS_Id);

        bool Insert(TranscriptDTO transcript);

        bool Update(TranscriptDTO transcript);

        bool Delete(int TS_Id);

        void Save();
    }
}

using Project01.DTO;

namespace Project01.Interface
{
    public interface IDocumentRepository
    {
        List<DocumentDTO> GetAll();
        DocumentDTO GetById(int D_Id);

        bool Insert(DocumentDTO document);

        bool Update(DocumentDTO document);

        bool Delete(int G_Id);

        void Save();
    }
}

using Project01.DTO;
using Project01.Entity;

namespace Project01.Interface
{
    public interface IAccountRepository
    {
        List<AccountDTO> GetAll();
        AccountDTO GetById(int ACC_Id);

        bool Insert(AccountDTO account);

        bool Update(AccountDTO account);

        bool Delete(int ACC_Id);

        void Save();
    }
}

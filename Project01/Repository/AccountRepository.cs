using Microsoft.EntityFrameworkCore;
using Project01.EF;
using Project01.Entity;
using AutoMapper;
using Project01.DTO;
using Microsoft.AspNetCore.Mvc;
using Project01.Interface;

namespace Project01.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IMapper accmap;

        private readonly ProjectDbContext _context;


        public AccountRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            accmap = mapper;
        }
        public bool Delete(int ACC_Id)
        {
            var deleteACC = _context.Accounts.Find(ACC_Id);
            if (deleteACC != null)
            {
                _context.Accounts.Remove(accmap.Map<Account>(ACC_Id));
                return true;
            }
            return false;
        }

        public List<AccountDTO> GetAll()
        {
            var list = _context.Accounts.ToList();
            return accmap.Map<List<AccountDTO>>(list);
        }

        public AccountDTO GetById(int ACC_Id)
        {
            var id = _context.Accounts.Find(ACC_Id);
            if(id == null)
            {
                return null;
            }
            return accmap.Map<AccountDTO>(id);
        }

        public bool Insert(AccountDTO account)
        {
            var insertACC = _context.Accounts.Find(account.ACC_Id);
            if(insertACC == null)
            {
                _context.Accounts.Add(accmap.Map<Account>(account));
                return true;
            }
            return false;
        }
        public bool Update(AccountDTO account)
        {
            var updateACC = _context.Accounts.Find(account.ACC_Id);
            if (updateACC == null)
            {
                _context.Accounts.Update(accmap.Map<Account>(account));
                return true;
            }
            return false;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        
    }
}

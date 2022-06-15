using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.EF;
using Project01.Entity;
using Project01.Interface;
using Project01.Repository;

namespace Project01.Controller
{
    [Route("api/Account")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private IAccountRepository _accountRepository;
        private IMapper accmap;


        public AccountsController(IAccountRepository context, IMapper mapper)
        {
            _accountRepository = context;
            accmap = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<AccountDTO>>> Index()
        {
            var model = _accountRepository.GetAll();
            if(model == null){
                return new List<AccountDTO>();
            }
            return model.ToList();
        }

        [HttpPost]
        public ActionResult<bool> AddAcount (AccountDTO account)
        {
            var check = _accountRepository.Insert(account);
            _accountRepository.Save();
            return check;
        }

        [HttpPut]
        public ActionResult<bool> UpdateAccount(AccountDTO account)
        {
            var update = _accountRepository.Update(account);
            _accountRepository.Save();
            return update;
        }

        [HttpDelete]
        public ActionResult<bool> DeleteAccount(int ACC_Id)
        {
           var delete = _accountRepository.Delete(ACC_Id);
            _accountRepository.Save();
            return delete;
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Entity;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Admin")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private IMapper admap;
        private IAdminRepository _adminRepository;

        public AdminsController(IAdminRepository adminRepository, IMapper mapper)
        {
            admap = mapper;
            _adminRepository = adminRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<AdminDTO>>> Index()
        {
            var model = _adminRepository.GetAll();
            if(model == null)
            {
                return new List<AdminDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddAdmin(AdminDTO admin)
        {
            var add = _adminRepository.Insert(admin);
            _adminRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdateAdmin(AdminDTO admin)
        {
            var update = _adminRepository.Update(admin);
            _adminRepository.Save();
            return update;
        }
        
        [HttpDelete("{id}")]
        public ActionResult<bool> DeleteAdmin(int AD_Id)
        {
            var delete = _adminRepository.Delete(AD_Id);
            _adminRepository.Save();
            return delete;
        }
    }
}

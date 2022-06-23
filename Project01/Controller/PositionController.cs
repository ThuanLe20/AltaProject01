using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project01.DTO;
using Project01.Interface;

namespace Project01.Controller
{
    [Route("api/Position")]
    [ApiController]
    public class PositionController : ControllerBase
    {
        private IMapper cmap;
        private IPositionRepository _positionRepository;

        public PositionController(IPositionRepository positionRepository, IMapper mapper)
        {
            cmap = mapper;
            _positionRepository = positionRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<PositionDTO>>> Index()
        {
            var model = _positionRepository.GetAll();
            if (model == null)
            {
                return new List<PositionDTO>();
            }
            return model.ToList();
        }
        [HttpPost]
        public ActionResult<bool> AddPosition(PositionDTO position)
        {
            var add = _positionRepository.Insert(position);
            _positionRepository.Save();
            return add;
        }
        [HttpPut]
        public ActionResult<bool> UpdatePosition(PositionDTO position)
        {
            var update = _positionRepository.Update(position);
            _positionRepository.Save();
            return update;
        }

        [HttpDelete("{id}")]
        public ActionResult<bool> DeletePosition(int PST_Id)
        {
            var delete = _positionRepository.Delete(PST_Id);
            _positionRepository.Save();
            return delete;
        }
    }
}

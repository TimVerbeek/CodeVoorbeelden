using BroodnodigAPI.Data.Repositories;
using DeSpaakEntity.Data;
using DTO.Topping;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels;

namespace BroodnodigAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToppingController : ControllerBase
    {
        private ToppingsRepository toppingsRepository;
        public ToppingController(BroodNodigContext broodNodigContext)
        {
            toppingsRepository = new ToppingsRepository(broodNodigContext);
        }

        [HttpGet("GetAllToppings")]
        public ActionResult<ICollection<ToppingCardResponse>> GetAllToppings()
        {
            var toppings = toppingsRepository.GetAllToppings();
            return Ok(toppings);
        }
        [HttpGet("GetToppingByType/{type}")]
        public ActionResult <ICollection<ToppingCardResponse>> GetToppingByType(string type)
        {
            var Topping = toppingsRepository.GetToppingsByType(type);
            return Ok(Topping);
        }

        [HttpPost("AddTopping")]
        public ActionResult AddTopping(ToppingWrite topping)
        {
            if (topping == null)
            {
                return BadRequest("No valid topping");
            }

            toppingsRepository.AddTopping(topping);
            return Ok(topping);
        }
        [HttpDelete("DeleteTopping/{id}")]
        public ActionResult DeleteTopping(Guid id)
        {
            var topping = toppingsRepository.GetToppingById(id);

            if(topping == null || id == Guid.Empty)
            {
                return BadRequest("Topping not found");
            }
            toppingsRepository.DeleteTopping(topping);
            return Ok(topping);
        }




    }
}

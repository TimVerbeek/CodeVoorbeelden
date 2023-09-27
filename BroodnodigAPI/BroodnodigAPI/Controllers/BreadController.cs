using BroodnodigAPI.Data.Repositories;
using DeSpaakEntity.Data;
using DTO.Bread;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedModels;

namespace BroodnodigAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BreadController : ControllerBase
    {
        private BreadRepository breadrepository;
        public BreadController(BroodNodigContext broodNodigContext)
        {
            breadrepository = new BreadRepository(broodNodigContext);
        }
        //returns all breads
        [HttpGet("GetAllBread")]
        public ActionResult <ICollection<BreadCardResponse>> GetAllBread()
        {
            var breads = breadrepository.GetAllBreads();
            return Ok(breads);
        }

        //Create Bread
        [HttpPost("AddBread")]
        public ActionResult AddBread(BreadWriteRequest bread) {
            
            if(bread == null) { return  BadRequest("non valid bread"); }

            breadrepository.AddBread(bread);
            return Ok();
        }
        //Delete bread
        [HttpDelete("DeleteBread/{id}")]
        public ActionResult DeleteBread(Guid id) 
        {
       
            if(id == Guid.Empty)
            {
              return BadRequest("non valid bread");
            }
            breadrepository.RemoveBread(id);
            return Ok();
        }
    }
}

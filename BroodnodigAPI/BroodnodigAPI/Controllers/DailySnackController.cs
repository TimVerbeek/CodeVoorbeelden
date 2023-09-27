using BroodnodigAPI.Data.Repositories;
using DeSpaakEntity.Data;
using DTO.DailySnack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels;
using System.Threading;

namespace BroodnodigAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DailySnackController : ControllerBase
	{
		private DailySnackRepository dailySnackRepository;
		public DailySnackController(BroodNodigContext broodNodigContext)
		{
			dailySnackRepository = new DailySnackRepository(broodNodigContext);
		}
		
		[HttpGet("GetDailysnackForToday")]
		public ActionResult<DailySnackResponse> GetDailySnackForToday()
		{
			//gets dailysnack with given date
			var dailySnack = dailySnackRepository.GetDailySnackForToday();

			//check if snack is not there and gives badRequest
			if (dailySnack == null)
			{
				return Ok(new DailySnackResponse()
				{
					Name = "nog geen dailysnack gevonden"
				}); ;
			}
			return Ok(dailySnack);
		}


		[HttpPost("AddDailySnack")]
		public ActionResult AddDailySnack(DailySnackWrite dailySnack)
		{
            if (dailySnack == null) { return BadRequest("non valid snack"); }

            dailySnackRepository.AddDailySnack(dailySnack);
            return Ok();
        }


		[HttpDelete("DeleteDailySnack/{id}")]
		public ActionResult DeleteDailySnack(Guid id) 
		{
			if(id == Guid.Empty)
			{
				return BadRequest("No Snack found");
			}
			dailySnackRepository.DeleteDailySnack(id);
			return Ok();
		}


        //Returns snack with the given Date
        //[HttpGet("{date}")]
        //public ActionResult<DailySnackResponse> GetSnackWithDate(DateTime date)
        //{
        //	//checks if date given is correct and send
        //	//misschien niet nodig
        //	if (date == null)
        //	{
        //		return BadRequest("Give A Correct date");
        //	}

        //	//gets dailysnack with given date
        //	var dailySnack = dailySnackRepository.GetSnackByDate(date);

        //	//check if snack is not there and gives badRequest
        //	if (dailySnack == null) 
        //	{
        //		return BadRequest("No Snack Found");			
        //	}

        //	return Ok(dailySnack);
        //}
        //[HttpGet("GetDailysnack")]
        //public ActionResult<DailySnackResponse> GetSnacks()
        //{

        //	//gets dailysnack with given date
        //	var dailySnack = dailySnackRepository.GetDailySnacks();

        //	//check if snack is not there and gives badRequest
        //	if (dailySnack == null)
        //	{
        //		return BadRequest("No Snack Found");
        //	}

        //	return Ok(dailySnack);
        //}
    }
}

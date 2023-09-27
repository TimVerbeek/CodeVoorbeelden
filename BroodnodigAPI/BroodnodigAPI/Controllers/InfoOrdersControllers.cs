using BroodnodigAPI.Data.Repositories;
using DeSpaakEntity.Data;
using DTO.Order;
using Microsoft.AspNetCore.Mvc;

namespace BroodnodigAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoOrdersController : ControllerBase
    {
        private InfoOrderRepository infoOrderrepo;
        public InfoOrdersController(BroodNodigContext broodNodigContext)
        {
            infoOrderrepo = new InfoOrderRepository(broodNodigContext);
        }

        [HttpGet("GetOrderCount")]
        public int GetOrderCount()
        {
            var aanmeldingen = infoOrderrepo.GetAanmeldingen();
            if (aanmeldingen == null)
            {
                return 0;
            }
            else { return aanmeldingen.Count(); }
        }

        [HttpGet("GetAllFullOrders")]
        public ICollection<InfoOrderInfoResponse> GetOrders()
        {
            var orders = infoOrderrepo.GetAllOrders();
            if (orders == null)
            {
                return new List<InfoOrderInfoResponse>();
            }
            else
            {
                return orders;
            }
        }
        [HttpGet("GetOrderByEmail/{email}")]
        public ActionResult<InfoOrderInfoResponse> GetOrderByEmail(string email)
        {
            var order = infoOrderrepo.GetOrderInfoByEmail(email);
            if (order == null)
            {
                return BadRequest("no order found");
            }
            return Ok(order);
        }




        [HttpGet("GetIfEmailIsUniq/{mail}")]

        public bool CheckIfEmailisUniq(string mail)
        {
            var email = infoOrderrepo.CheckIfOrderIsVailid(mail, DateTime.Today);
            if (email == null)
            {
                return false;
            }
            return true;
        }
        [HttpPost("AddOrder")]
        public ActionResult AddInfoOrder(InfoOrderwrite infoOrder)
        {

            if (infoOrder == null)
            {
                return BadRequest("No order found");
            }
            infoOrderrepo.AddInfoOrder(infoOrder);
            return Ok();
        }
        [HttpPut("UpdateOrder/{id}")]
        public ActionResult PutInfoOrder(Guid id, [FromBody] InfoOrderwrite infoOrder)
        {
            if (infoOrder == null)
            {
                return BadRequest("No order found");
            }
            infoOrderrepo.PutInfoOrder(infoOrder, id);
            return Ok();
        }

    }







}

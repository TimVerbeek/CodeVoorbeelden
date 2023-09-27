//using BroodnodigAPI.Data.Repositories;
//using DeSpaakEntity.Data;
//using DTO.Order;
//using Microsoft.AspNetCore.Mvc;
//using SharedModels;

//namespace BroodnodigAPI.Controllers
//{
//	[Route("api/[controller]")]
//	[ApiController]
//	public class OrderController : ControllerBase
//	{
//		private OrderRepository orderRepository;
//		public OrderController(BroodNodigContext broodNodigContext)
//		{
//			orderRepository = new OrderRepository(broodNodigContext);
//		}
//		[HttpGet("GetOrdersByUser/{userId}")]
//		public ActionResult<ICollection<Order>> GetOrdersByUser(Guid userId)
//		{
//			var order = orderRepository.GetAllOrdersByUserId(userId);
//			if (order == null)
//			{
//				return BadRequest("no order found");
//			}
//			return Ok(order);
//		}
//		[HttpGet("GetOrders")]
//		public ActionResult<ICollection<Order>> GetallOrders()
//		{
//			var order = orderRepository.GetAllOrders();
//			if (order == null)
//			{
//				return BadRequest("no order found");
//			}
//			return Ok(order);
//		}

//		[HttpGet("GetOrdersByDate/{date}")]

//		public ActionResult<ICollection<Order>> GetOrdersByDate(DateTime date)
//		{
//			var order = orderRepository.GetOrdersByDate(date);

//			if (order == null)
//			{
//				return BadRequest("No Order found");
//			}
//			return Ok(order);
//		}
//		[HttpGet("GetOrdersForToday")]

//		public ActionResult<ICollection<Order>> GetAllOrdersForTheDay()
//		{
//			var orders = orderRepository.GetAllOrdersForTheDay();
//			if (orders == null)
//			{
//				return BadRequest("No orders found");
//			}
//			return Ok(orders);
//		}
//		[HttpGet("GetOrdersById/{id}")]
//		public ActionResult<Order> GetOrderById(Guid id)
//		{
//			var order = orderRepository.GetOrderById(id);
//			if (order == null)
//			{
//				return BadRequest("No order found");
//			}
//			return Ok(order);
//		}
//		[HttpPost("CreateOrder")]
//		public ActionResult AddOrder(OrderWrite order)
//		{
//			if (order == null)
//			{
//				return BadRequest("No valid Order");
//			}
//			orderRepository.CreateOrder(order);
//			return Ok();
//		}
//		[HttpPut("UpdateOrder/{id}")]
//		public ActionResult UpdateOrder(Order order, Guid id)
//		{
//			if (order == null)
//			{
//				return BadRequest("No valid Order");
//			}
//			orderRepository.UpdateOrder(order, id);
//			return Ok();
//		}
//		[HttpDelete("DeleteOrder/{id}")]
//		public ActionResult DeleteOrder(Guid id)
//		{
//			if (id == Guid.Empty)
//			{
//				return BadRequest("No valid Id");
//			}
//			orderRepository.DeleteOrder(id);
//			return Ok();
//		}
//		[HttpGet("GetOrderCount")]
//		public ActionResult<int> GetOrderCount()
//		{
//			int aantal = orderRepository.GetAanwezigheidsCount();
//			return Ok(aantal);
//		}

//	}
//}

//using BroodnodigAPI.Migrations;
//using DataModels;
//using DeSpaakEntity.Data;
//using DTO.Order;
//using SharedModels;

//namespace BroodnodigAPI.Data.Repositories
//{
//    public class OrderRepository
//    {
//        private readonly BroodNodigContext context;
//        public OrderRepository(BroodNodigContext broodNodigContext)
//        {
//            context = broodNodigContext;
//        }
//        public int GetAanwezigheidsCount()
//        {
//            var aantal = context.Orders
//                .Where(o=>o.Datum == DateTime.Today)
//                .Where(o=>o.Aanwezig == true)
//                .Count();
//            return aantal;

//        }

//        public ICollection<Order> GetAllOrdersByUserId(Guid userId)
//        {
//            var orders = context.Orders.Select(o => o).Where(o => o.UserId == userId).ToList();
//            return orders;
//        }
//        public Order GetOrderById(Guid id)
//        {
//            var order = context.Orders.FirstOrDefault(o => o.Id == id);
//            return order;
//        }
//		public ICollection<Order> GetAllOrders()
//		{
//			var orders = context.Orders.ToList();
//			return orders;
//		}
//		public ICollection<Order> GetAllOrdersForTheDay()
//        {
//            var orders = context.Orders.Select(o=>o).Where(o=>o.Datum ==  DateTime.Today).ToList();
//            return orders;
//        }
//        public ICollection <Order> GetOrdersByDate(DateTime date)
//        {
//            var orders = context.Orders.Select(o => o).Where(o => o.Datum == date).ToList();
//            return orders;
//        }
//        public void CreateOrder(OrderWrite order)
//        {
//            var guid = Guid.NewGuid();

//            var breads = order.Bread.Select(b =>
//                new OrderBreads()
//                {
//					Id = Guid.NewGuid(),
//					BreadId = b.Breadid,
//                    OrderId = guid
//                }
//            ).ToArray();

//			var toppings = order.Topping.Select(t =>
//			   new OrderToppings()
//			   {
//                   Id = Guid.NewGuid(),
//				   ToppingId = t.ToppingId,
//				   OrderId = guid
//			   }
//		   ).ToArray();

//			var newOrder = new Order()
//            {
//                Id = guid,
//                UserId = order.UserId,
//                Aanwezig = order.Aanwezig,
//                Datum = order.Datum,
//                HasDailySnack = order.HasDailySnack,

//            };

            
//			toppings.Select(t => context.OrderToppings.Add(t));
//			breads.Select(b => context.OrderBreads.Add(b));
//			context.Orders.Add(newOrder);
//            context.SaveChanges();
//        }
//        public void UpdateOrder(Order order,Guid id)
//        {
//            var existingOrder = GetOrderById(id);
//            existingOrder.Topping = order.Topping;
//            existingOrder.Bread = order.Bread;
//            existingOrder.Aanwezig = order.Aanwezig;
//            existingOrder.HasDailySnack = order.HasDailySnack;

//            context.SaveChanges();
//        }
//        public void DeleteOrder(Guid id) 
//        { 
//            var order = GetOrderById(id);
//            context.Orders.Remove(order);
//            context.SaveChanges();
//        }








//    }
//}

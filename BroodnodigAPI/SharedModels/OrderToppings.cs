using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
	public class OrderToppings
	{
		public Guid Id { get; set; }
		public Guid OrderId { get; set; }
		public Guid ToppingId { get; set; }
	}
}

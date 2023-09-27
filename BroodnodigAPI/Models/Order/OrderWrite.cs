using DTO.Bread;
using DTO.Topping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Order
{
	public class OrderWrite
	{
		public Guid Id { get; set; }
		public Guid UserId { get; set; }
		public bool HasDailySnack { get; set; }
		public bool Aanwezig { get; set; }
		public BreadorderWrite[] Bread { get; set; }
		public ToppingOrderwrite[] Topping { get; set; }
		public DateTime Datum { get; set; }
	}
}

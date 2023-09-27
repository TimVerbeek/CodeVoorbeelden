using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Order
{
	public class OrderResponse
	{
		public Guid Id { get; set; }
		public bool HasDailySnack { get; set; }
		public bool Aanwezig { get; set; }
		public DateTime Datum { get; set; }
	}
}

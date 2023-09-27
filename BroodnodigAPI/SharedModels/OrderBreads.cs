using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
	public class OrderBreads
	{
		public Guid Id { get; set; }
		public Guid OrderId { get; set; }
		public Guid BreadId { get; set; }
	}
}

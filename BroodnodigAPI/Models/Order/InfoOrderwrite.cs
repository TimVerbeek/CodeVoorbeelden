using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Order
{
	public class InfoOrderwrite
	{
		public bool IsAangemeld { get; set; }
		public bool HasDailySnack { get; set; }
		public string Email { get; set; }
		public string Opmerkingen { get; set; }
		public string Alergien { get; set; }

	}
}

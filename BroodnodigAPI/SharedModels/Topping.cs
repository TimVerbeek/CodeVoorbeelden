using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Topping
	{
		public Guid Id { get; set; }
        public string Name { get; set; }
		public string Type { get; set; }
        public int Inventory { get; set; }
		
	}
}

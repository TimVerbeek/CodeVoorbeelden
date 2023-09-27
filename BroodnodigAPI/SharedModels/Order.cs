using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool HasDailySnack { get; set; }
        public bool Aanwezig { get; set; }
        public virtual OrderToppings[] Topping { get; set; }
        public virtual OrderBreads[] Bread { get; set; }
        public DateTime Datum { get; set; }



    }
}

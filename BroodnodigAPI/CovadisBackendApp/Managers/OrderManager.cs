using DTO.Bread;
using DTO.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CovadisBackendApp.Managers
{
	public class OrderManager
	{
		private readonly HttpClient httpClient;

		public OrderManager(HttpClient httpClient) {
			this.httpClient = httpClient;
		}

		//gets number of eaters that are coming
		public int GetEaterCount()
		{
			var eatercount = httpClient.GetStringAsync("http://localhost:5149/api/InfoOrders/GetOrderCount");
			var jsonString = eatercount.Result;
			var count = JsonSerializer.Deserialize<int>(jsonString);
			return count;
		}

		//gets all orders
        public ICollection<InfoOrderInfoResponse> GetAllOrders()
        {
			var ordersresponse = httpClient.GetStringAsync("http://localhost:5149/api/InfoOrders/GetAllFullOrders");
			var jsonString = ordersresponse.Result;
			var orders  = JsonSerializer.Deserialize<ICollection<InfoOrderInfoResponse>>(jsonString);
			return orders;

        }
	}
}

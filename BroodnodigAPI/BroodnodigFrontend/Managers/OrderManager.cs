
using DTO.Order;
using System.Net.Http.Json;

namespace BroodnodigFrontend.Managers
{
    public class OrderManager
    {
        private readonly HttpClient httpClient;



        public OrderManager(HttpClient httpclient)
        {
            this.httpClient = httpclient;
        }


        //creates order
        public void createOrder(InfoOrderwrite order)
        {
            var response = httpClient.PostAsJsonAsync("http://localhost:5149/api/InfoOrders/addOrder", order);
        } 

        //updates order
        public async void updateOrder(InfoOrderwrite order, Guid Id)
        {
            var response = await httpClient.PutAsJsonAsync($"http://localhost:5149/api/InfoOrders/UpdateOrder/{Id}", order);
        }

        //checks if there is a order with the entered email today
        public async Task<bool> CheckEmailUniqueness(string email)
        {
            var isUnique = await httpClient.GetFromJsonAsync<bool>($"http://localhost:5149/api/InfoOrders/GetIfEmailIsUniq/{email}");
            return isUnique;
        }

        //get order from email
        public async Task<InfoOrderInfoResponse> getOrder(string email)
        {
            var response = await httpClient.GetFromJsonAsync<InfoOrderInfoResponse>($"http://localhost:5149/api/InfoOrders/GetOrderByEmail/{email}");
            return response;

        }

      
    }
}

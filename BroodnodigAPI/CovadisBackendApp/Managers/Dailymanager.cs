using DTO.DailySnack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CovadisBackendApp.Managers
{
    public class Dailymanager
    {
        private readonly HttpClient httpClient;

        public Dailymanager(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        //saves daily snack
        public async void SaveDailysnack(DailySnackWrite snack)
        {
            var response =
                await httpClient.PostAsJsonAsync("http://localhost:5149/api/DailySnack/AddDailySnack", snack);
        }

        //gets daily snack for today
        public DailySnackResponse GetDailySnackForToday()
        {
            var snack = httpClient.GetStringAsync("http://localhost:5149/api/DailySnack/GetDailysnackForToday");
            var jsonString = snack.Result;
            var dailySnack = JsonSerializer.Deserialize<DailySnackResponse>(jsonString);
            return dailySnack;
        }

        //deletes daily snack
        public void DeleteDailysnack(Guid id)
        {
            var snack = httpClient.DeleteAsync($"http://localhost:5149/api/DailySnack/DeleteDailySnack/{id}");
        }
    }
}


using DTO.DailySnack;
using System.Net.Http.Json;
using System.Text.Json;

namespace BroodnodigFrontend.Managers
{
    public class DailySnackManager
    {
        private readonly HttpClient httpClient;

        public DailySnackManager(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        //Gets dailysnack for today
        public async Task<DailySnackResponse> GetDailySnackForToday()
        {
            var response = await httpClient.GetFromJsonAsync<DailySnackResponse>("http://localhost:5149/api/DailySnack/GetDailysnackForToday");
            return response;

        }
    }
}

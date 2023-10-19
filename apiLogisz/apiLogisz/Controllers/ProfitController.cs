
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics;

namespace apiLogisz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfitController : ControllerBase
    {
        BaseFunctions baseFunctions =new BaseFunctions();

        [HttpGet("GetMaxprofit")]
        public int GetMaximumProfit()
        {
            var startingDay = 1;
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            List<int> profits = new List<int> { };


            // Select wilde niet werken vanwege gebrek aan return waarde, Hieronder staat hoe ik het gedaan zou hebben met de select

            


            //prices.Select((p, i) =>
            //{
            //    if (i >= startingDay && i != prices.Length - 1)
            //    {
            //        switch (startingDay % 2)
            //        {
            //            case 0:
            //                if (i % 2 == 0)
            //                {
            //                    profits.Add(prices[i + 1] - p);
            //                }
            //                break;
            //            default:
            //                if (i % 2 != 0)
            //                {
            //                    profits.Add(prices[i + 1] - p);
            //                }

            //                break;
            //        }
            //    }
            //});
            //return func.calulateTotalProfits(profits);




            //Dit is een werkend stukje code die zonder de select is geschreven.
            int index = 0;
            foreach (var pr in prices)
            {
                if (index >= startingDay && index != prices.Length - 1)
                {
                    switch (startingDay % 2)
                    {
                        case 0:
                            if (index % 2 == 0)
                            {
                                profits.Add(prices[index + 1] - pr);
                            }
                            break;
                        default:
                            if (index % 2 != 0)
                            {
                                profits.Add(prices[index + 1] - pr);
                            }
                            break;
                    }
                }
                index++;
            }
            return baseFunctions.calulateTotalProfits(profits);

        }

    }

}
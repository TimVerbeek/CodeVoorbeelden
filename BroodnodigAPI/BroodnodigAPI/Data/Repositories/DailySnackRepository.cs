using DeSpaakEntity.Data;
using DTO.DailySnack;
using SharedModels;

namespace BroodnodigAPI.Data.Repositories
{
    public class DailySnackRepository
    {

        private readonly BroodNodigContext context;

        public DailySnackRepository(BroodNodigContext broodNodigContext)
        {
            context = broodNodigContext;
        }
        public DailySnackResponse GetSnackByDate(DateTime date)
        {
            var snack = context.DailySnacks.Select(x =>
            new DailySnackResponse()
            {
                Date = x.Date,
                Id = x.Id,
                Name = x.Name
            }).Where(x => x.Date.Date == date.Date).FirstOrDefault();
            return snack;
        }
        public ICollection<DailySnackResponse> GetDailySnacks()
        {
            var snacks = context.DailySnacks.Select(s =>
                new DailySnackResponse()
                {
                    Date = s.Date,
                    Id = s.Id,
                    Name = s.Name
                }
            ).ToList();

            return snacks;
        }


        public void AddDailySnack(DailySnackWrite dailySnack)
        {
            context.DailySnacks.Add(new DailySnack()
            {
                Id = new Guid(),
                Name = dailySnack.Name,
                Date = dailySnack.Date
            });
            context.SaveChanges();

        }
        public DailySnackResponse GetDailySnackForToday()
        {
            var snack = context.DailySnacks.Select(x =>
            new DailySnackResponse()
            {
                Date = x.Date,
                Id = x.Id,
                Name = x.Name
            }).Where(x => x.Date.Date == DateTime.Today.Date).FirstOrDefault();
            return snack;
        }

        public void DeleteDailySnack(Guid id)
        {
            var dailySnack = context.DailySnacks.Where(i => i.Id == id).FirstOrDefault();
            context.Remove(dailySnack);
            context.SaveChanges();

        }
        

    }
}

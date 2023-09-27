using DataModels;
using DeSpaakEntity.Data;
using DTO.Order;

namespace BroodnodigAPI.Data.Repositories
{
    public class InfoOrderRepository
    {
        private readonly BroodNodigContext context;
        public InfoOrderRepository(BroodNodigContext broodNodigContext)
        {
            context = broodNodigContext;
        }


        public ICollection<InfoOrderResponse> GetAanmeldingen()
        {
            var orders = context.InfoOrders.Select(i =>
                new InfoOrderResponse()
                {
                    IsAangemeld = i.IsAangemeld,
                    Datum = i.Datum
                }
            ).Where(i => i.IsAangemeld == true && i.Datum.Date == DateTime.Today.Date).ToList();

            return orders;
        }
        public ICollection<InfoOrderInfoResponse> GetAllOrders()
        {
            var orders = context.InfoOrders.Select(i => new InfoOrderInfoResponse
            {
                Alergien = i.Alergien,
                Email = i.Email,
                HasDailySnack = i.HasDailySnack,
                Id = i.Id,
                Date = i.Datum
                , Opmerkingen = i.Opmerkingen,
                Aanwezig = i.IsAangemeld

            }).Where(i=>i.Date.Date == DateTime.Today.Date && i.Aanwezig == true).ToList();
            return orders;
        }


        public CheckOrder CheckIfOrderIsVailid(string email, DateTime date)
        {
            var order = context.InfoOrders.Where(i => i.Email == email && i.Datum.Date == date.Date).FirstOrDefault();
            if (order != null)
            {
                var check = new CheckOrder() { Email = order.Email };
                return check;
            }
            else { return null; }
        }

        public InfoOrderInfoResponse GetOrderInfoByEmail(string email)
        {
            var order = context.InfoOrders.Where(i => i.Email == email && i.Datum.Date == DateTime.Today.Date).FirstOrDefault();
            var infoOrder = new InfoOrderInfoResponse()
            {
                Email = order.Email,
                Aanwezig = order.IsAangemeld,
                Alergien = order.Alergien,
                Date = order.Datum,
                HasDailySnack = order.HasDailySnack,
                Id = order.Id,
                Opmerkingen = order.Opmerkingen
            };
            return infoOrder;   

                


        }



        public void AddInfoOrder(InfoOrderwrite order)
        {
            var addingorder = new InfoOrder()
            {
                Id = Guid.NewGuid(),
                Alergien = order.Alergien,
                Datum = DateTime.Now,
                Email = order.Email,
                HasDailySnack = order.HasDailySnack,
                IsAangemeld = order.IsAangemeld,
                Opmerkingen = order.Opmerkingen
            };

            context.InfoOrders.Add(addingorder);
            context.SaveChanges();
        }
        public void PutInfoOrder(InfoOrderwrite order, Guid id)
        {
            var orderToEdit = context.InfoOrders.Where(i => i.Id == id).FirstOrDefault();
            orderToEdit.IsAangemeld = order.IsAangemeld;
            orderToEdit.HasDailySnack = order.HasDailySnack;
            orderToEdit.Email = order.Email;
            orderToEdit.Opmerkingen = order.Opmerkingen;
            orderToEdit.Alergien = order.Alergien;

            context.SaveChanges();
        }















    }
}

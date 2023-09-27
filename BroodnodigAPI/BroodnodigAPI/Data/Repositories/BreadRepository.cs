using DeSpaakEntity.Data;
using DTO.Bread;
using Microsoft.AspNetCore.Http.HttpResults;
using SharedModels;

namespace BroodnodigAPI.Data.Repositories
{
    public class BreadRepository
    {
        private readonly BroodNodigContext context;
        public BreadRepository(BroodNodigContext broodNodigContext)
        {
            context = broodNodigContext;
        }
        public ICollection<BreadCardResponse> GetAllBreads()
        {
            var breads = context.Breads.Select(b =>
            new BreadCardResponse()
            {
                Id = b.Id,
                Name = b.Name,
                Type = b.Type,
            }).ToList();

            return breads;
        }
        public BreadResponse GetBread(Guid id)
        {
            var bread = context.Breads.FirstOrDefault(f=>f.Id == id);

            var Response = new BreadResponse()
            {
                Id = bread.Id,
                Inventory = bread.Inventory,
                Name = bread.Name,
                Type = bread.Type,
            };

            return Response;
        }
        public void AddBread(BreadWriteRequest bread)
        {
            context.Breads.Add(new Bread()
            {
                Id = new Guid(),
                Name = bread.Name,
                Type = bread.Type,
                Inventory = bread.Inventory
            });
            context.SaveChanges();
        }


        public void RemoveBread(Guid id)
        {

            var bread = context.Breads.FirstOrDefault(b => b.Id == id);
            try
            {
				context.Breads.Remove(bread);
				context.SaveChanges();

			}
			catch (Exception ex)
            {
                throw new Exception("Bread not found");
            }


        }

    }
}

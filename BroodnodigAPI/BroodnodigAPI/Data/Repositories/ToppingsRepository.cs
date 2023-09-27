using DeSpaakEntity.Data;
using DTO.Topping;
using SharedModels;

namespace BroodnodigAPI.Data.Repositories
{
	public class ToppingsRepository
	{
		private readonly BroodNodigContext context;

		public ToppingsRepository(BroodNodigContext broodNodigContext)
		{
			context = broodNodigContext;
		}
		public void AddTopping(ToppingWrite topping)
		{
			context.Toppings.Add(new Topping()
			{
				Id = Guid.NewGuid(),
				Name = topping.Name,
				Type = topping.Type,
				Inventory = topping.Inventory
			});
			context.SaveChanges();
		}
		public void DeleteTopping(ToppingCardResponse topping)
		{

			context.Toppings.Remove(new Topping()
			{
				Id = topping.Id,
				Type = topping.Type,
				Name = topping.Name,
				Inventory= topping.Inventory,

			});
			context.SaveChanges();
		}
		public ToppingCardResponse GetToppingById(Guid id)
		{
			var top = context.Toppings.FirstOrDefault(f => f.Id == id);

			var topping = new ToppingCardResponse()
			{
				Type = top.Type,
				Id = top.Id,
				Name = top.Name,
				Inventory= top.Inventory,
			};
			return topping;
		}
		public ICollection<ToppingCardResponse> GetAllToppings()
		{
			var toppings = context.Toppings.Select(t =>

				new ToppingCardResponse()
				{
					Id = t.Id,
					Name = t.Name,
					Type = t.Type,
					Inventory = t.Inventory,
				}

			).ToList();
			return toppings;

		}
		public ICollection<ToppingCardResponse> GetToppingsByType(string type)
		{
			var toppings = context.Toppings.Where(t => t.Type == type).Select(t => new ToppingCardResponse()
			{
				Id = t.Id,
				Name = t.Name,
				Type = t.Type
				,Inventory= t.Inventory
			}).ToList();
			return toppings;
		}
	}
}

using System;
namespace nutrition_planner.Models
{
	public class DailyMenu
	{
		public int DayNumber { get; set; }

		public List<FoodModel> BreakfastMenu { get; set; }
		public List<FoodModel> LunchMenu { get; set; }
		public List<FoodModel> DinnerMenu { get; set; }

	}
}


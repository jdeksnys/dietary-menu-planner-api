using System;
using nutrition_planner.Models;
using nutrition_planner.Data;



namespace nutrition_planner.BusinessLogicClasses
{
	public class WeeklyMenu
	{
		public WeeklyMenu()
		{
		}


		public static List<DailyMenu> GetWeeklyMenu(FoodModelContext _context,double kCalRequested, int noOfDays = 7)
        {
			//List<FoodModel> foodModelList;
			List<DailyMenu> result = new List<DailyMenu>();

			for (int i = 0; i < noOfDays; i++)
            {
				result.Add(new DailyMenu()
				{
					DayNumber = i,
					BreakfastMenu = FoodModelResult.GetFoodModelResult(_context, kCalRequested),
					LunchMenu = FoodModelResult.GetFoodModelResult(_context, kCalRequested),
					DinnerMenu= FoodModelResult.GetFoodModelResult(_context, kCalRequested)
				});
            }

			return result;
        }
	}
}


using System;
using nutrition_planner.Data;



namespace nutrition_planner.BusinessLogicClasses
{
	public class RandomSet
	{
		private readonly FoodModelContext _context;


		//public RandomSet()
		//{
		//}


		//get random set of numbers (used as ID for querying food items)
		public static List<int> GetRandomSet(FoodModelContext _context,int n)//n - number of random foods
		{		
            int totalRecords = _context.FoodModels.Count();
			Random randomClass = new Random();
			List<int> randomList = new List<int>();

			for (int i = 0; i < n; i++)
			{
				int random = randomClass.Next(totalRecords);
				randomList.Add(random);
			}

			return randomList;
		}
	}
}


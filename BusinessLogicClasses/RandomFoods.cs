using System;
using nutrition_planner.Data;
using nutrition_planner.Models;



namespace nutrition_planner.BusinessLogicClasses
{
	public class RandomFoods
	{
		private readonly FoodModelContext _context;



		//public RandomFoods()
		//{
		//}



		//get list of random food items from database
		public static List<FoodModel> GetRandomFoods(FoodModelContext _context,int nFoods)
		{
			List<int> randomList = RandomSet.GetRandomSet(_context, nFoods);
			int n = randomList.Count();
			List<FoodModel> foodModelList = new List<FoodModel>();

			//get food item by ID (randomly generated)
			foreach (int i in randomList)
			{
				FoodModel record = _context.FoodModels.Single(b => b.ID == i);
				foodModelList.Add(record);
			}

			return foodModelList;
		}
	}
}


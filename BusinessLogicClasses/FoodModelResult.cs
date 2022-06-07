using System;
using nutrition_planner.Models;
using MathNet.Numerics.LinearAlgebra;
using nutrition_planner.Data;



namespace nutrition_planner.BusinessLogicClasses
{
	public class FoodModelResult
	{
		private readonly RandomFoods _randomFoods;



		public FoodModelResult()
		{			
		}


		//Get food items and their proportional amounts (weight), calculated to not exceed kCal resuest.
		public static List<FoodModel> GetFoodModelResult(FoodModelContext _context, double kCalRequested, int noOfFoods=3)
		{
			List<FoodModel> foodModelList = RandomFoods.GetRandomFoods(_context, noOfFoods);
			Vector<double> massProportions = LeastSquaresApproximation.GetLeastSquaresApproximation(foodModelList);

			//number of elements
			int n = foodModelList.Count();

			//kCal for calculation process
			List<double?> kCalTotal = new List<double?>();

			//for calculation process
			double kCalSum = 0;

			//ratio for calculating proportions of foods by mass
			double kCalRatio;

			//final mass of products after proportion estimation
			List<double> massQuantities = new List<double>() { 100, 100, 100 };



			//get sum of kCal for selected food items (unproportional)
			for (int i = 0; i < n; i++)
			{
				kCalTotal.Add(foodModelList[i].Kilocalories * massProportions[i]);
				kCalSum += kCalTotal[i].Value;
			}

			kCalRatio = kCalRequested / kCalSum;
			double result;


			//get weight proportion for food items (proportional)
			for (int i = 0; i < n; i++)
			{
				result = massQuantities[i] * massProportions[i] / kCalRatio;
				foodModelList[i].CalculatedMass = Math.Round(result,2);
			}

			return foodModelList;
		}
	}
}


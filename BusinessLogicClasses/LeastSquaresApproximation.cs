using System;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using nutrition_planner.Data;
using nutrition_planner.Models;


namespace nutrition_planner.BusinessLogicClasses
{
	public class LeastSquaresApproximation
	{
		public LeastSquaresApproximation()
		{
		}


		//least squares method for approximating amounts of each food item
		//A(A^T)x=(A^t)b, solve for x, where A - prot., carb, fat values, b - required level of nutrients as fraction
		public static Vector<double> GetLeastSquaresApproximation(List<FoodModel> foodModelList)		
		{
			int n = foodModelList.Count();
			Matrix<double> A = Matrix<double>.Build.Dense(n, 3);
			Vector<double> b = Vector<double>.Build.Dense(new double[] { 0.2, 0.3, 0.5 });

			for (int i = 0; i < n; i++)
			{
				A[i, 0] = (double)foodModelList[i].Protein/100;
				A[i, 1] = (double)foodModelList[i].Carbohydrate/100;
				A[i, 2] = (double)foodModelList[i].Fat/100;
			}

			var AAtinv = (A.Transpose().Multiply(A)).Inverse();
			var Atb = A.Transpose().Multiply(b);

			//x=((A(A^T))^-1)(A^t)b
			Vector<double> x =  AAtinv.Multiply(Atb);

			return x;
		}
	}
}


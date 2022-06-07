using System;
using System.ComponentModel.DataAnnotations.Schema;



namespace nutrition_planner.Models
{
	//model for food items (EF)
	[Table("food_table")]
	public class FoodModel
	{
		public int ID { get; set; }

		public string? Category { get; set; }

		public string? Description { get; set; }

		[Column(TypeName = "float(2)")]
		public double? Carbohydrate { get; set;}

		[Column(TypeName = "float(2)")]
		public double? Kilocalories { get; set; }

		[Column(TypeName = "float(2)")]
		public double? Protein { get; set; }

		[Column(TypeName = "float(2)")]
		public double? Sugar { get; set; }

		[Column(TypeName = "float(2)")]
		public double? Water { get; set; }

		[Column(TypeName = "float(2)")]
		public double? Fat { get; set; }

		[Column(TypeName = "float(2)")]
		public double? CalculatedMass { get; set; } = null;
	}
}

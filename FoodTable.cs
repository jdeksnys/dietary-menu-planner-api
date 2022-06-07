using System;
using System.Collections.Generic;

namespace nutrition_planner
{
    public partial class FoodTable
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public double? Carbohydrate { get; set; }
        public double? Kilocalories { get; set; }
        public double? Protein { get; set; }
        public double? Sugar { get; set; }
        public double? Water { get; set; }
        public double? Fat { get; set; }
    }
}

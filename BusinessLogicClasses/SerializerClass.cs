using System;
using nutrition_planner.Data;
using nutrition_planner.Models;
using System.Text.Json;


namespace nutrition_planner.BusinessLogicClasses
{
	public class SerializerClass
	{
		private readonly FoodModelContext _context;



        public SerializerClass(FoodModelContext context)
        {
			_context = context;
        }

		

		//serialize class to json string
		public static string serializeJson(List<DailyMenu> dailyList)
        {
			return JsonSerializer.Serialize<IEnumerable<DailyMenu>>(dailyList);
        }
	}
}
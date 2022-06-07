using System;
using Microsoft.AspNetCore.Mvc;
using nutrition_planner.Data;
using nutrition_planner.Models;
using nutrition_planner.BusinessLogicClasses;

namespace nutrition_planner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodModelController : ControllerBase
    {
        private readonly FoodModelContext _context;

        public FoodModelController(FoodModelContext context)
        {
            _context = context;
        }


        //GET request with kCal, day count in query string
        [HttpGet("{kCalRequested}/{days}")]
        public string GetFoodModels(double kCalRequested, int days)
        {            
            List<DailyMenu> MenuForWeek = WeeklyMenu.GetWeeklyMenu(_context,kCalRequested,days);

            string json = SerializerClass.serializeJson(MenuForWeek);
            return json;
        }
    }
}

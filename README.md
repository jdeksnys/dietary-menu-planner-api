# Dietary planner web api

## Get started:
Use Swagger: https://dietary-menu-planner-api.azurewebsites.net/swagger/index.html</br>
or</br>
request url: https://dietary-menu-planner-api.azurewebsites.net/api/FoodModel/{kCal}/{days} </br>

where:</br>
kCal - kilo-callorie count for single meal</br>
days - day count for meal plan (ex. 7). NOTE! large number of days takes longer to run query!



## About
Returns random meal plan (3 meals/day) for specified number of days. Ratio of food products calculated by least squares approximation to match protein, fat, carb. levels.

Working principle:
- 6089 food products with macronutrient data are stored in AWS RDS database. Data source: https://www.kaggle.com/datasets/shrutisaxena/food-nutrition-dataset. Values filtered by hand to exclude meat/pork/beef values.
- Random products are chosen from database (for specified no. of days) having individual kCal and protein, carb., fat levels.
- Share of macronutrient in each meal assumed fixed (protein: 20%, fat: 30%, carb.:50%).
- Proportions of each food product for meal calculated via Least squares method by finding amount to fulfill daily nutrient levels mentioned above. Major flaw: least squares can return negative estimations (negative food amounts), thus non-negative least squares approximation must be used instead.
- Then, mass of of each product calculated porportionally to match requested kCal amount (for meal).


Jonas Deksnys

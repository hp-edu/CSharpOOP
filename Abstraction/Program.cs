/* Abstraction:
 Abstraction is the concept of hiding the complicated reality while exposing only the necessary parts. 

 Consider a kitchen in a restaurant. The customers give their food preferences, and they don't necessarily care or need to know about the cooking details - just that their food is prepared and ready to eat.

 In our example, both Steak and Salad implement an IFood interface. This interface sets a contract for any food item. When cooking and fetching information about different food items, we don't need to know specifics about each item as long as they conform to the IFood contract. This decouples the specific food implementation from the process of cooking and displaying them.
 */


List<IFood> order = new List<IFood>
        {
            new Steak("Medium"),
            new Salad("Greek"),
            new Steak("Well Done"),
            new Salad("Caesar")
        };


foreach (var food in order)
{
    food.Cook();
    food.GetInformation();
    Console.WriteLine("----------------------");
}
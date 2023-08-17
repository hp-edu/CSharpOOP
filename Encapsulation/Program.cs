/*
Encapsulation:
Encapsulation refers to the bundling of data (attributes) and methods (functions) that operate on the data into a single unit, while also restricting direct access to some of the object's components. It's a way to control the access to the state of an object.

Consider a steak cooking process. We encapsulate the whole process of cooking the steak inside the Steak class. Here, we're keeping the "knowledge" of how to cook the steak (the method) bundled with the steak's own attributes (like its internalTemperature or desiredTemperature).

Benefits:

Control: You can restrict set operations or validate the new value before setting it.
Flexibility and Maintenance: You can change the internal implementation without affecting the classes that use it.
Increased Security: Prevent unauthorized access and modification.

*/


Steak mySteak = new Steak("Medium");
mySteak.Cook();
mySteak.GetInformation();

System.Console.WriteLine();
System.Console.WriteLine("----------------------");
System.Console.WriteLine();

Salad mySalad = new Salad("Greek");
mySalad.Cook();
mySalad.GetInformation();


public class Steak
{
    private string preference;
    private int desiredTemperature;    // Target temperature based on the doneness
    private int internalTemperature;   // The current internal temperature of the steak

    public Steak(string preference)
    {
        this.preference = preference;
    }
    public void Cook()
    {
        switch (preference)
        {
            case "Rare":
                desiredTemperature = 120;
                break;
            case "Medium Rare":
                desiredTemperature = 130;
                break;
            case "Medium":
                desiredTemperature = 140;
                break;
            case "Medium Well":
                desiredTemperature = 150;
                break;
            case "Well Done":
                desiredTemperature = 160;
                break;
            default:
                Console.WriteLine("Invalid doneness specification. Using default of Medium.");
                desiredTemperature = 140;
                break;
        }

        // Simulate cooking the steak, where temperature increases by 5°F each minute
        while (internalTemperature < desiredTemperature)
        {
            System.Threading.Thread.Sleep(50); // Pausing for a moment to simulate time
            internalTemperature += 10;
            Console.WriteLine($"Cooking... Internal temperature: {internalTemperature}°F");
        }

        Console.WriteLine($"Steak is ready");
    }

    public void GetInformation()
    {
        Console.WriteLine($"Steak is cooked to {preference} with an internal temperature of {internalTemperature}°F.");
    }
}

public class Salad
{
    private string preference;
    private string[] ingredients;
    private string dressing;

    public Salad(string preference)
    {
        this.preference = preference;
    }

    public void Cook()
    {
        switch (preference)
        {
            case "Caesar":
                ingredients = new string[] { "Romaine lettuce", "Parmesan cheese", "Croutons" };
                dressing = "Caesar dressing";
                break;

            case "Greek":
                ingredients = new string[] { "Tomato", "Cucumber", "Red onion", "Feta cheese", "Olives" };
                dressing = "Olive oil and vinegar";
                break;

            case "Cobb":
                ingredients = new string[] { "Lettuce", "Tomato", "Bacon", "Chicken breast", "Hard-boiled egg", "Avocado", "Roquefort cheese" };
                dressing = "Red-wine vinaigrette";
                break;

            default:
                Console.WriteLine("Unknown salad type. Defaulting to Caesar.");
                ingredients = new string[] { "Romaine lettuce", "Parmesan cheese", "Croutons" };
                dressing = "Caesar dressing";
                break;
        }
        Console.WriteLine($"Salad is ready");
    }

    public void GetInformation()
    {
        string ingredientsList = string.Join(", ", ingredients);
        System.Console.WriteLine($"{preference} salad with ingredients: {ingredientsList}. Dressed with {dressing}.");
    }
}
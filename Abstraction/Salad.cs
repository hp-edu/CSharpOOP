public class Salad : IFood
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
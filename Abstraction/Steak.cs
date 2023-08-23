public class Steak : IFood
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

        // Simulate cooking the steak, where temperature increases by 5°F each minute (Removed internal temperatur tracking)
        while (internalTemperature < desiredTemperature)
        {
            internalTemperature += 10;
        }

        Console.WriteLine($"Steak is ready");
    }

    public void GetInformation()
    {
        Console.WriteLine($"Steak is cooked to {preference} with an internal temperature of {internalTemperature}°F.");
    }
}
public class Fork : KitchenTool
{
    public int NumberOfTines { get; set; }

    public Fork(string material, int numberOfTines) : base(material)
    {
        NumberOfTines = numberOfTines;
    }

    public void Bend()
    {
        Console.WriteLine($"The {Material} fork with {NumberOfTines} tines has been bent.");
    }
}

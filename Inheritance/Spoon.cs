public class Spoon : KitchenTool
{
    public double Capacity { get; set; }

    public Spoon(string material, double capacity) : base(material)
    {
        Capacity = capacity;
    }

    public override void Use()
    {
        base.Use();
        Console.WriteLine($"The {Material} spoon with a capacity of {Capacity} ounces has scooped something.");
    }
}

public class KitchenTool
{
    public string Material { get; set; }
    public bool IsClean { get; set; }

    public KitchenTool(string material)
    {
        Material = material;
        IsClean = true; // default state
    }

    public virtual void Use()
    {
        IsClean = false;
        Console.WriteLine($"The {Material} kitchen tool has been used and is now dirty.");
    }

    public void Clean()
    {
        IsClean = true;
        Console.WriteLine($"The {Material} kitchen tool is now clean.");
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"This is a {Material} tool. Clean status: {IsClean}");
    }
}

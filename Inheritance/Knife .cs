public class Knife : KitchenTool
{
    public double Length { get; set; }
    public bool IsSharp { get; set; }

    public Knife(string material, double length) : base(material)
    {
        Length = length;
        IsSharp = true; // default state
    }

    public void Sharpen()
    {
        IsSharp = true;
        Console.WriteLine($"The {Material} knife of length {Length} inches is now sharp.");
    }

    public override void Use()
    {
        base.Use();
        IsSharp = false;
        Length = Length * 0.99;
        Console.WriteLine($"The {Material} knife has cut something.");
    }
}

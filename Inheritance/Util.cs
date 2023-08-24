using System.Text;
public static class Util
{
    public static void LineBreakWithDashes(int numberOfDash)
    {
        StringBuilder dashes = new StringBuilder();
        for (int i = 0; i < numberOfDash; i++)
        {
            dashes.Append("-");
        }
        System.Console.WriteLine();
        System.Console.WriteLine(dashes.ToString());
        System.Console.WriteLine();
    }
}
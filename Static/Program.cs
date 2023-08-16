/*
Definition: Static members belong to the class itself and not to any specific instance. This means only one copy of a static member exists, regardless of the number of objects created.

Purpose:
Utility and Helper Classes: Sometimes, you want to create classes that offer functionality which doesn't need to be tied to an instance. Common examples are utility or helper classes, such as a Math class with methods like Math.Sqrt().
Shared Data: When you want a piece of data to be shared among all instances of a class, you can use a static field. This ensures that all instances read/write from the same memory location for that particular data.
Singleton Pattern: To ensure that a class has only one instance and provides a global point of access to it.

Usage:
Efficiency: Since static members are allocated only once, they can be more memory-efficient if the functionality or data doesn't need to be duplicated across instances.
Ease of Access: Static members can be accessed without creating an instance of the class, making them easily accessible.
*/


/* 
1. When you define a member as static, it means that member belongs to the class rather than any object of that class. 
*/
Console.WriteLine(MathHelper.Add(2, 3));
Console.WriteLine(Calculator.Name);


// 2. Access instance method 
Calculator calc = new();
calc.Add(3);
Console.WriteLine(calc.GetBaseValue);
Console.WriteLine(calc.GetStaticBaseValue);
Calculator calc2 = new();
calc2.Add(4);
Console.WriteLine(calc2.GetBaseValue);
Console.WriteLine(calc2.GetStaticBaseValue);

// 3. Directly access static members of the class through that instance from outside the class makes error
// Console.WriteLine(calc.Name);  

// 4. Within the context of an instance method or instance property inside a class, you can access the static members of that class.
Console.WriteLine(calc.GetCalculatorName);

// 5. To access instance member through static method, instance should be passed to the method
Console.WriteLine(Calculator.GetValue(calc));


public static class MathHelper
{
    public static string Add(int a, int b)
    {
        return $"Static class and method can be used like utility. {a}+{b}: {a + b}";
    }
}


public class Calculator
{
    private int _baseValue = 0;
    private static int _staticBaseValue = 0;

    public int Add(int value)
    {
        _baseValue += value;
        _staticBaseValue += value;
        return _baseValue;
    }

    public string GetBaseValue => $"Current _baseValue: {_baseValue}";
    public string GetStaticBaseValue => $"Current _staticBaseValue: {_staticBaseValue}";
    public string GetCalculatorName => $"Called from instance property. {Name}";
    public static string Name => $"Simple Calculator";


    // 4-1. Static member cannot access instance member directly
    // public static int BaseValue => _baseValue;  
    public static int GetValue(Calculator calc) => calc._baseValue;

}
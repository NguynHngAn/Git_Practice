string value1 = "ABC";
int value2 = 1;
decimal value3 = 10.1m;
double value4 = 10.1;


Console.WriteLine(NumbericTypeDescriber.Describe(value1));
Console.WriteLine(NumbericTypeDescriber.Describe(value2));
Console.WriteLine(NumbericTypeDescriber.Describe(value3));
Console.WriteLine(NumbericTypeDescriber.Describe(value4));

Console.ReadKey();

public static class NumbericTypeDescriber
{
    public static string Describe(object someObject)
    {
        if (someObject is int asInt)
        {
            return "Int of value " + asInt;
        }
        else if (someObject is double asDouble)
        {
            return "Double of value " + asDouble;
        }
        else if (someObject is decimal asDecimal)
        {
            return "Decimal of value " + asDecimal;
        }
        return null;
    }
}
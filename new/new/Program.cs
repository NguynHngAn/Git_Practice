Dog dog = new Dog();

int integer = 10;
decimal a = integer;
Console.WriteLine(a);

decimal b = 10.1m;
int c = (int)b;
Console.WriteLine(c);



Console.ReadKey();

class Animal
{
    public int _legs;
    public int _height;
    public int _width;

    public Animal()
    {
        Console.WriteLine("Constructor from the Animal class");
    }
    public Animal(int legs, int height, int width)
    {
        _legs = legs;
        _height = height;
        _width = width;
    }
    public void Print()
    {
        Console.WriteLine($"Dog have {_legs} legs, {_height} cm, {_width} kg");
    }

    public void PrintInfo(int legs, int height, int width)
    {
        Console.WriteLine($"Dog have {legs} legs, {height} kg, {width} cm");
    }

}

class Dog : Animal
{
    public Dog()
    {
        Console.WriteLine("This constructor from Dog class");
    }

    public Dog(int legs, int height, int width) : base(legs, height, width)
    {

    }
    public new void Print()
    {
        Console.WriteLine($"Dog have {_legs} legs, {_height} cm, {_width} kg");
    }
}
// Polymorphism using inheritance and overwriting the virtual method of the base class.
List<Animal> animals = new List<Animal>
{
    new Cat("ramiro"),
    new Dog("federico")
};

foreach (var animal in animals)
{
    Console.WriteLine($"{animal.Name} says: {animal.MakeSound()}");
}

// Polymorphism using interfaces
List<IShape> shapes = new List<IShape>
{
    new Circle{ Radius = 2 },
    new Square { Width = 3 },
};

foreach (var shape in shapes)
{
    Console.WriteLine($"Area {(shape.GetType())} is: {shape.CalculateArea()}");
}


public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
    public virtual string MakeSound()
    {
        return "Some sound";
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name){}
    public override string MakeSound()
    {
        return "Miauuu";
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name){}
    public override string MakeSound()
    {
        return "Guauuu";
    }
}

public interface IShape
{
    double CalculateArea();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : IShape
{
    public double Width { get; set; }

    public double CalculateArea()
    {
        return Width * Width;
    }
}
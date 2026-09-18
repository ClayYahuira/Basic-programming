// We are going to see the difference between class and struct

//Class is a reference type

var point01 = new ClassPoint { X = 1, Y = 2 };
var point02 = point01;
point02.X = 100;
if (point01.GetHashCode() == point02.GetHashCode())
{
    // Even if we change the one property in the second object the first object will
    // also change because they are pointing to the same reference in Heap memory 
   Console.WriteLine("They have same HashCode");
   Console.WriteLine($"Value property first object: {point01.X}. Value property second object: {point02.X}"); // Same value
}

//Struct is a value type and this inherit from ValueType object

var structPoint01 = new StructPoint { X = 1, Y = 2 };
var structPoint02 = structPoint01;
structPoint02.X = 100;
if (structPoint01.GetHashCode() != structPoint02.GetHashCode())
{
    // When we change the property in the second object the first object will not change
    // because they are pointing to different memory locations in Stack memory
    Console.WriteLine("They don't have same HashCode");
    Console.WriteLine($"Value property first struct: {structPoint01.X}. Value property second struct: {structPoint02.X}"); // Different value
}

Console.ReadLine();

public class ClassPoint
{
    public int X { get; set; }
    public int Y { get; set; }
}

// this is saved in the stack. Doesn't allow inheritance. Not null. Constructor with parameters always. Memory efficiency. For small data and immutables.
public struct StructPoint
{
    public int X { get; set; }
    public int Y { get; set; }
}
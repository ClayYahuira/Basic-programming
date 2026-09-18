// Nullable wrap the primitive type within a struct that contains T and bool property.
int? number = null;

// The Nullable struct has HasValue property to know if the nullable variable contains a value or not.
Console.WriteLine($"Has value?: {number.HasValue}");
number = 1;
// The Nullable struct with the Value property we can get the value of the nullable variable.
Console.WriteLine($"Value?: {number.Value}");

// We use ?? Null-coalescing operator evaluates if the variable is null, if it is not null will return its itself value.
int? number2 = number ?? 0; // If number is null then assign 0 to number2
Console.WriteLine($"Value number2: {number2.Value}");

// We use ?. Null conditional operator when we want to get a property or method of an object that could be null. If the object is null, it will return null instead of throwing an exception.
string? name  = null;
var length = name?.Length; // It will return null because name is null.
Console.WriteLine($"Length of name: {length}");
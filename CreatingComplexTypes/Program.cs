using CreatingComplexTypes;

// Creating a Complex<string> instance with reflection

var baseType = typeof(Complex<>);
var underlyingType = typeof(string);

var fullComplexType = baseType.MakeGenericType(underlyingType);

var complexInstance = Activator.CreateInstance(fullComplexType);

var bp = "";
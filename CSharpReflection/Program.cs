#region usings
using MyNamespace;
#endregion
//The C# 'Type' class

var myClassType = typeof(MyClass);

#region 0

//You can get a type from 'anything'
var objectType = typeof(object);
var stringType = typeof(string);

var myEnumType = typeof(MyEnum);

#region 1
//The assembly in which 'MyClass' resides
var myClassAssembly = myClassType.Assembly;

//The name of 'MyClass' including any namespace it might have
var myClassFullName = myClassType.FullName;

var bp1 = "";

#region 2
//Retrieving type from an instance
var myInstance = new MyClass();

var myClassTypeFromInstance = myInstance.GetType();

#region 3
// Equality is the same for both ways
var isSameType = myClassType == myClassTypeFromInstance;

#endregion
#endregion
#endregion
#endregion

var bp = "";

public enum MyEnum { A, B, C, D }

namespace MyNamespace
{
    public class MyClass { }
}
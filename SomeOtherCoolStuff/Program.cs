using CSharReflection.Models;
using System.Reflection;

#region shhh
var bp = "";
#endregion

#region 0
//The type to work with
var personType = typeof(Person);
bp = "";

#region 1
//Lists all PUBLIC properties from 'Person'
var properties = personType.GetProperties();
bp = "";

#region 2
//Lists ALL properties from 'Person'
var publicMethods = personType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
bp = "";

#region 3
//Lists ALL methods from 'Person'
var allMethods = personType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
bp = "";

#region 4
//Setting the value of the 'Name' property with reflection
var person = new Person() { Name = "Fulano" };
bp = "";

var nameProp = personType.GetProperty("Name")!;
nameProp.SetValue(person, "Cicrano");
bp = "";

#region 5
//Getting the value of the 'Name' property with reflection
var name = nameProp.GetValue(new Person());
bp = "";

#region 6
//Listing all the types from the assembly in wich the type 'Person' resides (in this case, the 'Models' assembly)
personType.Assembly.GetTypes().Select(x => x.Name);
bp = "";

#region 7
//Listing all the constructors from 'Person'
var ctors = personType.GetConstructors();
bp = "";

#region 8
//Only the constructors with some parameters
var parameterizedCtor = ctors.First(x => x.GetParameters().Length > 0);
bp = "";

#region 9
//The parameters of that constructor
var parameters = parameterizedCtor.GetParameters();

var formattedConstructor = string.Join(", ", parameters.Select(x => $"{x.ParameterType.Name} {x.Name}"));

bp = "";
#endregion
#endregion
#endregion
#endregion
#endregion
#endregion
#endregion
#endregion
#endregion
#endregion
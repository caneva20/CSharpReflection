using System.Reflection;
using UsingAttributes;

//This is the current assembly, used as a starting point for our search
var root = typeof(Program).Assembly;
#region 0
//Look through all the types and filter only those containing the 'CoolPet' attribute
var coolPetTypes = root.GetTypes().Where(x => x.GetCustomAttribute<CoolPetAttribute>() != null);

var bp = "";

#region 1
foreach (var coolPetType in coolPetTypes)
{
    var coolPetAttribute = coolPetType.GetCustomAttribute<CoolPetAttribute>();
    Console.WriteLine($"{coolPetType.Name} is a cool pet! \n\tDescription: {coolPetAttribute?.Description ?? "(unknown)"}");
}

#endregion
#endregion

#region pets
//Define some pets
[CoolPet]
public class Dog { }

[CoolPet(Description = "Purrr")]
public class Cat { }

public class Chihuahua : Dog { } //disclaimer: This is the devil

public class Snake { } //disclaimer²: **I** don't like thoose
#endregion
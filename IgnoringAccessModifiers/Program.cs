#region usings
using CSharReflection.Models;
using System.Reflection;
#endregion

var publicInstance = new Animal();

#region 0
//var car = new Car(); //DOES NOT WORK

#region 1
//lets create it anyways
var carType = typeof(Car);

var carObj = Activator.CreateInstance(carType, true); // 'true' lets the activator create an instance even for PRIVATE constructors

var car = (carObj as Car)!;

var bp1 = "";

#region 2
//We can use it as usual now
car.Accelerate();
car.Accelerate();
car.Accelerate();

var breakpoint0 = "";

#region 3
//What about nitro??
//car.AddNitro(); //:( can't do this, it is private

#region 4
//F it, I want nitro!!
var addNitroInfo = carType.GetMethod("AddNitro", BindingFlags.NonPublic | BindingFlags.Instance)!;

var bp = "";

addNitroInfo.Invoke(car, null); //The 'null' represents a list of parameters, as we have none, we gave it null
addNitroInfo.Invoke(car, null);
#endregion
#endregion
#endregion
#endregion
#endregion


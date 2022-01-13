using BenchmarkDotNet.Running;
using ThePerformanceOfIt;

#region constructors
/*
|                Method |      Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------- |----------:|----------:|----------:|------:|--------:|
|     NormalConstructor |  2.557 ns | 0.0957 ns | 0.0849 ns |  1.00 |    0.00 |
| ReflectionConstructor | 13.625 ns | 0.3479 ns | 0.5908 ns |  5.39 |    0.32 |
 */
var result = BenchmarkRunner.Run<ConstructorBechmark>();
#endregion

#region methods
/*
|               Method |       Mean |     Error |    StdDev | Ratio | RatioSD |
|--------------------- |-----------:|----------:|----------:|------:|--------:|
|     NormalInvocation |  0.9658 ns | 0.0721 ns | 0.0640 ns |  1.00 |    0.00 |
| ReflectionInvocation | 94.9225 ns | 1.8445 ns | 2.2652 ns | 98.67 |    5.55 |
 */
var result1 = BenchmarkRunner.Run<MethodBechmark>();
#endregion
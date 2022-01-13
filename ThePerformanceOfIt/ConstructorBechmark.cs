using BenchmarkDotNet.Attributes;
using CSharReflection.Models;

namespace ThePerformanceOfIt;

public class ConstructorBechmark
{
    [Benchmark(Baseline = true)]
    public Truck NormalConstructor()
    {
        return new Truck();
    }

    [Benchmark]
    public Truck ReflectionConstructor()
    {
        var truckType = typeof(Truck);

        return (Truck)Activator.CreateInstance(truckType)!;
    }
}

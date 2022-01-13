using BenchmarkDotNet.Attributes;
using CSharReflection.Models;

namespace ThePerformanceOfIt;

public class MethodBechmark
{
    private Truck truck;

    [GlobalSetup]
    public void Setup()
    {
        truck = new Truck();
    }

    [Benchmark(Baseline = true)]
    public string NormalInvocation()
    {
        return truck.Honk();
    }

    [Benchmark]
    public string? ReflectionInvocation()
    {
        var truckType = typeof(Truck);

        var honkInfo = truckType.GetMethod("Honk")!;

        return honkInfo.Invoke(truck, null) as string;
    }
}

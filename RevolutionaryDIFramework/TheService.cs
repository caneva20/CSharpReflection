namespace RevolutionaryDIFramework;

public interface ITheService
{
    void PretendToWork();
}
public class TheService : ITheService
{
    private readonly IServiceA _serviceA;

    public TheService(IServiceA serviceA)
    {
        _serviceA = serviceA;
    }

    public void PretendToWork()
    {
        _serviceA.DoWork();

        Console.WriteLine("Working hard");
    }
}

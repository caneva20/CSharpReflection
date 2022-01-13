namespace RevolutionaryDIFramework;

public interface IServiceA
{
    public void DoWork();
}
public class ServiceA : IServiceA
{
    public void DoWork()
    {
        Console.WriteLine("Doing some work");
    }
}

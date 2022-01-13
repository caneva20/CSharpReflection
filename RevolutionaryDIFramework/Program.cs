using RevolutionaryDIFramework;

var container = new DIContainer();

container.Register<ServiceA, IServiceA>();
container.Register<TheService, ITheService>();

var service = container.Get<ITheService>()!;
service.PretendToWork();

var serviceB = container.Get<IServiceB>();

var bp = "";
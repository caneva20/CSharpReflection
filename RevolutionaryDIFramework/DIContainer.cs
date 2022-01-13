namespace RevolutionaryDIFramework
{
    public class DIContainer
    {
        private readonly Dictionary<Type, object> _container = new();

        public void Register<T, TBase>() where T : TBase
        {
            _container.Add(typeof(TBase), CreateType(typeof(T)));
        }

        public T? Get<T>() where T : class
        {
            return Get(typeof(T)) as T;
        }

        private object Get(Type type)
        {
            if (_container.ContainsKey(type))
            {
                return _container[type];
            }

            throw new Exception($"Type {type.FullName} not registered");
        }

        private object CreateType(Type type)
        {
            var ctor = type.GetConstructors().FirstOrDefault();

            if (ctor == null)
            {
                return Activator.CreateInstance(type)!;
            }

            var dependencies = new List<object>();

            foreach (var param in ctor.GetParameters())
            {
                var dependency = Get(param.ParameterType);

                if (dependency == null)
                {
                    throw new Exception($"The type {type.FullName} can't be constructed, missing dependency {param.ParameterType.FullName}");
                }

                dependencies.Add(dependency);
            }

            return ctor.Invoke(dependencies.ToArray());
        }
    }
}

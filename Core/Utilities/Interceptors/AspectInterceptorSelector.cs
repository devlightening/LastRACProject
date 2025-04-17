using System.Reflection;
using Castle.DynamicProxy;
using Core.Aspects.Performance;



namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            classAttributes.Add(new PerformanceAspect(5));
            // classAttributes.Add(new ExceptionLogAspect(typeof(FileLogger))); //--> otomatik olarak sistemdeki tum metotlari log'a dahil eder.

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }

  
    }
}
}

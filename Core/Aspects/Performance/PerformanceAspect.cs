using Castle.DynamicProxy;
using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using Core.Utilities.Interceptors;


namespace Core.Aspects.Performance
{
     public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch; //--> kronometre

        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = Utilities.IoC.ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }


        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }

        protected override void OnAfter(IInvocation invocation)
        {
            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                Debug.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-->{_stopwatch.Elapsed.TotalSeconds}");
            }
            _stopwatch.Reset();
        }
    }
}

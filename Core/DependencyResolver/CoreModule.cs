using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;

namespace Core.DependencyResolver
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            // 1. Bellek önbelleği hizmetini ekler.
            serviceCollection.AddMemoryCache();

            // 2. HttpContextAccessor servisini tekil (singleton) olarak ekler.
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // 3. ICacheManager interface'ini ve onu implemente eden MemoryCacheManager sınıfını DI container'a ekler.
            serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();

            // 4. Stopwatch nesnesini singleton olarak ekler.
            serviceCollection.AddSingleton<Stopwatch>();
        }
    }
}
    
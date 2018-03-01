using MagicMirror.DataAccess;
using Microsoft.Extensions.DependencyInjection;

namespace MagicMirror.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddTransient<FooManager>();
            services.AddTransient<IFooRepo, FooRepo>();
            var provider = services.BuildServiceProvider();

            var service1 = provider.GetService<FooManager>();
            service1.KillSelf();
        }
    }
}
using System;
using Microsoft.Extensions.DependencyInjection;
using SimpleDependencyResolver.Abstracts.Data;
using SimpleDependencyResolver.Data;

namespace SimpleDependencyResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting testing...");

            //setup our DI
            var serviceProvider = new ServiceCollection()
            .AddSingleton<ITypeC, TypeC>()
            .AddSingleton<ITypeB, TypeB>()
            .AddSingleton<ITypeA, TypeA>()
            .BuildServiceProvider();

            var typeA = serviceProvider.GetService<ITypeA>();
            var expectedValue = typeA.RequireTypeBToGetValue();
            Console.WriteLine($"expectedValue = {expectedValue}");

            Console.WriteLine("All done!");
        }
    }
}

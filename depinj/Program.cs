using System;
using Microsoft.Extensions.DependencyInjection;

// Dependency injection is used when we create a web application
namespace depinj
{

    interface ILogger{
        void print(String message)
;    }

    // we assume this is loggin device
    class Logger : ILogger{
        public void print(String message){
            System.Console.WriteLine(message);
        }
    }

    interface IStartUp{
        void startUp(String m);
    }

    class StartUp : IStartUp
    {
        public void startUp(string m)
        {
            System.Console.WriteLine("STARTUP " + m);
        }
    }
    // we assume this is web server
    // we depdent on interface ILogger and not implementation ( Logger )
    class App{
        ILogger l;

        public App(ILogger l, IStartUp s){
            s.startUp("MyApp");
            this.l = l;
        }

        public void run(){
            l.print("startup");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // we have to include package using terminal ' dotnet add package Microsoft.Extensions.DependencyInjection '
            var services = new ServiceCollection();
            // now we register our services into container
            // now the services know that there is a service which exposes interface ILogger and actual implenetation is Logger class
            services.AddTransient<ILogger, Logger>();
            // register another service we defined
            services.AddTransient<IStartUp, StartUp>();
            // register our app
            services.AddTransient<App>();
            // this now creates our container based on registered services
            ServiceProvider p = services.BuildServiceProvider();
            App app = p.GetService<App>();
            app.run();
        }
    }
}

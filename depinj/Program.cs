using System;

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

    // we assume this is web server
    // we depdent on interface ILogger and not implementation ( Logger )
    class App{
        ILogger l;

        public App(ILogger l){
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
            Logger mylog = new Logger();
            (new App(mylog)).run();
        }
    }
}

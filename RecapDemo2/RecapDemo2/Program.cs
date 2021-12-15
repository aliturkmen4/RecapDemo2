using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customermanager = new CustomerManager();
            customermanager.Logger = new DatabaseLogger();
            //customermanager.Logger = new FileLogger();
            customermanager.Add();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public ILogger Logger { get; set; } //property injection
        public void Add()
        {
            //Logger logger = new Logger(); //LOG U KULLANABİLMEMİZ İÇİN!
            Logger.Log();

            Console.WriteLine("Customer added!");
        }
    }

    class DatabaseLogger:ILogger //class'ın interface i yoksa bir daha düşün çünkü new leyip kullanman lazım sürekli!!!
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }

    interface ILogger
    {
        void Log();
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to filelogger!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee(new Logger1());
           emp.AddEmployee();
        }
    }

    public interface ILogger
    {
        void WriteLog(string message);
    }

    class Logger1 : ILogger
    {

        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
        
    class Logger2 : ILogger
    {

        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class Employee
    {
        private ILogger _logger;
        public Employee(ILogger logger)
        {
            _logger = logger;
        }

        public void AddEmployee()
        {
            _logger.WriteLog("Employee added");
            Console.ReadKey();
        }

    }


}

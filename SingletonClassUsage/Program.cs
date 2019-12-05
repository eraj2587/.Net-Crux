using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonClassUsage
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = Singleton.GetSingleton();

            Parallel.For(0, 30,
                    i => {
                        a.Echo(i);
                    });
            Console.ReadKey();
        }
    }

    public class Singleton
    {
        static Singleton _instance = null;

        private Singleton()
        {

        }

        public static Singleton GetSingleton()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public void Echo(int a)
        {
            Thread.Sleep(10);
            Console.WriteLine("echo : " + a.ToString());
        }
    }
}

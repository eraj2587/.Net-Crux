using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class SimpleThread
    {
        static int m_count = 0;

        public void CallThread()
        {
            var t = Thread.CurrentThread;
            Thread t1 = new Thread(LockCall);
            Thread t2 = new Thread(LockCall);

            Console.WriteLine("Main Thread  Description \nThread ID : {0}\n Is Alive : {1}\nIsBackground : {2}" +
                                           "\nName : {3}\nPriority : {4}\n ", t.ManagedThreadId, t.IsAlive, t.IsBackground,
                                           t.Name, t.Priority);
            Console.WriteLine("Thread 1 Description \nThread ID {0}\n Is Alive : {1}\nIsBackground : {2}" +
                                            "\nName :{3}\nPriority : {4}\n ", t1.ManagedThreadId, t1.IsAlive, t1.IsBackground,
                                            t1.Name, t1.Priority);
            Console.WriteLine("Thread 2 Description \nThread ID {0}\n Is Alive : {1}\nIsBackground : {2}" +
                                            "\nName : {3}\nPriority : {4}\n ", t2.ManagedThreadId, t2.IsAlive, t2.IsBackground,
                                            t2.Name, t2.Priority);


            t1.Start();
            t2.Start();
           
            
            //Thread.CurrentThread.Join();
            Console.WriteLine("Count is : "+ m_count);
            Console.ReadKey();
        }

        void LockCall()
        {
            /*
            lock (this) //After lock thread would be in sequencial manner.. thread 1 first and then thread 2
            {
                for (int i = 0; i < 100; i++)
                {
                    m_count++;
                    Console.WriteLine("Count is : " + m_count + " Thread : " + Thread.CurrentThread.ManagedThreadId);
                }
            }
            */

            Monitor.Enter(this); //Lock keyword is just a shot-form of Monitor. So usage of monitor class or lock is one and same

            try
                {
                    for (int i = 0; i < 100; i++)
                    {
                        m_count++;
                        Console.WriteLine("Count is : " + m_count + " Thread : " + Thread.CurrentThread.ManagedThreadId);
                    }
                }
                finally 
                {

                    Monitor.Exit(this);
                }
                
            }
            

        }
    }


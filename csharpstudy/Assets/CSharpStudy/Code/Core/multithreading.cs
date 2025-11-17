using System.Threading;
using System;

namespace CSharpStudy.Code.Core
{
    public class MultiThreading
    {
        /* thread - An execution of a program
         *        - Can use multiple threads to perform different tasks concurrently
         *        - Current running thread in "main" thread
         */
        static void Multithreading(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine("Main thread Name: {0}", mainThread.Name);
        
            Thread thread1 = new Thread(() =>CountDown("Timer #1"));
            Thread thread2 = new Thread(()=>CountUp("Timer #2"));

            thread1.Start();
            thread2.Start();
        
            // Console.WriteLine("Main thread: " + mainThread.Name + " is finished");
        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #1 has finished.");
        
            Console.ReadKey();
        }
    
        public static void CountUp(String name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 has finished.");
        }
    } 
}


using System;

namespace Lab20
{
    class Program
    {
        delegate double LogDelegate(double num);
        static void Main(string[] args)
        {
            LogDelegate logDelegate = Task.Length;            
            logDelegate += Task.Square;
            logDelegate += Task.Volume;
            logDelegate(2.5);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Pass by Value
            int val = 3; //This can not change outside this method
            Console.WriteLine("Pass By Value");
            Console.WriteLine("BEFORE: val = {0}", val);
            PassBy.Square(val);
            Console.WriteLine("AFTER: val = {0}", val);

            //2. Pass By Reference
            
            //2.1 ref keyword
            int valRef = 4;
            Console.WriteLine("Pass By Reference(ref)");
            Console.WriteLine("BEFORE: valRef = {0}", valRef);
            PassBy.SquareRef(ref valRef);
            Console.WriteLine("AFTER: valRef = {0}", valRef);

            //2.2 out keyword
            int valOut = 5;
            Console.WriteLine("Pass By Reference(out)");
            Console.WriteLine("BEFORE: valOut = {0}", valOut);
            PassBy.SquareOut(out valOut);
            Console.WriteLine("AFTER: valOut = {0}", valOut);

            //2.3 in keyword
            int valIn = 7;
            Console.WriteLine("Pass By Reference(in)");
            Console.WriteLine("BEFORE: valIn = {0}", valIn);
            PassBy.SquareIn(in valIn);
            Console.WriteLine("AFTER: valIn = {0}", valIn);


            Console.ReadKey();
        }

    }
}

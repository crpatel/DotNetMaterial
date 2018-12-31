using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    class PassBy
    {
        public static void Square(int val)
        {
            val *= val;
            Console.WriteLine("INSIDE Square: val = {0}", val);

        }

        public static void SquareRef(ref int valRef)
        {
            valRef *= valRef;
            Console.WriteLine("INSIDE SquareRef: valRef = {0}", valRef);

        }

        public static void SquareOut(out int valOut)
        {
            valOut = 6;
            valOut *= valOut;
            Console.WriteLine("INSIDE SquareOut: valOut = {0}", valOut);

        }

        public static void SquareIn(in int valIn)
        {
            //uncomment following statement to see err: CS8331
            //valIn = 8;
            Console.WriteLine("INSIDE SquareIn: valIn = {0}", valIn);
        }
    }

}

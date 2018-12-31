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
            ////Value Type Variables
            ////1. Pass by Value
            //int val = 3; //This can not change outside this method
            //Console.WriteLine("Pass By Value");
            //Console.WriteLine("BEFORE: val = {0}", val);
            //PassBy.Square(val);
            //Console.WriteLine("AFTER: val = {0}", val);

            ////2. Pass By Reference

            ////2.1 ref keyword
            //int valRef = 4;
            //Console.WriteLine("Pass By Reference(ref)");
            //Console.WriteLine("BEFORE: valRef = {0}", valRef);
            //PassBy.SquareRef(ref valRef);
            //Console.WriteLine("AFTER: valRef = {0}", valRef);

            ////2.2 out keyword
            //int valOut = 5;
            //Console.WriteLine("Pass By Reference(out)");
            //Console.WriteLine("BEFORE: valOut = {0}", valOut);
            //PassBy.SquareOut(out valOut);
            //Console.WriteLine("AFTER: valOut = {0}", valOut);

            ////2.3 in keyword
            //int valIn = 7;
            //Console.WriteLine("Pass By Reference(in)");
            //Console.WriteLine("BEFORE: valIn = {0}", valIn);
            //PassBy.SquareIn(in valIn);
            //Console.WriteLine("AFTER: valIn = {0}", valIn);

            ////Reference Type Variable
            ////Pass By Value
            //int[] arrVal = new int[] { 1, 2, 3 };
            //Console.WriteLine("BEFORE: arr[0]= {0}", arrVal[0]);
            //PassBy.changeVal(arrVal);
            //Console.WriteLine("AFTER: arr[0]= {0}", arrVal[0]);

            ////Pass By Reference
            //int[] arrRef = new int[] { 4, 5, 6 };

            //Console.WriteLine("BEFORE: arrRef[0]= {0}", arrRef[0]);
            //PassBy.changeRef(ref arrRef);
            //Console.WriteLine("AFTER: arrRef[0]= {0}", arrRef[0]);


            //Constructor
            Constructor a = new Constructor();
            Console.WriteLine(a.IsInitialized);

            //Private Constructor
            //If we uncomment below line it will raise an Error
            //PrivateConstructor p = new PrivateConstructor();
            PrivateConstructor.currentCounter = 100;
            PrivateConstructor.IncrementCounter();
            Console.WriteLine("Counter is: {0}", PrivateConstructor.currentCounter);

            //struct constructor
            Square s = new Square();
            s.x = 4;
            Console.WriteLine("Width is: {0}", s.x);

            //Constructor with parameter
            ConstructorWithParameter parameter = new ConstructorWithParameter(33);
            Console.WriteLine(ConstructorWithParameter.p1);
            ConstructorWithParameter parameter2 = new ConstructorWithParameter(2, 4);
            Console.WriteLine(ConstructorWithParameter.p1 + " " + ConstructorWithParameter.p2);

            //use of base keyword
            SubConstructor sub = new SubConstructor(44);
            Console.WriteLine("Status is: {0} and value is {1}", sub.IsInitialized, sub.v1 );
            Console.ReadKey();
        }

    }
}

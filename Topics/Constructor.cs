using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topics
{
    public class Constructor
    {
        public bool IsInitialized;
        public Constructor()
        {
            IsInitialized = true;
        }
    }
    public class SubConstructor : Constructor
    {
        public int v1;
        public int v2;
        public SubConstructor(int a, int b)
        {
            v1 = a;
            v2 = b;
        }
        public SubConstructor(int a) //: base()
        {
            v1 = a;
        }
    }
    public class PrivateConstructor
    {
        PrivateConstructor() { }
        public static int currentCounter;
        public static int IncrementCounter()
        {
            return ++currentCounter;
        }
    }
    public struct Square
    {
        public int x;
    }
    public class ConstructorWithParameter
    {
        public static int p1;
        public static int p2;
        public ConstructorWithParameter(int a)
        {
            p1 = a;
        }
        public ConstructorWithParameter(int a, int b) : this(a)
        {
            //p1 = a;
            p2 = b;
        }
    }
    public class Employee
    {
        public  int fullSalary;
        public  int basicSalary;
        public Employee(int sal)
        {
            basicSalary = sal;
        }
    }
    public class Manager : Employee
    {
        static int incentives = 10;
        public Manager(int sal):base(sal)
        {
            fullSalary = basicSalary + (basicSalary*incentives) / 100;     
        }
        
    }
    public class Clerk : Employee
    {
        static int incentives = 5;
        public Clerk(int sal):base(sal)
        {
            fullSalary = basicSalary + (basicSalary * incentives) / 100;
        }
    }

}

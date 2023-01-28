using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee Emp1 = new Employee("Vid",21,22000);
            Emp1.Cal();
            Console.WriteLine(Emp1);

        
            Employee1 Emp2 = new Employee1("Vive",22,22000);
            Emp2.Cal();
            Console.WriteLine(Emp2);

            Interface1 Emp3 = new Customor();
            Emp3.Print();
            Console.WriteLine(Emp3.Print());

            Interface2 Emp4 = new Customor();
            Emp3.Print();
            Console.WriteLine(Emp4.Print());



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public interface Interface1
    {
        string Print();
    }

    public interface Interface2
    {
        string Print();
    }


    public class Customor : Interface1, Interface2 // explicit interface
    {
        string Interface1.Print()
        {
            return "Customer Details : 1";
        }

        string Interface2.Print()
        {
            return "Customer Details : 2";
        }
    }



}

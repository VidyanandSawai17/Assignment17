using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment17
{
    public  class Employee
    {


        protected int id;
        protected string name;
        protected int age;
        protected double salary, increment,gross;
        private static int count;
        public Employee(string name, int age, double salary)
        {
            id = count;
            count++;

            this.name = name;
            this.age = age;
            this.salary = salary;
       

        }

        public virtual void Cal()
        {
            increment = salary * 0.5;
            gross = salary + increment;

        }
        public override string ToString()
        {
            return $"\n Emp Id : {id} \n Emp Name : {name} \n Emp Age : {age} \n Emp Salary : {salary} \n Emp Gross Salary : {gross}";
        }

    }

    public class Employee1:Employee
    {
        
        private double bonus;

        public Employee1(string name, int age, double salary) : base(name, age, salary)
        {

            this.name = name;
            this.age = age;
            this.salary = salary;

        }

        public override void Cal()
        {
          
            bonus = salary * 0.5 ;
            gross = salary + bonus;
    


        }

        public override string ToString()
        {
            return $"\n Emp Id : {id} \n Emp Name : {name} \n Emp Age : {age} \n Emp Salary : {salary} \n Emp Gross Salary : {gross}";
        }




    }

}

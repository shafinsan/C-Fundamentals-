using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp_All_In_One
{

    enum Day
    {
        a=0, b=1, c=2, d=3, e=4, f=5, g=6, h=7
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> students = new List<Animal>();
            students.Add(new Student("Elias",25,3.16));
            students.Add(new Student("Jaber", 26, 4.16));
            students.Add(new Student("Shafin", 27, 5.16));
            foreach(Animal s in students)
            {
                Console.WriteLine($"*************Day-{(int)Day.a}-**************");
                Console.WriteLine($"*************{Animal.number}**************");
                s.Display();
                s.Virtual();
                
                if(s is IDetails details)
                {
                    details.Details();
                }
                
                Console.WriteLine("***************************");
            }
        }
    }
    interface IDetails
    {
       void Details();
    }
    abstract class Animal
    {
        public static int number=0;
        protected string name;
        protected int age;
        protected double cgpa;
        public Animal(string name,int age,double cgpa)
        {
            this.name = name;
            this.age = age;
            this.cgpa = cgpa;
            number++;
        }

        public abstract void Display();
        public virtual void Virtual()
        {
            Console.WriteLine("This is my Animal virtual function");
        }
    }
    class Student : Animal, IDetails 
    {
        public Student(string name,int age,double cgpa) : base(name,age, cgpa)
        {

        }
        public override void Display()
        {
            Console.WriteLine($"Name of the student is :{this.name}");
            Console.WriteLine($"Age of the student :{this.age}"); 
            Console.WriteLine($"Cgpa of the student :{this.cgpa}");
        }
        public void Details()
        {
            Console.WriteLine("This function use for only interface");
        }
    }
}

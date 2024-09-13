using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Get_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Elias", 25, 5));
            students.Add(new Student("Jaber", 25, 5));
            students.Add(new Student("Shafin", 25, 5));

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                students[i].Cgpa = random.NextDouble() * 4.01;
            }
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }


        }
    }
    class Student
    {
        string name;
        int age;
        double cgpa;
        public Student(string name, int age, double cgpa)
        {
            this.name = name;
            this.age = age;
            this.cgpa = cgpa;
        }
        public double Cgpa
        {
            get
            {
                return cgpa;
            }
            set
            {
                if (value >= 4.01)
                {
                    cgpa = 4.00;
                }
                else
                {
                    cgpa = value;
                }
            }
        }
        public override string ToString()
        {
            return $"Name is {name} and age is {age} cpga is {this.cgpa}";
        }
    }
}

using CopyConstructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Copy
    {
        public int Age;
        public string Name;
    
    public Copy(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public Copy(Copy prevperson)
        {
            Name = prevperson.Name;
            Age = prevperson.Age;
        }
        public String Details()
        {
            return Name + "  is   " + Age.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        Copy obj = new Copy(24, "chinna");
        Copy obj2 = new Copy(obj);
        obj.Age = 25;
        obj2.Age = 42;
        obj2.Name = "ABHI";
        Console.WriteLine(obj.Details());
        Console.WriteLine(obj2.Details());
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();


            student sobj = new student(1, "deekshitha");
            sobj.studentDisplay();
            student s1 = new student(2, "siri");
            s1.studentDisplay();
            student.studentcollege();
        }
    }
}

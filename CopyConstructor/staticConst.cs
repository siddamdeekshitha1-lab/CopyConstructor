using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{

    class student
    {
        public int sid;
        public string sname;
        static string college;

        public student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
        }
        static student()
        {
            college = "vasavi";
        }
        public void studentDisplay()
        {
            Console.WriteLine("student id is:" + sid);
            Console.WriteLine("student name is :" + sname);
        }
        public static void studentcollege()
        {
            Console.WriteLine("college name is:" + college);
        }
    }
    internal class staticConst
    {

    }
}

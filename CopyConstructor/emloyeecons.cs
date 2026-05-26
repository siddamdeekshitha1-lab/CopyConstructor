using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class employee
    {
        public int empid;
        public string empname;
        public double empsal;
        static string empcompany;

        public employee(int empid, string empname, double empsal)
        {
            this.empid = empid;
            this.empname = empname;
            this.empsal = empsal;
        }
         static employee()
        {
            empcompany = "Infosys";
        }

        public void employeeDisplay()
        {
            Console.WriteLine("employee id is:" + empid);
            Console.WriteLine("employee name is:" + empname);
            Console.WriteLine("employee salary is :" + empsal);
        
        }
        public static void companyDisplay()
        {
            Console.WriteLine("employee company is:" + empcompany);

        }
        public void hike()
        {
            double hike;
            double totsal;
            hike = empsal * 0.10;
            totsal = empsal + hike;
            Console.WriteLine("employee hikesal is:" + hike);
            Console.WriteLine("employee after hike totalsal:" + totsal);

        }
    }
    internal class emloyeecons
    {
    }
}

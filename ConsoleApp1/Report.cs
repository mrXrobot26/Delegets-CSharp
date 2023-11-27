using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegetsIEEE
{
    public class Report
    {
        // as data type
        public delegate bool illegibleDelegate(Employee e);

        public void EmployeeProcess(List<Employee> employee, string status, illegibleDelegate illegible)
        {
            Console.WriteLine(status);
            Console.WriteLine("===================================");

            foreach (Employee emp in employee)
            {
                if (illegible(emp))
                {
                    Console.WriteLine(emp.Name + " " + emp.TotalSale);
                }

            }
        }






        //public void EmployeeProcessBigThanOrEqual60000(List<Employee> employee)
        //{
        //    Console.WriteLine("Total sales big than 60000");
        //    Console.WriteLine("===================================");
     
        //    foreach (Employee emp in employee)
        //    {
        //        if (emp.TotalSale>=60000)
        //        {
        //            Console.WriteLine(emp.Name + " " + emp.TotalSale);
        //        }

        //    }
        //}
        //public void EmployeeProcessBigThan30000AndLessThan60000(List<Employee> employee)
        //{
        //    Console.WriteLine("Total sales big than 30000 less than 30000");
        //    Console.WriteLine("===================================");
        //    foreach (Employee emp in employee)
        //    {
        //        if (emp.TotalSale > 30000 && emp.TotalSale<60000)
        //        {
        //            Console.WriteLine(emp.Name +" "+ emp.TotalSale );
        //        }
        //    }

        //}

        //public void EmployeeProcessLessThan30000(List<Employee> employee)
        //{
        //    Console.WriteLine("Total sales big than 30000 less than 30000");
        //    Console.WriteLine("===================================");
        //    foreach (Employee emp in employee)
        //    {
        //        if (emp.TotalSale < 30000 )
        //        {
        //            Console.WriteLine(emp.Name + " " + emp.TotalSale);
        //        }
        //    }
        //}


    }
}

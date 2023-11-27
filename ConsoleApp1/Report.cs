using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Report
    {
        public void EmployeeProcessBigThanOrEqual60000(List<Employee> employee)
        {
            Console.WriteLine("Total sales big than 60000");
            Console.WriteLine("===================================");
     
            foreach (Employee emp in employee)
            {
                if (emp.TotalSale>=60000)
                {
                    Console.WriteLine(emp.Name + " " + emp.TotalSale);
                }

            }
        }
        public void EmployeeProcessBigThan30000AndLessThan60000(List<Employee> employee)
        {
            Console.WriteLine("Total sales big than 30000 less than 30000");
            Console.WriteLine("===================================");
            foreach (Employee emp in employee)
            {
                if (emp.TotalSale > 30000 && emp.TotalSale<60000)
                {
                    Console.WriteLine(emp.Name +" "+ emp.TotalSale );
                }
            }

        }

        public void EmployeeProcessLessThan30000(List<Employee> employee)
        {
            Console.WriteLine("Total sales big than 30000 less than 30000");
            Console.WriteLine("===================================");
            foreach (Employee emp in employee)
            {
                if (emp.TotalSale < 30000 )
                {
                    Console.WriteLine(emp.Name + " " + emp.TotalSale);
                }
            }
        }


    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var EmpLst = new List<Employee>
            {
                new Employee() {Id=1, Name ="Ahmed" , gender="m" , TotalSale =65000m },
                new Employee() {Id=2, Name ="Mohamed" , gender="m" , TotalSale =60900m },
                new Employee() { Id = 3, Name = "Sophia", gender = "f", TotalSale = 58000m },
                new Employee() { Id = 4, Name = "Oliver", gender = "m", TotalSale = 6300m },
                new Employee() { Id = 5, Name = "Emma", gender = "f", TotalSale = 51000m },
                new Employee() { Id = 6, Name = "William", gender = "m", TotalSale = 5900m },
                new Employee() { Id = 7, Name = "Ava", gender = "f", TotalSale = 55000m },
                new Employee() { Id = 8, Name = "James", gender = "m", TotalSale = 64000m },
                new Employee() { Id = 9, Name = "Mia", gender = "f", TotalSale = 52000m },
                new Employee() { Id = 10, Name = "jone", gender = "m", TotalSale = 35000m },
                new Employee() { Id = 11, Name = "Lofy", gender = "m", TotalSale = 8000m },
                new Employee() { Id = 12, Name = "Amr", gender = "m", TotalSale = 11100m },
            };


            var report = new Report();
            report.EmployeeProcessBigThanOrEqual60000(EmpLst);
            report.EmployeeProcessBigThan30000AndLessThan60000(EmpLst);
            report.EmployeeProcessLessThan30000(EmpLst);



        }
    }
}

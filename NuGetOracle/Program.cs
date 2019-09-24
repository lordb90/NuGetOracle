using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetOracle
{
    internal class Program
    {
        /// <summary>
        /// Need to have oracle installed
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());

            using (var ctx = new OracleDbContext())
            {
                var emp = new Employee
                {
                    Name = "Tom",
                    HireDate = DateTime.Now
                };

                ctx.Employees.Add(emp);
                ctx.SaveChanges();

                var dept = new Department
                {
                    Name = "Accounting",
                    ManagerId = emp.EmployeeId
                };

                ctx.Departments.Add(dept);
                ctx.SaveChanges();
            }

            Console.Write("Press any key to continue... ");
            Console.ReadLine();
        }
    }
}
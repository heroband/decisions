using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab9
{
    public class SalaryReportVisitor : IVisitor
    {
        public void VisitCompany(Company company)
        {
            Console.WriteLine($"Salary report for company: {company.Name}");
        }

        public void VisitDepartment(Department department)
        {
            Console.WriteLine($"\nSalary report for department: {department.Name}");
            foreach (var employee in department.Employees)
            {
                Console.WriteLine($"Employee position: {employee.Position}, Salary: {employee.Salary}");
            }
        }
    }
}
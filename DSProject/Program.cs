using DSAlgorithems.Models;
using System;

namespace DSAlgorithems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Kolenski", "Egor", 25);
            Employee employee2 = new Employee(2, "Laor", "Matan", 23);
            Employee employee3 = new Employee(3, "David", "Gaya", 20);
            Employee employee4 = new Employee(4, "Yahav", "Efrat", 20);

            Employee[] employees = new Employee[] { employee1, employee2, employee3, employee4 };

            Table table = new Table(employees);

            //Here we can search by ID
            Index indexById = new Index(table);
            indexById.GetByID(1);


            //Here we can search by last name:
            NonUniqueIndex nonUnique = new NonUniqueIndex(table);
            var employeesEnumerator = nonUnique.GetByLN("La");
            while (employeesEnumerator.MoveNext())
            {
                Employee employee = employeesEnumerator.Current;
                Console.WriteLine(employee.FirstName + " " + employee
                    .LastName);
            }

            //Range Index:
            RangeIndex rangeById = new RangeIndex(table);
            Employee[] resultByAge = rangeById.GetByRangeAge(20, 26);
            foreach (Employee employee in resultByAge)
            {
                if (employee != null)
                {
                    Console.WriteLine(employee);
                }
            }


        }
    }
}

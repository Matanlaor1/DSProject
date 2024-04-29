using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithems.Models
{
    internal class NonUniqueIndex
    {
        private Dictionary<string, Employee> employees = new Dictionary<string,Employee>();
        Table employeesTable { get; set; }

        public NonUniqueIndex(Table employeesTable)
        {
            this.employeesTable = employeesTable;
            foreach (var employee in employeesTable.Employees)
            {
                employees.Add(employee.LastName,employee);
            }
        }

        public IEnumerator<Employee> GetByLN(string lastName)
        {
            foreach (Employee employee in employeesTable.Employees)
            {
                if (employee != null && employee.LastName.Contains(lastName))
                {
                    yield return employee;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var e  in employees) {  stringBuilder.Append(e.ToString()); }
            return stringBuilder.ToString();
        }
    }
}

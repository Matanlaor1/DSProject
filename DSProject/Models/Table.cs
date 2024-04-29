using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithems.Models
{
    internal class Table : IEnumerable<Employee>
    {
        public Table(Employee[] employees)
        {
            Employees = employees;
        }
     
        public Employee[] Employees {  get; set; }

        public IEnumerator<Employee> GetEnumerator()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                yield return Employees[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

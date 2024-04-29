using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithems.Models
{
    internal class Index
    {
        private Table _table;

        Dictionary<int, Employee> employeesID = new Dictionary<int, Employee>();


        public Index(Table table)
        {
            _table = table;
             foreach (Employee employee in _table)
            {
                employeesID.Add(employee.Id, employee);
            }
        }

        public Employee GetByID(int id)
        {
            return employeesID[id];
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var employee in employeesID)
            {
                sb.Append(employee.ToString());
            }
            return base.ToString();
        }

    }
}

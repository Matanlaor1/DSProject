using System.Linq;

namespace DSAlgorithems.Models
{
    internal class RangeIndex
    {
        private Table _table;
        private Employee[] employees;

        public RangeIndex(Table table)
        {
            int index = 0;
            _table = table;
            employees = new Employee[table.Employees.Length];
            foreach (Employee employee in _table)
            {
                
                if (employee != null)
                {
                    employees[index++] = employee;
                }
            }
        }

        public Employee[] GetByRangeAge(int start, int end)
        {
            int index = 0;
            Employee[] result = new Employee[employees.Length];
            foreach (Employee employee in employees)
            {
                if (employee != null && employee.Age >= start && employee.Age <= end)
                {
                    result[index++] = employee;
                }
            }
            return result;
        }
    }
}

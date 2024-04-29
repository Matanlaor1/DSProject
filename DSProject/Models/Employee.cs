using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgorithems.Models
{
    internal class Employee
    {
        public Employee(int id, string lastName, string firstName, int age)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"ID:{Id}, Name:{FirstName} {LastName}, Age:{Age}";
        }
    }
}

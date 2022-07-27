using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }

        public string Address { get; set; }
        public Employee()
        {
            this.Id = 0;
            this.Name = "";
            this.Role = "";
            this.Address = "";
        }
        public Employee(int id, string name, string role, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Role = role;
            this.Address = address;

        }
        public List<Employee> GetEmployeesValues()
        {
            List<Employee> employeeList = new List<Employee>();
            var name = new List<string> { "Zaheer", "Abbas", "Nauman", "Sarfraz","Babar","Maisbah","Younis" };
            var role = new List<string> { "x", "y", "z", "Sz","b","c" };
            for (int i = 0; i < 1000; i++)
            {
                    var random = new Random(Guid.NewGuid().GetHashCode());
                    employeeList.Add(new Employee(i + 1, name[random.Next(name.Count)], role[random.Next(role.Count)], "xyz"));

            }
            return employeeList;
        }
    }
    
}

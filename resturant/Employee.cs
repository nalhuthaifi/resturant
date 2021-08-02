using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain
{
   
    public class Employee
    {
       
        public int Id { get; set; }
        public string firstName { get; set; }
        public int Salary { get; set; }
        public string lastName { get; set; }
        public string JobTitle { get; set; }


        public Employee(int id, string first, string last, int salary, string jobTitle)
        {
            Id = id;
            firstName = first;
            lastName = last;
            Salary = salary;
            JobTitle = jobTitle;
        }


    }
    
}

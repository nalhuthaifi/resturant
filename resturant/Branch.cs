using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Domain
{
   public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public Menu menu { get; set; }
        public List<Employee> Employee { get; set; } = new List<Employee>();
        public List<Order> Orders { get; set; }= new List<Order>() ;

        public Branch(int id, string name, string street, string city)
        {
            Id = id;
            Name = name;
            Street = street;
            City = city; 
        }

        public Employee addEmployee()
        {
            int count = 0;
            Console.WriteLine("Enter new employee's fisrt name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter new employees's last name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter new employee's salary: ");
            int salary = Console.Read();
            Console.WriteLine("Enter new empoyee's job title: ");
            string JobTitle = Console.ReadLine();
          
            Employee emp = new Employee(++count, FirstName, LastName, salary, JobTitle);
            Employee.Add(emp);
            return emp;
        }

        public void print()
        {
            foreach (var order in Orders)
            Console.WriteLine(order.ToString());
        }
  
       
    }
}

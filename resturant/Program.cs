using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain
{
    class Program
    {

        public static void Main(String[] args)
        {
            using (var context = new RestaurantContext())
            {
                Branch u = context.Branch.Find(1);
            }
            Branch branch = null;
            // var context = new RestaurantContex();
            int counter = 1;
            

            do
            {
                Console.WriteLine("====================================== Welcome ======================================");
                Console.WriteLine(" Enter 1 to create a new branch, 2 to edit an existing branch, and 00 to exit system");


                var userchoice = Console.ReadLine();
                int action;
                if (Int32.TryParse(userchoice, out action))
                {

                    switch (action)
                    {

                        case (int)Action.Create:
                            string name;
                            Console.WriteLine("Enter new branch's name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter new branch's city: ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter new branch's street: ");
                            string street = Console.ReadLine();
                            branch = new Branch(counter, name, city, street, counter);
                            break;

                        case (int)Action.Edit:
                            Console.WriteLine("enter the branch id: ");
                            string branchId = Console.ReadLine();
                            int SelectedBranch;
                            if (Int32.TryParse(branchId, out SelectedBranch))
                            {
                                branch = DbSet.Add(null);
                                Console.WriteLine("Select action:");
                                Console.WriteLine("1- add employee");
                                Console.WriteLine("2- edit employee's info");
                                Console.WriteLine("3- add dish to a menu");
                                Console.WriteLine("4- print orders report");
                                branch = null;
                            }
                            // Dbset.add()
                            break;

                        case (int)Action.exit:
                            Console.WriteLine("you chose to exit system ");
                            Console.WriteLine("to confirm your choice enter 0 again" +
                                ", otherwise press any key ");
                            break;

                    }
                    Console.WriteLine("-");

                }
                else
                {
                    Console.WriteLine("Wrong choice");
                    continue;
                }
            } while (Console.ReadKey().KeyChar != '0');


        }

        public enum Action
        {
            Create = 1,
            Edit = 2,
            exit = 0
        };

    }
}

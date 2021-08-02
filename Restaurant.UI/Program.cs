using Restaurant.Data;
using Restaurant.Domain;
using System;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.UI
{
    class Program
    {
        public static void Main(String[] args)
        {
            
            Branch branch = null;

            int counter = 1;
            var context = new RestaurantContext();
            int limit=0;
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
                            branch = new Branch(counter, name, city, street);
                            context.Branches.Add(branch);
                        break;

                        case (int)Action.Edit:
                           
                            int SelectedBranch;

                            do
                            {
                                if (limit == 0)
                                {
                                    Console.WriteLine("enter the branch id: ");
                                }
                                else { Console.WriteLine( "wrong Id, enter a valid branch id again"); }
                                string branchId = Console.ReadLine();

                                if (Int32.TryParse(branchId, out SelectedBranch))
                                {
                                    branch = context.Branches.Find(SelectedBranch);
                                    if (branch == null)
                                    {
                                        limit++;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    limit++;
                                }
                            } while (limit < 3);





                            if (branch != null)
                            {

                                Console.WriteLine("Select action:");
                                Console.WriteLine("1- add employee.");
                                Console.WriteLine("2- add dish to a menu.");
                                Console.WriteLine("3- print orders report.");




                                userchoice = Console.ReadLine();

                                if (Int32.TryParse(userchoice, out action))
                                {

                                    if (action > 0 && action < 4)
                                    {

                                        switch (action)
                                        {

                                            case (int)InnerAction.Employee:
                                                Employee employee= branch.addEmployee();
                                                context.Employee.Add(employee);

                                                break;

                                            case (int)InnerAction.Dish:
                                                Dish dish = branch.menu.addDish();
                                                context.Dishes.Add(dish);

                                                break;

                                            case (int)InnerAction.Report:

                                                branch.print();

                                                break;

                                        }
                                    } else { Console.WriteLine("Enter a valid choice"); }

                                }
                                else { Console.WriteLine("Enter a valid choice"); }

                            }
                            else {
                                Console.WriteLine("You have exceed tries limit.");
                            }

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

        public enum InnerAction
        {
            Employee = 1,
            Dish = 2,
            Report = 3
        };

    }
}

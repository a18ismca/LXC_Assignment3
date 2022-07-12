using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LXC_Assignment3;

namespace LXC_Assignment3
{
    public class VendingMachine : IVending
    {
        List<Product> products = new List<Product>();

        int userCash = 0;

        bool running = true;

        private readonly int[] cash = { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };

        public List<Product> CreateList()
        {
            // Drinks

            products.Add(new Drink { ID = 1, Name = "Fanta Exotic", Price = 11, Sugar = 8, Size = 500, Kolhydrater = 9 });
            products.Add(new Drink { ID = 2, Name = "Cockta Light", Price = 9, Sugar = 2, Size = 500, Kolhydrater = 0 });
            products.Add(new Drink { ID = 3, Name = "Sinalco Cola", Price = 7, Sugar = 13, Size = 330, Kolhydrater = 12 });
            products.Add(new Drink { ID = 4, Name = "Pepsi", Price = 12, Sugar = 16, Size = 500, Kolhydrater = 16 });

            // Meals

            products.Add(new Food { ID = 5, Name = "Korv Stroganoff", Price = 43, Size = 350, Sugar = 17, Kcal = 180 });
            products.Add(new Food { ID = 6, Name = "Burek sa sirom", Price = 10, Size = 300, Sugar = 5, Kcal = 220 });
            products.Add(new Food { ID = 7, Name = "Wienerschnitzel", Price = 99, Size = 550, Sugar = 11, Kcal = 190 });
            products.Add(new Food { ID = 8, Name = "Potatiskroketter", Price = 22, Size = 250, Sugar = 8, Kcal = 165 });

            // Snacks

            products.Add(new Snack { ID = 9, Name = "Smoki", Price = 9, Size = 150, Sugar = 18, Protein = 5 });
            products.Add(new Snack { ID = 10, Name = "OLW Ranch", Price = 17, Size = 275, Sugar = 16, Protein = 3 });
            products.Add(new Snack { ID = 11, Name = "Lindt Bar Orange", Price = 7, Size = 65, Sugar = 23, Protein = 2 });
            products.Add(new Snack { ID = 12, Name = "Haribo Happy Cola", Price = 13, Size = 225, Sugar = 26, Protein = 1 });

            return products.ToList();

        }

        public bool EndTransaction(int amount)
        {
            Console.WriteLine("Here is your cashback. Have a nice day!");
            for (int i = 0; i < cash.Length; i++)
            {

                if (amount >= cash[i])
                {

                    int coinDistribution = (int)amount / cash[i];

                    amount %= (int)cash[i];

                    // change =- coinArray[i];

                    Console.WriteLine(cash[i] + " coins: " + coinDistribution);

                }



            }

            return false;
        }

        public void Menu()
        {
            
            Console.WriteLine("Insert money. The following amounts can be inserted (in kunas): 1000, 500, 200, 100, 50, 20, 10, 5, 1.");
            Console.WriteLine("When money has been inserted, enter 0000 and then press ENTER in order to select a product. ");
            Console.WriteLine("Bank: " + userCash + "kn.");
            try
            {
                int amount = int.Parse(Console.ReadLine());

                if (amount == 0000)
                {
                    Console.Clear();
                    SelectProduct();
                } 

                else if (cash.Contains(amount))
                {
                    InsertMoney(amount);
                    Menu();
                    
                }

                else
                {
                    Console.Clear();
                   
                    Console.WriteLine("The amount of entered cash is not valid.");
                    Menu();

                    
                    
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Please enter integers instead of letters");
                Menu();
            }
        }

        public void InsertMoney(int amount)
        {
            Console.Clear();
            userCash += amount;
            Console.WriteLine("{0} kunas added. ", amount);
        }

        public void Purchase(int amount, int index)
        {
            userCash -= amount;
            products[index].Use();
            Console.WriteLine("Purchase successful! Cash left: " + userCash);
            Console.WriteLine("Press any key and then ENTER to continue. ");
            Console.Read();
            SelectProduct();
        }

        public void SelectProduct()
        {
             
            ShowAll(products);
            Console.WriteLine("Select product by entering its ID and then pressing ENTER.\nEnter 0000 in order to withdraw more money. \nCash left: " + userCash + "\nInput 13 in order to leave VM");
            try
            {
                int input = int.Parse(Console.ReadLine());


                
                    switch (input)
                    {
                        case 1:
                            AskUserAboutDecision(0);
                            break;
                        case 2:
                            AskUserAboutDecision(1);
                            break;
                        case 3:
                            AskUserAboutDecision(2);
                            break;
                        case 4:
                            AskUserAboutDecision(3);
                            break;
                        case 5:
                            AskUserAboutDecision(4);
                            break;
                        case 6:
                            AskUserAboutDecision(5);
                            break;
                        case 7:
                            AskUserAboutDecision(6);
                            break;
                        case 8:
                            AskUserAboutDecision(7);
                            break;
                        case 9:
                            AskUserAboutDecision(8);
                            break;
                        case 10:
                            AskUserAboutDecision(9);
                            break;
                        case 11:
                            AskUserAboutDecision(10);
                            break;
                        case 12:
                            AskUserAboutDecision(11);
                            break;
                        case 13:
                            EndTransaction(userCash);
                            break;
                        case 0000:
                            Console.Clear();
                            Menu();
                            break;
                        default:
                        Console.Clear();
                        SelectProduct();
                        break;
                    
            
              
                
                   
                }
                }
            
            catch {
                Console.Clear();
                SelectProduct();
            }
            
        }
 
        public void AskUserAboutDecision(int index)
        {
            Console.Clear();
            if (userCash > products[index].Price)
            {
                products[index].AskForConfirmation();

                int decision = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                if (decision == 1)
                {
                    Console.Clear();
                    Purchase(products[index].Price, index);
                }
                else
                {
                    Console.Clear();
                    SelectProduct();
                }
            }
            else
            {
                Console.WriteLine("You dont have enough money!! Return to the bankomat.");
                SelectProduct();
            }
        }

        public void ShowAll(List<Product> prod)
        {
           foreach(var p in prod)
            {
                p.ShowGeneralInfo();
            }
        }


    }
}

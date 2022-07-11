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
        bool cashInserted = false;
        private readonly int[] cash = { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };

        public void EndTransaction()
        {

        }

        public void Menu()
        {
            while (!cashInserted)
            {
                Console.WriteLine("Insert money. The following amounts can be inserted: 1000, 500, 200, 100, 50, 20, 10, 5, 1.");

                int amount = int.Parse(Console.ReadLine());

                if(amount == 0000)
                {
                    cashInserted = true;
                    
                }
                if (cash.Contains(amount))
                {
                    InsertMoney(amount);

                }
                else
                {
                    Console.WriteLine("The amount of entered cash is not valid.");
                }
                
               
                Console.WriteLine("Press 0000 to move on to next step. ");
            }
        }

        public void InsertMoney(int amount)
        {
            userCash += amount;
            Console.WriteLine("{0} added. Total cash: {1}", amount, userCash);
        }

        public void Purchase(int amount)
        {
            userCash -= amount;
        }
 
        public void ShowAll()
        {

        }


    }
}

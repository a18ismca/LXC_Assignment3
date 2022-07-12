// See https://aka.ms/new-console-template for more information
using LXC_Assignment3;
namespace LXC_Assignment3
{
    public class Food : Product
    {
        public int Kcal { get; set; }
        public override void AskForConfirmation()
        {
            Console.WriteLine(Name + " contains " + Size + "g of great food with a price of " + Price + "The meal has an amount of " + Kcal + "kcal per 100g. ");
            Console.WriteLine("Are you sure you want to proceed buying this product? (Y/N)");
        }

        public override void ShowGeneralInfo()
        {
            Console.WriteLine("(ID: " + ID + ") " + Name + " " + Size + "g, " + Price + "kn. ");
        }

        public override void Use()
        {
            Console.WriteLine("Look for the fork and the knife that is included with " + Name + ". Take of the plastic sealer and enjoy the meal!");
        }
    }
}
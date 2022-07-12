// See https://aka.ms/new-console-template for more information
using LXC_Assignment3;
namespace LXC_Assignment3
{
    public class Snack : Product
    {
       public int Protein { get; set; }

        public override void AskForConfirmation()
        {
            Console.WriteLine(Name + " contains " + Size + "g of delicious thing with a price of " + Price + " kn. The snack also includes " + Protein + " grams of protein per 100g. ");
            Console.WriteLine("Are you sure you want to proceed buying this product? If yes, press 1. If no, press another key.");
        }

        public override void ShowGeneralInfo()
        {
            Console.WriteLine("(ID: " + ID + ") " + Name + " " + Size + "g, " + Price + "kn. "); 
        }

        public override void Use()
        {
            Console.WriteLine("Open the snack with your hands and eat it!");
        }
    }
}
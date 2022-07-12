// See https://aka.ms/new-console-template for more information
using LXC_Assignment3;

namespace LXC_Assignment3
{
    public class Drink : Product
    {
        public int Kolhydrater { get; set; }
        public override void AskForConfirmation()
        {
            Console.WriteLine(Name + " contains " + Size + "ml of a refreshing, svalkande drink with a price of " + Price + "kn. The drink also has " + Kolhydrater + " grams of carbs per 100g. ");
            Console.WriteLine("Are you sure you want to proceed buying this product? If yes, press 1. If no, press another key.");
        }

        public override void ShowGeneralInfo()
        {
            Console.WriteLine("(ID: " + ID + ") " + Name + " " + Size + "ml, " + Price + "kn. "); 
        }

        public override void Use()
        {
            Console.WriteLine("Look for the kork/öppnare and open there. Drink " + Name + " ice cold.");
        }
    }
}
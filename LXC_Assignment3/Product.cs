using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXC_Assignment3
{
    public class Product
    {
        public string Name { get; set; }

        public int addEventualTax;

        public int sugarPercentage;
        public double Price { get; set; }

        public int Size { get; set; }

        public int Sugar { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine(Name + " " + Size + " costs " + Price + "kn.");
        }

        public virtual void Use()
        {

        }

        public virtual void AddTaxes(double tax)
        {
            if(Sugar > 12)
            {
                tax = 1.2;
                Price *= tax;
            }
        }
      
    }
}

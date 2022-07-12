using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXC_Assignment3
{
    public abstract class Product
    {

        public int ID { get; set; }
        public string Name { get; set; }

        
        public int Size { get; set; }

        public int Sugar { get; set; }

        private double price;

        // 50% extra taxation for products with more than 15g of sugar.
        public int Price { 
            get { 
                if(Sugar > 15)
                {
                    return (int)(price * 1.5);
                }
                else
                {
                    return (int)price;
                }
            }
            set { 
                price = value; 
            }
        }
        public abstract void ShowGeneralInfo();
        
        public abstract void AskForConfirmation();

        public abstract void Use();
        

        

        
      
    }
}

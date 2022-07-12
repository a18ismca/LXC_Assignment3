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

       
        public int Price { get; set; }
        public abstract void ShowGeneralInfo();
        
        public abstract void AskForConfirmation();

        public abstract void Use();
        

        

        
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXC_Assignment3
{
    public interface IVending
    {

        public bool EndTransaction(int amount);

        public void InsertMoney(int amount);

        public int Purchase(int amount, int index);

        public void ShowAll(List<Product> prods);
    }
}

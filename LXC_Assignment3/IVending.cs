using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LXC_Assignment3
{
    public interface IVending
    {

        public void EndTransaction();

        public void InsertMoney(int amount);

        public void Purchase(int amount);

        public void ShowAll(List<Product> prods);
    }
}

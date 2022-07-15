using LXC_Assignment3;

namespace LXC_Assignment3.Test
{
    public class UnitTest1
    {
        VendingMachine vm = new VendingMachine();

        [Fact]
        public void CheckThatOnlyKunasAreUsed()
        {
            // Bills and coins in EUR
            double[] sedlarMyntInEur = {200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.01};
            
            double[] actual = vm.cash;

            Assert.NotEqual(sedlarMyntInEur, actual);
        }

        [Fact]
        public void CheckFirstDenomination()
        {
            double expected = 1;

            // vm.cash[0] = 1000
            double actual = vm.cash[0];

            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void CheckAveragePriceOfProductsInVM()
        {
            double expected = 21.583333333333332;

            vm.CreateList();

            double actual = vm.products.Average(x => x.Price);

            Assert.Equal(expected, actual);
        }

        [Fact]

        public void GetTotalPriceOfAllProducts()
        {
            double expected = 259;

            vm.CreateList();

            double actual = vm.products.Sum(x => x.Price);

            Assert.Equal(expected, actual);
        }
    }
}
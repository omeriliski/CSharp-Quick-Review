
namespace OOP
{
    public class Calculator : ICalculator
    {
        public decimal Add(decimal a, decimal b)
        {
           return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
    }
}

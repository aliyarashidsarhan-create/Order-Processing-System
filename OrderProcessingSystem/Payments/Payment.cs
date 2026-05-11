using OrderProcessingSystem.Interfaces;

namespace OrderProcessingSystem.Payments
{
    public abstract class Payment : IPayable
    {
        public abstract string Pay(decimal amount);
    }
}
namespace OrderProcessingSystem.Payments
{
    public class CashPayment : Payment
    {
        public override string Pay(decimal amount)
        {
            return $"Cash payment completed. Amount: {amount} OMR";
        }
    }
}
namespace OrderProcessingSystem.Payments
{
    public class CreditCardPayment : Payment
    {
        public override string Pay(decimal amount)
        {
            return $"Credit card payment completed. Amount: {amount} OMR";
        }
    }
}
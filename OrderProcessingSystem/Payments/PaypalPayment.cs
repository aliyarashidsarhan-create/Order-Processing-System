namespace OrderProcessingSystem.Payments
{
    public class PaypalPayment : Payment
    {
        public override string Pay(decimal amount)
        {
            return $"PayPal payment completed. Amount: {amount} OMR";
        }
    }
}
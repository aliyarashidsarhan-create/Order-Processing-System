
namespace OrderProcessingSystem.Models
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal SubTotal
        {
            get
            {
                decimal discount = Product.CalculateDiscount();
                decimal finalPrice = Product.Price - discount;
                return finalPrice * Quantity;
            }
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Product.Name} x {Quantity} = {SubTotal} OMR";
        }
    }
}
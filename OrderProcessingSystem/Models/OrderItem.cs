namespace OrderProcessingSystem.Models
{
    public class OrderItem
    {
        // Store product information
        public Product Product { get; set; }

        // Store product quantity
        public int Quantity { get; set; }

        // Calculate subtotal after discount
        public decimal SubTotal
        {
            get
            {
                // Get discount value
                decimal discount = Product.CalculateDiscount();

                // Calculate final product price
                decimal finalPrice = Product.Price - discount;

                // Return subtotal
                return finalPrice * Quantity;
            }
        }

        // Constructor
        public OrderItem(Product product, int quantity)
        {
            Product = product;

            Quantity = quantity;
        }

        // Display order item details
        public override string ToString()
        {
            return Product.Name + " x " + Quantity + " = " + SubTotal + " OMR";
        }
    }
}
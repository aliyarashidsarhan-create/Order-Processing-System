namespace OrderProcessingSystem.Models
{
    // Class represents a single item inside an order
    public class OrderItem
    {
        // Property to store product information
        public Product Product { get; set; }

        // Property to store quantity of the product
        public int Quantity { get; set; }

        // Read-only property to calculate subtotal automatically
        public decimal SubTotal
        {
            get
            {
                // Calculate discount from product
                decimal discount = Product.CalculateDiscount();

                // Calculate final price after discount
                decimal finalPrice = Product.Price - discount;

                // Return subtotal based on quantity
                return finalPrice * Quantity;
            }
        }

        // Constructor to initialize product and quantity
        public OrderItem(Product product, int quantity)
        {
            // Assign product object
            Product = product;

            // Assign quantity value
            Quantity = quantity;
        }

        // Override ToString method to display order item details
        public override string ToString()
        {
            // Return formatted product information
            return $"{Product.Name} x {Quantity} = {SubTotal} OMR";
        }
    }
}
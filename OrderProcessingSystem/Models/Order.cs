using System;
using System.Collections.Generic;
using OrderProcessingSystem.Interfaces;
using OrderProcessingSystem.Payments;

namespace OrderProcessingSystem.Models
{
    // Order class implements IShippable interface
    public class Order : IShippable
    {
        // Property to store order ID
        public int Id { get; set; }

        // Property to store customer information
        public Customer Customer { get; set; }

        // List to store all order items
        public List<OrderItem> Items { get; set; }

        // Property to store current order status
        public string Status { get; set; }

        // Property to store order creation date
        public DateTime OrderDate { get; set; }

        // Property to store selected payment method
        public Payment PaymentMethod { get; set; }

        // Constructor to initialize order data
        public Order(int id, Customer customer)
        {
            // Assign order ID
            Id = id;

            // Assign customer object
            Customer = customer;

            // Create empty list for items
            Items = new List<OrderItem>();

            // Set default order status
            Status = OrderStatus.Pending;

            // Save current date and time
            OrderDate = DateTime.Now;
        }

        // Method to add product to order
        public void AddProduct(Product product, int quantity)
        {
            // Check if quantity is valid and available in stock
            if (quantity > 0 && quantity <= product.StockQuantity)
            {
                // Add product as order item
                Items.Add(new OrderItem(product, quantity));

                // Reduce product stock after adding
                product.StockQuantity -= quantity;
            }
        }

        // Method to calculate total order price
        public decimal CalculateTotal()
        {
            // Variable to store total amount
            decimal total = 0;

            // Loop through all order items
            foreach (OrderItem item in Items)
            {
                // Add item subtotal to total
                total += item.SubTotal;
            }

            // Return final total price
            return total;
        }

        // Method to assign payment method
        public void SetPayment(Payment payment)
        {
            // Save selected payment object
            PaymentMethod = payment;
        }

        // Method to confirm order
        public string ConfirmOrder()
        {
            // Change order status to processing
            Status = OrderStatus.Processing;

            // Calculate total amount
            decimal total = CalculateTotal();

            // Process payment
            string paymentMessage = PaymentMethod.Pay(total);

            // Ship the order
            string shippingMessage = Ship();

            // Return payment and shipping messages
            return paymentMessage + "\n" + shippingMessage;
        }

        // Method to ship the order
        public string Ship()
        {
            // Change order status to shipped
            Status = OrderStatus.Shipped;

            // Return shipping confirmation message
            return "Order has been shipped successfully.";
        }
    }
}
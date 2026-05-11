using System;
using System.Collections.Generic;
using OrderProcessingSystem.Interfaces;
using OrderProcessingSystem.Payments;

namespace OrderProcessingSystem.Models
{
    public class Order : IShippable
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public Payment PaymentMethod { get; set; }
        public Order(int id, Customer customer)
        {
            Id = id;

            Customer = customer;

            Items = new List<OrderItem>();

            Status = OrderStatus.Pending;

            OrderDate = DateTime.Now;
        }

        public void AddProduct(Product product, int quantity)
        {
            if (quantity > 0 && quantity <= product.StockQuantity)
            {
                Items.Add(new OrderItem(product, quantity));

                product.StockQuantity -= quantity;
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.SubTotal;
            }

            return total;
        }

        public void SetPayment(Payment payment)
        {
            PaymentMethod = payment;
        }

        public string ConfirmOrder()
        {
            Status = OrderStatus.Processing;

            decimal total = CalculateTotal();

            string paymentMessage = PaymentMethod.Pay(total);

            string shippingMessage = Ship();

            return paymentMessage + "\n" + shippingMessage;
        }

        public string Ship()
        {
            Status = OrderStatus.Shipped;

            return "Order has been shipped successfully.";
        }
    }
}
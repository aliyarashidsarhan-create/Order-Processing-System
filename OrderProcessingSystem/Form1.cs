using OrderProcessingSystem.Models;
using OrderProcessingSystem.Payments;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProcessingSystem.Forms
{
    public partial class Form1 : Form
    {
        List<Customer> customers = new List<Customer>();
        List<Product> products = new List<Product>();

        Order currentOrder;
        int customerId = 1;
        int productId = 1;
        int orderId = 1;

        public Form1()
        {
            InitializeComponent();

            cmbProductType.Items.Add("Electronics");
            cmbProductType.Items.Add("Clothing");

            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Credit Card");
            cmbPayment.Items.Add("PayPal");

            cmbProductType.SelectedIndex = 0;
            cmbPayment.SelectedIndex = 0;

            lblTotal.Text = "Total: 0 OMR";
            lblStatus.Text = "Status: No Order";
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "" || txtCustomerEmail.Text == "")
            {
                MessageBox.Show("Please enter customer name and email.");
                return;
            }

            Customer customer = new Customer(
                customerId,
                txtCustomerName.Text,
                txtCustomerEmail.Text
            );

            customers.Add(customer);
            cmbCustomers.Items.Add(customer);

            customerId++;

            txtCustomerName.Clear();
            txtCustomerEmail.Clear();

            MessageBox.Show("Customer saved successfully.");
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "" || txtProductPrice.Text == "" || txtProductStock.Text == "")
            {
                MessageBox.Show("Please enter all product information.");
                return;
            }

            decimal price;
            int stock;

            if (!decimal.TryParse(txtProductPrice.Text, out price))
            {
                MessageBox.Show("Price must be a number.");
                return;
            }

            if (!int.TryParse(txtProductStock.Text, out stock))
            {
                MessageBox.Show("Stock must be a number.");
                return;
            }

            Product product;

            if (cmbProductType.Text == "Electronics")
            {
                product = new ElectronicsProduct(productId, txtProductName.Text, price, stock);
            }
            else
            {
                product = new ClothingProduct(productId, txtProductName.Text, price, stock);
            }

            products.Add(product);
            lstProducts.Items.Add(product);

            productId++;

            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductStock.Clear();

            MessageBox.Show("Product added successfully.");
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.");
                return;
            }

            if (lstProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            Customer selectedCustomer = (Customer)cmbCustomers.SelectedItem;

            if (currentOrder == null)
            {
                currentOrder = new Order(orderId, selectedCustomer);
                selectedCustomer.Orders.Add(currentOrder);
                orderId++;
            }

            Product selectedProduct = (Product)lstProducts.SelectedItem;
            int quantity = (int)nudQuantity.Value;

            try
            {
                currentOrder.AddProduct(selectedProduct, quantity);

                lstOrderItems.Items.Add(new OrderItem(selectedProduct, quantity));

                UpdateTotal();

                lblStatus.Text = "Status: " + currentOrder.Status.ToString();

                lstProducts.Items.Clear();

                foreach (Product product in products)
                {
                    lstProducts.Items.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (currentOrder == null || currentOrder.Items.Count == 0)
            {
                MessageBox.Show("Please add products to the order first.");
                return;
            }

            Payment payment;

            if (cmbPayment.Text == "Cash")
            {
                payment = new CashPayment();
            }
            else if (cmbPayment.Text == "Credit Card")
            {
                payment = new CreditCardPayment();
            }
            else
            {
                payment = new PaypalPayment();
            }

            currentOrder.SetPayment(payment);

            try
            {
                string message = currentOrder.ConfirmOrder();

                lblStatus.Text = "Status: " + currentOrder.Status.ToString();
                UpdateTotal();

                MessageBox.Show(message, "Order Confirmed");

                currentOrder = null;
                lstOrderItems.Items.Clear();
                lblTotal.Text = "Total: 0 OMR";
                lblStatus.Text = "Status: Order Completed";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateTotal()
        {
            if (currentOrder != null)
            {
                lblTotal.Text = "Total: " + currentOrder.CalculateTotal() + " OMR";
            }
        }
    }
}
namespace OrderProcessingSystem.Forms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Button btnSaveCustomer;

        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Button btnAddProduct;

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblSelectCustomer;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblAvailableProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label lblOrderItems;
        private System.Windows.Forms.ListBox lstOrderItems;
        private System.Windows.Forms.Label lblTotal;

        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblSelectCustomer = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblAvailableProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.lblOrderItems = new System.Windows.Forms.Label();
            this.lstOrderItems = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpCustomer.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblCustomerName);
            this.grpCustomer.Controls.Add(this.txtCustomerName);
            this.grpCustomer.Controls.Add(this.lblCustomerEmail);
            this.grpCustomer.Controls.Add(this.txtCustomerEmail);
            this.grpCustomer.Controls.Add(this.btnSaveCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(20, 20);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(450, 144);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Information";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Location = new System.Drawing.Point(20, 35);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(100, 25);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 32);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(280, 25);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.Location = new System.Drawing.Point(20, 75);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(100, 25);
            this.lblCustomerEmail.TabIndex = 2;
            this.lblCustomerEmail.Text = "Email";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(120, 72);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(280, 25);
            this.txtCustomerEmail.TabIndex = 3;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnSaveCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveCustomer.Location = new System.Drawing.Point(280, 100);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(120, 30);
            this.btnSaveCustomer.TabIndex = 4;
            this.btnSaveCustomer.Text = "Save Customer";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.lblProductName);
            this.grpProduct.Controls.Add(this.txtProductName);
            this.grpProduct.Controls.Add(this.lblProductPrice);
            this.grpProduct.Controls.Add(this.txtProductPrice);
            this.grpProduct.Controls.Add(this.lblProductStock);
            this.grpProduct.Controls.Add(this.txtProductStock);
            this.grpProduct.Controls.Add(this.lblProductType);
            this.grpProduct.Controls.Add(this.cmbProductType);
            this.grpProduct.Controls.Add(this.btnAddProduct);
            this.grpProduct.Location = new System.Drawing.Point(20, 170);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(450, 220);
            this.grpProduct.TabIndex = 1;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product Information";
            // 
            // lblProductName
            // 
            this.lblProductName.Location = new System.Drawing.Point(20, 35);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(120, 25);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(140, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(260, 25);
            this.txtProductName.TabIndex = 1;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.Location = new System.Drawing.Point(20, 75);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(120, 25);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(140, 72);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(260, 25);
            this.txtProductPrice.TabIndex = 3;
            // 
            // lblProductStock
            // 
            this.lblProductStock.Location = new System.Drawing.Point(20, 115);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(120, 25);
            this.lblProductStock.TabIndex = 4;
            this.lblProductStock.Text = "Stock Quantity";
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(140, 112);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(260, 25);
            this.txtProductStock.TabIndex = 5;
            // 
            // lblProductType
            // 
            this.lblProductType.Location = new System.Drawing.Point(20, 155);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(120, 25);
            this.lblProductType.TabIndex = 6;
            this.lblProductType.Text = "Product Type";
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.Location = new System.Drawing.Point(140, 152);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(260, 25);
            this.cmbProductType.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(280, 185);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblSelectCustomer);
            this.grpOrder.Controls.Add(this.cmbCustomers);
            this.grpOrder.Controls.Add(this.lblAvailableProducts);
            this.grpOrder.Controls.Add(this.lstProducts);
            this.grpOrder.Controls.Add(this.lblQuantity);
            this.grpOrder.Controls.Add(this.nudQuantity);
            this.grpOrder.Controls.Add(this.btnAddToOrder);
            this.grpOrder.Controls.Add(this.lblOrderItems);
            this.grpOrder.Controls.Add(this.lstOrderItems);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Location = new System.Drawing.Point(500, 20);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(460, 370);
            this.grpOrder.TabIndex = 2;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Information";
            // 
            // lblSelectCustomer
            // 
            this.lblSelectCustomer.Location = new System.Drawing.Point(20, 35);
            this.lblSelectCustomer.Name = "lblSelectCustomer";
            this.lblSelectCustomer.Size = new System.Drawing.Size(130, 25);
            this.lblSelectCustomer.TabIndex = 0;
            this.lblSelectCustomer.Text = "Select Customer";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.Location = new System.Drawing.Point(150, 32);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(270, 25);
            this.cmbCustomers.TabIndex = 1;
            // 
            // lblAvailableProducts
            // 
            this.lblAvailableProducts.Location = new System.Drawing.Point(20, 75);
            this.lblAvailableProducts.Name = "lblAvailableProducts";
            this.lblAvailableProducts.Size = new System.Drawing.Size(160, 25);
            this.lblAvailableProducts.TabIndex = 2;
            this.lblAvailableProducts.Text = "Available Products";
            // 
            // lstProducts
            // 
            this.lstProducts.ItemHeight = 17;
            this.lstProducts.Location = new System.Drawing.Point(20, 100);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(190, 157);
            this.lstProducts.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(240, 100);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 25);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(320, 98);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(100, 25);
            this.nudQuantity.TabIndex = 5;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnAddToOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToOrder.Location = new System.Drawing.Point(300, 135);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(120, 35);
            this.btnAddToOrder.TabIndex = 6;
            this.btnAddToOrder.Text = "Add To Order";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // lblOrderItems
            // 
            this.lblOrderItems.Location = new System.Drawing.Point(240, 185);
            this.lblOrderItems.Name = "lblOrderItems";
            this.lblOrderItems.Size = new System.Drawing.Size(120, 25);
            this.lblOrderItems.TabIndex = 7;
            this.lblOrderItems.Text = "Order Items";
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.ItemHeight = 17;
            this.lstOrderItems.Location = new System.Drawing.Point(240, 210);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(190, 89);
            this.lstOrderItems.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(240, 325);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 25);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total: 0 OMR";
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.lblPaymentMethod);
            this.grpPayment.Controls.Add(this.cmbPayment);
            this.grpPayment.Controls.Add(this.btnConfirmOrder);
            this.grpPayment.Controls.Add(this.lblStatus);
            this.grpPayment.Location = new System.Drawing.Point(20, 410);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(940, 170);
            this.grpPayment.TabIndex = 3;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment and Status";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Location = new System.Drawing.Point(20, 40);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(130, 25);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.Location = new System.Drawing.Point(160, 37);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(250, 25);
            this.cmbPayment.TabIndex = 1;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmOrder.Location = new System.Drawing.Point(440, 35);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(150, 35);
            this.btnConfirmOrder.TabIndex = 2;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(610, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 30);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: No Order";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpPayment);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Processing System";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void StyleButton(System.Windows.Forms.Button btn)
        {
            btn.BackColor = System.Drawing.Color.SteelBlue;
            btn.ForeColor = System.Drawing.Color.White;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        }
    }

}
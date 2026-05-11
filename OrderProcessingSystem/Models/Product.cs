namespace OrderProcessingSystem.Models
{
    public abstract class Product
    {
        private int id;
        private string name;
        private decimal price;
        private int stockQuantity;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set
            {
                if (value >= 0)
                    stockQuantity = value;
            }
        }

        public Product(int id, string name, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public abstract decimal CalculateDiscount();

        public override string ToString()
        {
            return $"{Name} - {Price} OMR - Stock: {StockQuantity}";
        }
    }
}
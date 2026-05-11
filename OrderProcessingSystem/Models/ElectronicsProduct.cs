namespace OrderProcessingSystem.Models
{
    public class ElectronicsProduct : Product
    {
        public ElectronicsProduct(int id, string name, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.10m;
        }
    }
}
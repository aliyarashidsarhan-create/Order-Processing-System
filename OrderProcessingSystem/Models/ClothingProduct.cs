namespace OrderProcessingSystem.Models
{
    public class ClothingProduct : Product
    {
        public ClothingProduct(int id, string name, decimal price, int stockQuantity)
        {
            Id = id;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public override decimal CalculateDiscount()
        {
            return Price * 0.05m;
        }
    }
}
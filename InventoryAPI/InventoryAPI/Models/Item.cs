namespace InventoryAPI.Models
{
    public class Item
    {
        public int Id { get; set; } // Database Primary Key
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Brand { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int StockQuantity { get; set; } // Tracks current stock
        public int LowStockThreshold { get; set; } // Triggers system warnings
    }
}

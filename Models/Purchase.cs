namespace InventoryMS.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}

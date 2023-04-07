namespace myFirstApi.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int amount { get; set; }
        public int ProductId { get; set; }
        public Products Products {get; set;}
    }
}

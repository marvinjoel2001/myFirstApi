namespace myFirstApi.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Inventory> Inventory { get; set; }
        
    }
}

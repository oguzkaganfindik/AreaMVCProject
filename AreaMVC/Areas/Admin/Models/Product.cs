namespace AreaMVC.Areas.Admin.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
    }
}

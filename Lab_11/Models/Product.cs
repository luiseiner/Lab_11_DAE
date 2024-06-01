namespace Lab_11.Models
{
    public class Product
    {
        public int IdProducts { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public IList<Detail> Details { get; set; } = new List<Detail>();
    }
}

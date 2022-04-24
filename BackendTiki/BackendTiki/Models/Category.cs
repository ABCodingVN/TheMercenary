namespace BackendTiki.Models
{
    public class Category
    {   
        private string categoryId;
        private string name;
        private ICollection<Product> products;

        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public ICollection<Product> Products { get => products; set => products = value; }
    }
}

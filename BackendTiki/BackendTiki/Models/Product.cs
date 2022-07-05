namespace BackendTiki.Models
{
    public class Product
    {
        private string productId;
        private string categoryId;
        private string name;
        private string imageURL;
        private double price;
        private string productDetailId;

        public string ProductId { get => productId; set => productId = value; }
        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string Name { get => name; set => name = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public double Price { get => price; set => price = value; }
        public string ProductDetailId { get => productDetailId; set => productDetailId = value; }
    }
    
}

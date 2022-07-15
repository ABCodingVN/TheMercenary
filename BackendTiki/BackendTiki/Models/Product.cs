namespace BackendTiki.Models
{
    public class Product
    {
        private string productId;
        private string supplierId;
        private string categoryId;
        private string rattingId;
        private string name;
        private string imageURL;
        private double price;
        private string description;
        private int quantity;
        private string size;
        private string color;
        private string origin;
        private string originBrand;
        private string localBrand;
        private DateTime expiryDate;

        private Category category;
        private Supplier supplier;
        private ICollection<Ratting> rattings;
        private Ratting ratting;
        private ICollection<Order> orders;

        public string ProductId { get => productId; set => productId = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string CategoryId { get => categoryId; set => categoryId = value; }
        public string RattingId { get => rattingId; set => rattingId = value; }
        public string Name { get => name; set => name = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Size { get => size; set => size = value; }
        public string Color { get => color; set => color = value; }
        public string Origin { get => origin; set => origin = value; }
        public string OriginBrand { get => originBrand; set => originBrand = value; }
        public string LocalBrand { get => localBrand; set => localBrand = value; }
        public DateTime ExpiryDate { get => expiryDate; set => expiryDate = value; }
        public Category Category { get => category; set => category = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public ICollection<Ratting> Rattings { get => rattings; set => rattings = value; }
        public Ratting Ratting { get => ratting; set => ratting = value; }
        public ICollection<Order> Orders { get => orders; set => orders = value; }
    }
    
}

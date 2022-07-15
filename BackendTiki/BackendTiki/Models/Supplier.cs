namespace BackendTiki.Models
{
    public class Supplier
    {
        private string supplierId;
        private string nameShop;
        private int quantityFollower;
        private string addressShop;
        private Double percentRepChat;
        
        private ICollection<Product> products;
        private ICollection<ReplyRatting> replyRatings;
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string NameShop { get => nameShop; set => nameShop = value; }
        public int QuantityFollower { get => quantityFollower; set => quantityFollower = value; }
        public string AddressShop { get => addressShop; set => addressShop = value; }
        public double PercentRepChat { get => percentRepChat; set => percentRepChat = value; }
        
        public ICollection<Product> Products { get => products; set => products = value; }
        public ICollection<ReplyRatting> ReplyRatings { get => replyRatings; set => replyRatings = value; }
    }
}

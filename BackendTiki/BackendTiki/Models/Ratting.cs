using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class Ratting
    {
        private string rattingId;
        private string productId;
        private string status;
        private Double pointStar;
        private string describe;
        private string imageURL;
        private string videoURL;
        private DateTime time;
        private int likee;
        [JsonIgnore]
        private ICollection<Product> products;
        [JsonIgnore]
        private Product product;
        public string RattingId { get => rattingId; set => rattingId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string Status { get => status; set => status = value; }
        public double PointStar { get => pointStar; set => pointStar = value; }
        public string Describe { get => describe; set => describe = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public string VideoURL { get => videoURL; set => videoURL = value; }
        public DateTime Time { get => time; set => time = value; }
        public int Likee { get => likee; set => likee = value; }
        [JsonIgnore]
        public ICollection<Product> Products { get => products; set => products = value; }
        [JsonIgnore]
        public Product Product { get => product; set => product = value; }
    }
}

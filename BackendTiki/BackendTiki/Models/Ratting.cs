namespace BackendTiki.Models
{
    public class Ratting
    {
        private string ratingId;
        private string userId;
        private string productId;
        private string status;
        private Double pointStar;
        private string decribe;
        private string imageURL;
        private string videoURL;
        private DateTime time;
        private int likee;

       /* private ICollection<User> users;
        private ICollection<Product> products;*/
        public string RatingId { get => ratingId; set => ratingId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string Status { get => status; set => status = value; }
        public double PointStar { get => pointStar; set => pointStar = value; }
        public string Decribe { get => decribe; set => decribe = value; }
        public string ImageURL { get => imageURL; set => imageURL = value; }
        public string VideoURL { get => videoURL; set => videoURL = value; }
        public DateTime Time { get => time; set => time = value; }
        public int Likee { get => likee; set => likee = value; }
       /* public ICollection<User> Users { get => users; set => users = value; }*/
    }
}

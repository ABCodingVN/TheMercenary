using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class ReplyRatting
    {
        private string replyId;
        private string supplierId;
        private string rattingId;
        private string decribe;
        private DateTime time;
        private int likee;

        [JsonIgnore]
        private Supplier supplier;
        [JsonIgnore]
        private Ratting ratting;
        public string ReplyId { get => replyId; set => replyId = value; }
        public string SupplierId { get => supplierId; set => supplierId = value; }
        public string RattingId { get => rattingId; set => rattingId = value; }
        public string Decribe { get => decribe; set => decribe = value; }
        public DateTime Time { get => time; set => time = value; }
        public int Likee { get => likee; set => likee = value; }

        [JsonIgnore]
        public Supplier Supplier { get => supplier; set => supplier = value; }
        [JsonIgnore]
        public Ratting Ratting { get => ratting; set => ratting = value; }
    }
}

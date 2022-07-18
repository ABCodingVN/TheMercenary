using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class Voucher
    {
        private string voucherId;
        private string codeVoucher;
        private string name;
        private string categoryVoucher;
        private DateTime dateBegin;
        private DateTime dateFinish;
        private int quantity;
        private int quantityUsed;
        private Double percentDiscount;
        private Double maxMoney;

        [JsonIgnore]
        private ICollection<Order> orders;

        public string VoucherId { get => voucherId; set => voucherId = value; }
        public string CodeVoucher { get => codeVoucher; set => codeVoucher = value; }
        public string Name { get => name; set => name = value; }
        public string CategoryVoucher { get => categoryVoucher; set => categoryVoucher = value; }
        public DateTime DateBegin { get => dateBegin; set => dateBegin = value; }
        public DateTime DateFinish { get => dateFinish; set => dateFinish = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int QuantityUsed { get => quantityUsed; set => quantityUsed = value; }
        public double PercentDiscount { get => percentDiscount; set => percentDiscount = value; }
        public double MaxMoney { get => maxMoney; set => maxMoney = value; }

        [JsonIgnore]
        public ICollection<Order> Orders { get => orders; set => orders = value; }
    }
}

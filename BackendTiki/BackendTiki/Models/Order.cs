using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class Order
    {
        private string orderId;
        private string productId;
        private string userId;
        private string voucherId;
        private int quantity;
        private Double totalPayment;
        private Double discountMoney;
        private DateTime dateOrders;

        [JsonIgnore]
        private Product product;
        [JsonIgnore]
        private User users;
        [JsonIgnore]
        private Voucher vouchers;
        

        public string OrderId { get => orderId; set => orderId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string VoucherId { get => voucherId; set => voucherId = value; } 
        public int Quantity { get => quantity; set => quantity = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public double DiscountMoney { get => discountMoney; set => discountMoney = value; }
        public DateTime DateOrders { get => dateOrders; set => dateOrders = value; }
        [JsonIgnore] 
        public Product Product { get => product; set => product = value; }
        [JsonIgnore] 
        public User Users { get => users; set => users = value; }
        [JsonIgnore] 
        public Voucher Vouchers { get => vouchers; set => vouchers = value; }
    
    }
}

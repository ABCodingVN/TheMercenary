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

        private Product product;
        private User users;
        private Voucher vouchers;
        

        public string OrderId { get => orderId; set => orderId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string VoucherId { get => voucherId; set => voucherId = value; } 
        public int Quantity { get => quantity; set => quantity = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public double DiscountMoney { get => discountMoney; set => discountMoney = value; }
        public DateTime DateOrders { get => dateOrders; set => dateOrders = value; }
        public Product Product { get => product; set => product = value; }
        public User Users { get => users; set => users = value; }
        public Voucher Vouchers { get => vouchers; set => vouchers = value; }
    
    }
}

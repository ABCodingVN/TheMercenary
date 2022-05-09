namespace BackendTiki.Models
{
    public class Order
    {
        private string orderid;
        private string productId;
        private string userId;
        private string voucherId;
        private int quantity;
        private Double totalPayment;
        private Double discountMoney;
        private DateTime dateOrders;

        public string Orderid { get => orderid; set => orderid = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string UserId { get => userId; set => userId = value; }
        public string VoucherId { get => voucherId; set => voucherId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double TotalPayment { get => totalPayment; set => totalPayment = value; }
        public double DiscountMoney { get => discountMoney; set => discountMoney = value; }
        public DateTime DateOrders { get => dateOrders; set => dateOrders = value; }
    }
}

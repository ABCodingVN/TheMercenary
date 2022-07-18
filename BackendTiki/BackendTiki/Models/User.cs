using Newtonsoft.Json;

namespace BackendTiki.Models
{
    public class User
    {
        private string userId;
        private string wardsID;
        private string name;
        private string password;
        private string typeAccount;
        private string phoneNumber;
        private string address;
        private string gmail;

        [JsonIgnore]
        private Wards wards;
        [JsonIgnore]
        private ICollection<Order> orders;
        public string UserId { get => userId; set => userId = value; }
        public string WardsID { get => wardsID; set => wardsID = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string TypeAccount { get => typeAccount; set => typeAccount = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Gmail { get => gmail; set => gmail = value; }

        [JsonIgnore]
        public Wards Wards { get => wards; set => wards = value; }
        [JsonIgnore]
        public ICollection<Order> Orders { get => orders; set => orders = value; }
    }
}

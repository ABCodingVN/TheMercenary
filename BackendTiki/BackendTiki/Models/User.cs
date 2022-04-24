namespace BackendTiki.Models
{
    public class User
    {
        private string userId;
        private string name;
        private string password;
        private string typeAccount;
        private string phoneNumber;
        private string location;
        private string city;
        private string district;
        private string wards;
        private string address;
        private string gmail;

        public string UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string TypeAccount { get => typeAccount; set => typeAccount = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Location { get => location; set => location = value; }
        public string City { get => city; set => city = value; }
        public string District { get => district; set => district = value; }
        public string Wards { get => wards; set => wards = value; }
        public string Address { get => address; set => address = value; }
        public string Gmail { get => gmail; set => gmail = value; }
    }
}

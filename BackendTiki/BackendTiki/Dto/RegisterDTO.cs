namespace BackendTiki.Dto
{
    public class RegisterDTO
    {
  
        private string? wardsID;
        private string name;
        private string? password;
        private string phoneNumber;
        private string address;
        private string gmail;

        public string? WardsID { get => wardsID; set => wardsID = value; }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Gmail { get => gmail; set => gmail = value; }
    }
}

namespace BackendTiki.Dto
{
    public class LoginDTO
    {
        private string phoneNumber;
        private string password;

        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Password { get => password; set => password = value; }
    }
}

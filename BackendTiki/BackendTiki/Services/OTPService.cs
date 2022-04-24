using BackendTiki.Access;
using BackendTiki.Models;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Verify.V2.Service.Entity;

namespace BackendTiki.Services
{
    public class OTPService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
        static private Boolean OPTEffect = false;
        public OTPService(IConfiguration configuration, Context context)
        {
            _configuration = configuration;
            _context = context;

        }
        public void CreateOPT()
        {

            TwilioClient.Init("AC60bef8ee4a607e56bcb576f149c3c6aa", "84ff786719e7074d7f9665933eb6b738");
          /*  var validationRequest = ValidationRequestResource.Create(
                      friendlyName: "My Home Phone Number",
                      phoneNumber: new Twilio.Types.PhoneNumber("+14158675310")
                  );*/

           /* Console.WriteLine(validationRequest.FriendlyName);*/
        }
        public int SendOTP(string phone)
        {
            User user = _context.Users.FirstOrDefault(u => u.PhoneNumber.Equals(phone));
            TwilioClient.Init("AC60bef8ee4a607e56bcb576f149c3c6aa", "84ff786719e7074d7f9665933eb6b738");
            if (user == null) return -1;

            Random random = new Random();
            int OTPNumber = random.Next(100000, 999999);
            var message = MessageResource.Create(
                body: "Tiki - Mã OPT của bạn là "+ OTPNumber,
                from: new Twilio.Types.PhoneNumber("+18648033661"),
                to: new Twilio.Types.PhoneNumber(phone)
            );
            return OTPNumber;
        }
     
      
    }
}

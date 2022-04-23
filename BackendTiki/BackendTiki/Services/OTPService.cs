using BackendTiki.Access;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Verify.V2.Service.Entity;

namespace BackendTiki.Services
{
    public class OTPService
    {
        private readonly Context _context;
        private readonly IConfiguration _configuration;
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
        public void SendOTP()
        {
            
           TwilioClient.Init("AC60bef8ee4a607e56bcb576f149c3c6aa", "84ff786719e7074d7f9665933eb6b738");
        
            var message = MessageResource.Create(
                body: "Hello Đây là tin nhắn OPT của Tiki Project",
                from: new Twilio.Types.PhoneNumber("+18648033661"),
                to: new Twilio.Types.PhoneNumber("+84963639201")
            );

            Console.WriteLine(message.Sid);
        }
    }
}

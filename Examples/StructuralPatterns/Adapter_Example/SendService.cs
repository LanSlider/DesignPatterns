using System.Net;
using System.Net.Mail;

namespace Adapter_Example
{
    class SendService
    {
        public virtual void Request()
        {
            this.SendDataOnEmail("", "");
        }

        public virtual void SendDataOnEmail(string data, string email)
        {
            var from = new MailAddress(email, "Tom");
            var to = new MailAddress(email);

            var m = new MailMessage(from, to);
            m.Body = data;

            var smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("somemail@gmail.com", "mypassword");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}

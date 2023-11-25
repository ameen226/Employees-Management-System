using DAL.Models;
using System.Net;
using System.Net.Mail;

namespace PL.Helpers
{
	public static class EmailSettings
	{
		public static void SendEmail(Email email)
		{

			var client = new SmtpClient("smtp.gmail.com", 587);
			client.EnableSsl = true;
			client.Credentials = new NetworkCredential("hosan2662000@gmail.com", "gowmicxgkrriwkqk");
			client.Send("hosan2662000@gmail.com", email.To, email.Subject, email.Body);


		}
	}
}

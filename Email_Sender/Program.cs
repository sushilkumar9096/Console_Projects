namespace Email_Sender
{
    using System;
    using System.Net;
    using System.Net.Mail;

    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter receiver email:");
            string toEmail = Console.ReadLine() ?? "";

            Console.WriteLine("Enter subject:");
            string subject = Console.ReadLine() ?? "";

            Console.WriteLine("Enter message:");
            string body = Console.ReadLine() ?? "";

            try
            {
                using MailMessage mail = new MailMessage();

                mail.From = new MailAddress("kuchamesushil979@gmail.com");
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                using SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential(
                    "kuchamesushil979@gmail.com",
                    "your_app_password"
                );

                smtp.EnableSsl = true;

                smtp.Send(mail);

                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }
}

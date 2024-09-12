using System.Net;
using System.Net.Mail;
using System.Text;

class Programm
{
    static void Main()
    {
        try
        {
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            using (MailMessage message = new MailMessage())
            {
                Encoding encoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = false;
                message.SubjectEncoding = encoding;
                message.BodyEncoding = encoding;
                message.From = new MailAddress("filinov2006@mail.ru", "filinov2006@mail.ru", encoding);
                message.Bcc.Add(new MailAddress("npl1u1pc@mail.ru", "npl1u1pc@mail.ru", encoding));
                Console.WriteLine("Введите тему");
                message.Subject = Console.ReadLine();
                Console.WriteLine("Введите текст");
                message.Body = Console.ReadLine();
                smtp.EnableSsl = true;
                smtp.Credentials = new System.Net.NetworkCredential("filinov2006@mail.ru", "password");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.Read();
        }
    }
}

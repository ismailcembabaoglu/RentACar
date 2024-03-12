using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using RentACar.Application.DTOs.OtherDTOs;

namespace RentACar.Persistence.Extensions
{
    public static class MailSender
    {
        public static void Gonder(MailSenderDTO mailSender)
        {
            try
            {
                MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("babaogluismailcem@gmail.com");
            //
            ePosta.To.Add(mailSender.SenderMail);
            //ePosta.To.Add("eposta2@gmail.com");
            //ePosta.To.Add("eposta3@gmail.com");
            //
            //ePosta.Attachments.Add(new Attachment(@"C:\deneme-upload.jpg"));
            ePosta.Subject = mailSender.Subject;
            ePosta.Body = mailSender.Content;
            ePosta.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("babaogluismailcem@gmail.com", "Cib_1742");

            // object userState = ePosta;
           
            
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
                {
                    return true;
                };
                // smtp.SendAsync(ePosta, (object)ePosta);
                smtp.Send(ePosta);

            }
           
            catch (SmtpException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}

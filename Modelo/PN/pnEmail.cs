using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.VM;
using System.Net.Mail;
using System.Net;

namespace Modelo.PN
{
    public static class pnEmail
    {
        public static async Task EnviarMailAsync(vmEmail model, string para)
        //public ActionResult Contact(vmFormularioEmail model)
        {
            var body = "<p> {0} </p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(para)); //Destinatário
            message.From = new MailAddress("stdutfpr@gmail.com"); //Remetente
            message.Subject = "Suporte do Site de Eventos";
            message.Body = string.Format(body, model.Mensage);
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "devsist.arqueiro@gmail.com", // Seu E-mail
                    Password = "Arqueiros73" // Sua Senha
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
            }
        }
        public static async Task EnviarMailAsync(List<String> mensagem, string para)
        //public ActionResult Contact(vmFormularioEmail model)
        {
            var body = "<p> {0} </p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(para)); //Destinatário
            message.From = new MailAddress("stdutfpr@gmail.com"); //Remetente
            message.Subject = "Suporte do Site de Eventos";
            foreach (String m in mensagem)
                message.Body += string.Format(body, m);            
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "devsist.arqueiro@gmail.com", // Seu E-mail
                    Password = "Arqueiros73" // Sua Senha
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
            }
        }

    }
}
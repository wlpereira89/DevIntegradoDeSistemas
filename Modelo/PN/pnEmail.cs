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
            
            
            using (var doc = new PdfSharp.Pdf.PdfDocument())
            {
                var page = doc.AddPage();
                var graphics = PdfSharp.Drawing.XGraphics.FromPdfPage(page);
                var textFormatter = new PdfSharp.Drawing.Layout.XTextFormatter(graphics);
                var font = new PdfSharp.Drawing.XFont("Arial", 14);
                
                int i = 0;
                foreach (String m in mensagem)
                {
                    textFormatter.DrawString(m + "\n", font, PdfSharp.Drawing.XBrushes.Red, new PdfSharp.Drawing.XRect(0, i, page.Width, page.Height));
                    i += 20;
                }
                    
                doc.Save(AppDomain.CurrentDomain.BaseDirectory + "mail2.pdf");
                doc.Close();
                
                var message = new MailMessage();
                message.To.Add(new MailAddress(para)); //Destinatário
                message.From = new MailAddress("stdutfpr@gmail.com"); //Remetente
                message.Subject = "Suporte do Site de Eventos";
                message.Attachments.Add(new Attachment(AppDomain.CurrentDomain.BaseDirectory + "mail.pdf"));

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
                    
                    await smtp.SendMailAsync(message) ;
                }
            }

            
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Net.Configuration;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Net.Mime;


namespace Novo_Projeto_Tantas
{
    public class EnviaEmail
    {
        public Boolean EnviarEmail(String Nome, String Senha, String Destinatario)
        {
            bool StatusEnvio = false;
         
            try
            {   
                MailMessage meuEmail = new MailMessage();
                SmtpClient Smtp = new SmtpClient();
                meuEmail.From = new MailAddress("ADMTantas@gmail.com");
                meuEmail.To.Add(new MailAddress(Destinatario));
                meuEmail.Subject = "Envio de senha de acesso";
                meuEmail.Body = "Olá "+ Nome +" sua senha de acesso é: " + Senha +"";
                meuEmail.IsBodyHtml = true;
                Smtp.Port = 587;
                Smtp.Host = "smtp.gmail.com";
                Smtp.EnableSsl = true;
                Smtp.UseDefaultCredentials = false;
                Smtp.Credentials = new System.Net.NetworkCredential("ADMTantas@gmail.com", "nigtchumetchule");
                Smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                Smtp.Send(meuEmail);
                meuEmail.Dispose();               
                StatusEnvio = true;
            }
            catch
            {
                StatusEnvio = false;
            }
            return StatusEnvio;
        }
          public Boolean EnviarEmailCliente(String Destinatario,List<string> ListaCC, String Assunto,String Mensagem, List<string> Anexo)
          {
              bool status = false;

              try
              {
                  MailMessage meuEmail = new MailMessage();
                  SmtpClient Smtp = new SmtpClient();
                  meuEmail.From = new MailAddress("rbsilva.leandro@gmail.com");
                  meuEmail.To.Add(new MailAddress(Destinatario));
                  if (ListaCC.Count != 0)
                  {
                      foreach (string listadeCopias in ListaCC)
                      {
                          meuEmail.CC.Add(new MailAddress(listadeCopias, MediaTypeNames.Application.Octet));                  
                      }
                  }
                  if (Anexo.Count != 0)
                  {
                      foreach (string listaanexos in Anexo)
                      {
                          System.Net.Mail.Attachment AnexoEmail = new System.Net.Mail.Attachment(listaanexos,MediaTypeNames.Application.Octet);
                          meuEmail.Attachments.Add(AnexoEmail);
                      }
                  }
                  meuEmail.Subject = Assunto;
                  meuEmail.Body = Mensagem;                
                  meuEmail.IsBodyHtml = true;
                  Smtp.Port = 587;
                  Smtp.Host = "smtp.gmail.com";
                  Smtp.EnableSsl = true;
                  Smtp.UseDefaultCredentials = false;
                  Smtp.Credentials = new System.Net.NetworkCredential("ADMTantas@gmail.com", "nigtchumetchule");
                  Smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                  Smtp.Send(meuEmail);
                  meuEmail.Dispose();
                  status = true;
              }
              catch
              {
                  status = false;
              }

              return status;
          }
    
    }
}

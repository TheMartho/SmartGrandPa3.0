using System;
using System.Net.Mail;
using System.Configuration;
using System.Web.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmartGrandpaWeb
{
    public partial class Contacto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar_Click(object sender, EventArgs e)
        {
            //SE INSTANCIA LA CLASE MAILMESSAGE
            MailMessage correo = new MailMessage();
            //SE INDICA EL CORREO QUE ENVIARA EL MENSAJE
            correo.From = new MailAddress("smartgrandpacontacto@gmail.com", "Diego Fernandez", System.Text.Encoding.UTF8);
            // SE INDICA EL DESTINATARIO
            correo.To.Add("smartgrandpacontacto@gmail.com");
            // SE INDICA EL ASUNTO
            correo.Subject = "Sugerencia o Opinion SmartGrandPa"; 
            // SE INDICA EL CONTENIDO DEL CORREO
            correo.Body = nombreTxt.Text.ToString().Trim() + Environment.NewLine + celularTxt.Text.ToString().Trim() + Environment.NewLine + correoTxt.Text.ToString().Trim() + Environment.NewLine
                + contenidoTxt.Text.ToString().Trim();
            correo.IsBodyHtml = true;
            //SE ESTABLECE LA PRIORIDAD DEL CORREO
            correo.Priority = MailPriority.Normal;
            SmtpClient smtp = new SmtpClient();
            //SE INDICA QUE NO USE CREDENCIALES POR DEFECTO
            smtp.UseDefaultCredentials = false;
            //SE ESPECIFICA EL HOST DEL SERVIDOR DE CORREOS
            smtp.Host = "smtp.gmail.com";
            //SE INDICA EL PUERTO DE SALIDA DEL SERVIDOR DE CORREOS
            smtp.Port = 25;
            //SE ESTABLECEN LAS CREDENCIALES DEL CORREO 
            smtp.Credentials = new System.Net.NetworkCredential("smartgrandpacontacto@gmail.com", "Inacapino2021");
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            //True si el servidor de correo permite ssl
            smtp.EnableSsl = true;
            //Se envia el correo
            smtp.Send(correo);

            Response.Redirect("exito.aspx");

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviarMail_net_Core
{
    public partial class EnvioCorreoGmail : Form
    {
        public EnvioCorreoGmail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            correo.Clear();
            asunto.Clear();
            cuerpo.Clear();
        }
        private void enviarMail(string addressfrom, String subject, String body)
        {
            try
            {
                //string ruta = "D:/Carga.csv"; //Ruta del codumento que se adjuntara en el correo (OPCIONAL)
                //string addressfrom = "correoDestino@gmail.com"; //Correo destino
                string addressto = "miEmpresa@gmail.com"; //Servidor de correo, en este caso usare un correo secundario que creé para efectos de practica
                string password = "miContraseña123"; //Contraseña del correo
                int port = 587; //Puerto por defecto de SMPT de GMAIL 
                //string subject = "El asunto del correo";
                //string body = "Cuerpo del correo o todo el contenido del correo";
                string server = "smtp.gmail.com"; //Servidor de correo del GMAIL

                SmtpClient SmtpServer = new SmtpClient(server);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(addressfrom);
                mail.Subject = subject;
                mail.Body = body;
                mail.To.Add(addressfrom);

                /* //para adjuntar documentos dentro del mail
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(ruta);
                mail.Attachments.Add(attachment);
                */
    
                SmtpServer.Port = port;
                SmtpServer.Credentials = new System.Net.NetworkCredential(addressto, password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mensaje enviado!");
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: "+ex);
            }
        }
        private void enviar_Click(object sender, EventArgs e)
        {
            String mail = correo.Text;
            String subject = asunto.Text;
            String body = cuerpo.Text;
            enviarMail(mail, subject, body);

        }
    }
}

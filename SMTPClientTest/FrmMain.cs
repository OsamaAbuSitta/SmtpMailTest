using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace SMTPClientTest
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            try
            {
                if (FrmValidate())
                    SendEmail(txtServSMTP.Text, txtFrom.Text, txtTo.Text, txtSubject.Text, txtBody.Text, txtFrom.Text,
                        txtPassword.Text, checkBox1.Checked, int.Parse(txtPort.Text));

                txtLogList.Text = "Sent successfully ...";
            }
            catch (Exception ex)
            {
                txtLogList.Text = ex.Message;
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private bool FrmValidate()
        {
            return true;
        }

        private void LogList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void SendEmail(string smtpServer, string fromAddress, string toAddress, string subject, string body, string username, string password, bool enableSsl, int port)
        {
            // "smtp.gmail.com";
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(smtpServer);

            //"your_email_address@gmail.com"
            mail.From = new MailAddress(fromAddress);
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            SmtpServer.Port = port;
            SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
            SmtpServer.EnableSsl = enableSsl;

            SmtpServer.Send(mail);
        }

        private void smtpPublicTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Osama AbuSitta", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
namespace SMTPClientTest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtServSMTP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grEmail = new System.Windows.Forms.GroupBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLogList = new System.Windows.Forms.ListBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smtpPublicTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            this.grEmail.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.txtServSMTP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Smtp Server ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(260, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Enable SSL ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(92, 51);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(119, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "587";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(46, 54);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "SMTP Port";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Password";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 110);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(92, 76);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(253, 20);
            this.txtFrom.TabIndex = 4;
            this.txtFrom.Text = "sender@host.com";
            // 
            // txtServSMTP
            // 
            this.txtServSMTP.Location = new System.Drawing.Point(92, 25);
            this.txtServSMTP.Name = "txtServSMTP";
            this.txtServSMTP.Size = new System.Drawing.Size(253, 20);
            this.txtServSMTP.TabIndex = 1;
            this.txtServSMTP.Text = "smtp.your server.com";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "SMTP Server";
            // 
            // grEmail
            // 
            this.grEmail.Controls.Add(this.txtTo);
            this.grEmail.Controls.Add(this.label6);
            this.grEmail.Controls.Add(this.btnSend);
            this.grEmail.Controls.Add(this.txtBody);
            this.grEmail.Controls.Add(this.txtSubject);
            this.grEmail.Controls.Add(this.label5);
            this.grEmail.Controls.Add(this.label4);
            this.grEmail.Location = new System.Drawing.Point(13, 165);
            this.grEmail.Name = "grEmail";
            this.grEmail.Size = new System.Drawing.Size(351, 233);
            this.grEmail.TabIndex = 1;
            this.grEmail.TabStop = false;
            this.grEmail.Text = "Email";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(67, 21);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(278, 20);
            this.txtTo.TabIndex = 5;
            this.txtTo.Text = "addressTo@mail.com";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "To";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(238, 204);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 23);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(19, 91);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(326, 108);
            this.txtBody.TabIndex = 10;
            this.txtBody.Text = "your message";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(67, 47);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(278, 20);
            this.txtSubject.TabIndex = 9;
            this.txtSubject.Text = "subject mail";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 72);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Message";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLogList);
            this.groupBox2.Location = new System.Drawing.Point(13, 406);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 91);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log Report";
            // 
            // txtLogList
            // 
            this.txtLogList.Location = new System.Drawing.Point(19, 16);
            this.txtLogList.Name = "txtLogList";
            this.txtLogList.ScrollAlwaysVisible = true;
            this.txtLogList.Size = new System.Drawing.Size(326, 56);
            this.txtLogList.TabIndex = 9;
            this.txtLogList.SelectedIndexChanged += new System.EventHandler(this.LogList_SelectedIndexChanged);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smtpPublicTemplateToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.editToolStripMenuItem.Text = "Help";
            // 
            // smtpPublicTemplateToolStripMenuItem
            // 
            this.smtpPublicTemplateToolStripMenuItem.Name = "smtpPublicTemplateToolStripMenuItem";
            this.smtpPublicTemplateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smtpPublicTemplateToolStripMenuItem.Text = "About";
            this.smtpPublicTemplateToolStripMenuItem.Click += new System.EventHandler(this.smtpPublicTemplateToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Smtp Mail Client ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grEmail.ResumeLayout(false);
            this.grEmail.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtServSMTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grEmail;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox txtLogList;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smtpPublicTemplateToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
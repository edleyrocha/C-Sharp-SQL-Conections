namespace App_SQL_Conections
{
    partial class frmSQL_ServerA
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
            this.groupBox_SQL = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.richTextBox_Comentatatios = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSever = new System.Windows.Forms.TextBox();
            this.textBoxBanco = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelBanco = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btn__Authentication_ON_OFF = new System.Windows.Forms.Button();
            this.rb_Authentication_SQL_Server = new System.Windows.Forms.RadioButton();
            this.rb_Authentication_Windows = new System.Windows.Forms.RadioButton();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.groupBox_SQL.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_SQL
            // 
            this.groupBox_SQL.Controls.Add(this.panel3);
            this.groupBox_SQL.Controls.Add(this.panel2);
            this.groupBox_SQL.Controls.Add(this.panel1);
            this.groupBox_SQL.Location = new System.Drawing.Point(13, 13);
            this.groupBox_SQL.Name = "groupBox_SQL";
            this.groupBox_SQL.Size = new System.Drawing.Size(306, 374);
            this.groupBox_SQL.TabIndex = 0;
            this.groupBox_SQL.TabStop = false;
            this.groupBox_SQL.Text = "SQL Config Simples";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.richTextBox_Comentatatios);
            this.panel3.Location = new System.Drawing.Point(6, 250);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 111);
            this.panel3.TabIndex = 3;
            // 
            // richTextBox_Comentatatios
            // 
            this.richTextBox_Comentatatios.Location = new System.Drawing.Point(8, 9);
            this.richTextBox_Comentatatios.Name = "richTextBox_Comentatatios";
            this.richTextBox_Comentatatios.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_Comentatatios.Size = new System.Drawing.Size(278, 96);
            this.richTextBox_Comentatatios.TabIndex = 10;
            this.richTextBox_Comentatatios.Text = "############";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.textBoxSever);
            this.panel2.Controls.Add(this.textBoxBanco);
            this.panel2.Controls.Add(this.textBoxUser);
            this.panel2.Controls.Add(this.labelServer);
            this.panel2.Controls.Add(this.labelUser);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Controls.Add(this.labelBanco);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 119);
            this.panel2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(222, 88);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(63, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(104, 89);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(112, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.Text = "123456";
            // 
            // textBoxSever
            // 
            this.textBoxSever.Location = new System.Drawing.Point(104, 5);
            this.textBoxSever.Name = "textBoxSever";
            this.textBoxSever.Size = new System.Drawing.Size(181, 20);
            this.textBoxSever.TabIndex = 0;
            this.textBoxSever.Text = "192.168.1.1";
            // 
            // textBoxBanco
            // 
            this.textBoxBanco.Location = new System.Drawing.Point(104, 33);
            this.textBoxBanco.Name = "textBoxBanco";
            this.textBoxBanco.Size = new System.Drawing.Size(181, 20);
            this.textBoxBanco.TabIndex = 1;
            this.textBoxBanco.Text = "master";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(104, 61);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(181, 20);
            this.textBoxUser.TabIndex = 2;
            this.textBoxUser.Text = "sa";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(12, 4);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(85, 24);
            this.labelServer.TabIndex = 1;
            this.labelServer.Text = "Server...:";
            this.labelServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(3, 60);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(94, 24);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Usuario...:";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(12, 88);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(85, 24);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Senha...:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBanco
            // 
            this.labelBanco.AutoSize = true;
            this.labelBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBanco.Location = new System.Drawing.Point(13, 32);
            this.labelBanco.Name = "labelBanco";
            this.labelBanco.Size = new System.Drawing.Size(84, 24);
            this.labelBanco.TabIndex = 1;
            this.labelBanco.Text = "Banco...:";
            this.labelBanco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxTime);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnConectar);
            this.panel1.Controls.Add(this.btn__Authentication_ON_OFF);
            this.panel1.Controls.Add(this.rb_Authentication_SQL_Server);
            this.panel1.Controls.Add(this.rb_Authentication_Windows);
            this.panel1.Controls.Add(this.buttonStatus);
            this.panel1.Controls.Add(this.labelTimeOut);
            this.panel1.Location = new System.Drawing.Point(6, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 99);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(91, 68);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(109, 21);
            this.comboBoxTime.TabIndex = 10;
            this.comboBoxTime.Text = "999";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(206, 66);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(206, 39);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(79, 23);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btn__Authentication_ON_OFF
            // 
            this.btn__Authentication_ON_OFF.Location = new System.Drawing.Point(161, 12);
            this.btn__Authentication_ON_OFF.Name = "btn__Authentication_ON_OFF";
            this.btn__Authentication_ON_OFF.Size = new System.Drawing.Size(39, 50);
            this.btn__Authentication_ON_OFF.TabIndex = 7;
            this.btn__Authentication_ON_OFF.Text = "OFF";
            this.btn__Authentication_ON_OFF.UseVisualStyleBackColor = true;
            this.btn__Authentication_ON_OFF.Click += new System.EventHandler(this.btn__Authentication_ON_OFF_Click);
            // 
            // rb_Authentication_SQL_Server
            // 
            this.rb_Authentication_SQL_Server.AutoSize = true;
            this.rb_Authentication_SQL_Server.Checked = true;
            this.rb_Authentication_SQL_Server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Authentication_SQL_Server.Location = new System.Drawing.Point(4, 12);
            this.rb_Authentication_SQL_Server.Name = "rb_Authentication_SQL_Server";
            this.rb_Authentication_SQL_Server.Size = new System.Drawing.Size(151, 17);
            this.rb_Authentication_SQL_Server.TabIndex = 4;
            this.rb_Authentication_SQL_Server.TabStop = true;
            this.rb_Authentication_SQL_Server.Text = "SQL Server Authentication";
            this.rb_Authentication_SQL_Server.UseVisualStyleBackColor = true;
            // 
            // rb_Authentication_Windows
            // 
            this.rb_Authentication_Windows.AutoSize = true;
            this.rb_Authentication_Windows.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb_Authentication_Windows.Location = new System.Drawing.Point(4, 35);
            this.rb_Authentication_Windows.Name = "rb_Authentication_Windows";
            this.rb_Authentication_Windows.Size = new System.Drawing.Size(140, 17);
            this.rb_Authentication_Windows.TabIndex = 5;
            this.rb_Authentication_Windows.TabStop = true;
            this.rb_Authentication_Windows.Text = "Windows Authentication";
            this.rb_Authentication_Windows.UseVisualStyleBackColor = true;
            this.rb_Authentication_Windows.CheckedChanged += new System.EventHandler(this.rb_Authentication_Windows_CheckedChanged);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(206, 12);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(79, 23);
            this.buttonStatus.TabIndex = 7;
            this.buttonStatus.Text = "Status Atual";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.AutoSize = true;
            this.labelTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOut.Location = new System.Drawing.Point(5, 65);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(79, 24);
            this.labelTimeOut.TabIndex = 1;
            this.labelTimeOut.Text = "Timeout";
            this.labelTimeOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSQL_ServerA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 392);
            this.Controls.Add(this.groupBox_SQL);
            this.MaximizeBox = false;
            this.Name = "frmSQL_ServerA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Conection Modelo1";
            this.groupBox_SQL.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SQL;
        private System.Windows.Forms.RichTextBox richTextBox_Comentatatios;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelBanco;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxBanco;
        private System.Windows.Forms.TextBox textBoxSever;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.RadioButton rb_Authentication_Windows;
        private System.Windows.Forms.RadioButton rb_Authentication_SQL_Server;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTimeOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn__Authentication_ON_OFF;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.Button btnShow;
    }
}


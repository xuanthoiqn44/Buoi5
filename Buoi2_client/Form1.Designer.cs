namespace Buoi2_client
{
    partial class FormClient
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
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonsend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxclient = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonketnoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(519, 360);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 46);
            this.buttonexit.TabIndex = 7;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(438, 360);
            this.buttonsend.Name = "buttonsend";
            this.buttonsend.Size = new System.Drawing.Size(75, 46);
            this.buttonsend.TabIndex = 6;
            this.buttonsend.Text = "Send";
            this.buttonsend.UseVisualStyleBackColor = true;
            this.buttonsend.Click += new System.EventHandler(this.buttonsend_Click);
            this.buttonsend.Enter += new System.EventHandler(this.buttonsend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 360);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 46);
            this.textBox1.TabIndex = 5;
            // 
            // listBoxclient
            // 
            this.listBoxclient.FormattingEnabled = true;
            this.listBoxclient.Location = new System.Drawing.Point(3, 59);
            this.listBoxclient.Name = "listBoxclient";
            this.listBoxclient.Size = new System.Drawing.Size(590, 277);
            this.listBoxclient.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Client IP";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 20);
            this.textBox2.TabIndex = 9;
            // 
            // buttonketnoi
            // 
            this.buttonketnoi.Location = new System.Drawing.Point(338, 23);
            this.buttonketnoi.Name = "buttonketnoi";
            this.buttonketnoi.Size = new System.Drawing.Size(75, 23);
            this.buttonketnoi.TabIndex = 10;
            this.buttonketnoi.Text = "Ket noi";
            this.buttonketnoi.UseVisualStyleBackColor = true;
            this.buttonketnoi.Click += new System.EventHandler(this.buttonketnoi_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 411);
            this.Controls.Add(this.buttonketnoi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxclient);
            this.Name = "FormClient";
            this.Text = "CLient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonketnoi;
    }
}


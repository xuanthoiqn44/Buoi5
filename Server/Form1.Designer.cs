namespace Server
{
    partial class FormServer
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
            this.listBoxserver = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonexit
            // 
            this.buttonexit.Location = new System.Drawing.Point(519, 313);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(75, 46);
            this.buttonexit.TabIndex = 7;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonsend
            // 
            this.buttonsend.Location = new System.Drawing.Point(438, 313);
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
            this.textBox1.Location = new System.Drawing.Point(3, 313);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 46);
            this.textBox1.TabIndex = 5;
            // 
            // listBoxserver
            // 
            this.listBoxserver.FormattingEnabled = true;
            this.listBoxserver.Location = new System.Drawing.Point(3, 12);
            this.listBoxserver.Name = "listBoxserver";
            this.listBoxserver.Size = new System.Drawing.Size(590, 277);
            this.listBoxserver.TabIndex = 4;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 372);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonsend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxserver);
            this.Name = "FormServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonsend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxserver;
    }
}


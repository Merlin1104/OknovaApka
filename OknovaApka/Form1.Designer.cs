namespace OknovaApka
{
    partial class MainForm
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
            this.tbChat = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bSend2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbChat
            // 
            this.tbChat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbChat.Location = new System.Drawing.Point(13, 13);
            this.tbChat.Multiline = true;
            this.tbChat.Name = "tbChat";
            this.tbChat.ReadOnly = true;
            this.tbChat.Size = new System.Drawing.Size(259, 210);
            this.tbChat.TabIndex = 0;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 229);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(260, 20);
            this.tbMessage.TabIndex = 1;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(278, 200);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(75, 23);
            this.bSend.TabIndex = 2;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bSend2
            // 
            this.bSend2.Location = new System.Drawing.Point(278, 227);
            this.bSend2.Name = "bSend2";
            this.bSend2.Size = new System.Drawing.Size(75, 23);
            this.bSend2.TabIndex = 3;
            this.bSend2.Text = "Send2";
            this.bSend2.UseVisualStyleBackColor = true;
            this.bSend2.Click += new System.EventHandler(this.bSend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.bSend2);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbChat);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChat;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bSend2;
    }
}


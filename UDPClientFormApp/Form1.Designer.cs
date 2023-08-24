namespace UDPClientFormApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCreateClint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Port";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(125, 14);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(187, 22);
            this.txtServerPort.TabIndex = 1;
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(125, 55);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(187, 22);
            this.txtClientPort.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Port";
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(125, 95);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(187, 22);
            this.txtHostName.TabIndex = 5;
            this.txtHostName.Text = "localhost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Host Name";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(16, 137);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(296, 108);
            this.txtLog.TabIndex = 6;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(16, 261);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(296, 29);
            this.txtMsg.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(212, 296);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 32);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCreateClint
            // 
            this.btnCreateClint.Location = new System.Drawing.Point(16, 296);
            this.btnCreateClint.Name = "btnCreateClint";
            this.btnCreateClint.Size = new System.Drawing.Size(118, 32);
            this.btnCreateClint.TabIndex = 9;
            this.btnCreateClint.Text = "Create Client";
            this.btnCreateClint.UseVisualStyleBackColor = true;
            this.btnCreateClint.Click += new System.EventHandler(this.btnCreateClint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 335);
            this.Controls.Add(this.btnCreateClint);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCreateClint;
    }
}


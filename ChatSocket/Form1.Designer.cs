namespace ChatSocket
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortText = new System.Windows.Forms.NumericUpDown();
            this.IPText = new System.Windows.Forms.MaskedTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbAllMsg = new System.Windows.Forms.TextBox();
            this.tbMsgText = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortText)).BeginInit();
            this.SuspendLayout();
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(145, 27);
            this.PortText.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(68, 20);
            this.PortText.TabIndex = 1;
            this.PortText.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // IPText
            // 
            this.IPText.Culture = new System.Globalization.CultureInfo("en-GB");
            this.IPText.Location = new System.Drawing.Point(13, 27);
            this.IPText.Mask = "###.###.###.###";
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(107, 20);
            this.IPText.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(236, 27);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Подключить";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbAllMsg
            // 
            this.tbAllMsg.Location = new System.Drawing.Point(13, 97);
            this.tbAllMsg.Multiline = true;
            this.tbAllMsg.Name = "tbAllMsg";
            this.tbAllMsg.Size = new System.Drawing.Size(408, 420);
            this.tbAllMsg.TabIndex = 4;
            // 
            // tbMsgText
            // 
            this.tbMsgText.Location = new System.Drawing.Point(13, 539);
            this.tbMsgText.Name = "tbMsgText";
            this.tbMsgText.Size = new System.Drawing.Size(408, 20);
            this.tbMsgText.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(454, 539);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 638);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMsgText);
            this.Controls.Add(this.tbAllMsg);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.PortText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PortText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown PortText;
        private System.Windows.Forms.MaskedTextBox IPText;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbAllMsg;
        private System.Windows.Forms.TextBox tbMsgText;
        private System.Windows.Forms.Button btnSend;
    }
}


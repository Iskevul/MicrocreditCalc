
namespace AddTariff
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
            this.Cancel = new System.Windows.Forms.Button();
            this.TRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TTimeAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TTimeType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TMaxSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TMinSum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(214, 296);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(128, 23);
            this.Cancel.TabIndex = 27;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // TRate
            // 
            this.TRate.Location = new System.Drawing.Point(170, 245);
            this.TRate.Name = "TRate";
            this.TRate.Size = new System.Drawing.Size(172, 22);
            this.TRate.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Rate";
            // 
            // TTimeAmount
            // 
            this.TTimeAmount.Location = new System.Drawing.Point(170, 204);
            this.TTimeAmount.Name = "TTimeAmount";
            this.TTimeAmount.Size = new System.Drawing.Size(172, 22);
            this.TTimeAmount.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "TimeAmount";
            // 
            // TTimeType
            // 
            this.TTimeType.FormattingEnabled = true;
            this.TTimeType.Location = new System.Drawing.Point(170, 162);
            this.TTimeType.Name = "TTimeType";
            this.TTimeType.Size = new System.Drawing.Size(172, 24);
            this.TTimeType.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "TimeType";
            // 
            // TMaxSum
            // 
            this.TMaxSum.Location = new System.Drawing.Point(170, 126);
            this.TMaxSum.Name = "TMaxSum";
            this.TMaxSum.Size = new System.Drawing.Size(172, 22);
            this.TMaxSum.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "MaxSum";
            // 
            // TMinSum
            // 
            this.TMinSum.Location = new System.Drawing.Point(170, 87);
            this.TMinSum.Name = "TMinSum";
            this.TMinSum.Size = new System.Drawing.Size(172, 22);
            this.TMinSum.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "MinSum";
            // 
            // Send
            // 
            this.Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Send.Location = new System.Drawing.Point(51, 296);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(130, 23);
            this.Send.TabIndex = 16;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(170, 51);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(172, 22);
            this.TName.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 377);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TTimeAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TTimeType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TMaxSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TMinSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox TRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TTimeAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TTimeType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TMaxSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TMinSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TName;
    }
}


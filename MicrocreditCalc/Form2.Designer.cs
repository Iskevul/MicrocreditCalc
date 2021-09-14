
namespace MicrocreditCalc
{
    partial class Form2
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
            this.TName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TMinSum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TMaxSum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TTimeType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TTimeAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TRate = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(142, 31);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(172, 22);
            this.TName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Send
            // 
            this.Send.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Send.Location = new System.Drawing.Point(52, 276);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(100, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "MinSum";
            // 
            // TMinSum
            // 
            this.TMinSum.Location = new System.Drawing.Point(142, 67);
            this.TMinSum.Name = "TMinSum";
            this.TMinSum.Size = new System.Drawing.Size(172, 22);
            this.TMinSum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MaxSum";
            // 
            // TMaxSum
            // 
            this.TMaxSum.Location = new System.Drawing.Point(142, 106);
            this.TMaxSum.Name = "TMaxSum";
            this.TMaxSum.Size = new System.Drawing.Size(172, 22);
            this.TMaxSum.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "TimeType";
            // 
            // TTimeType
            // 
            this.TTimeType.FormattingEnabled = true;
            this.TTimeType.Location = new System.Drawing.Point(142, 142);
            this.TTimeType.Name = "TTimeType";
            this.TTimeType.Size = new System.Drawing.Size(172, 24);
            this.TTimeType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "TimeAmount";
            // 
            // TTimeAmount
            // 
            this.TTimeAmount.Location = new System.Drawing.Point(142, 184);
            this.TTimeAmount.Name = "TTimeAmount";
            this.TTimeAmount.Size = new System.Drawing.Size(172, 22);
            this.TTimeAmount.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rate";
            // 
            // TRate
            // 
            this.TRate.Location = new System.Drawing.Point(142, 225);
            this.TRate.Name = "TRate";
            this.TRate.Size = new System.Drawing.Size(172, 22);
            this.TRate.TabIndex = 12;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(181, 276);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 331);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TMinSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TMaxSum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TTimeType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TTimeAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TRate;
        private System.Windows.Forms.Button Cancel;
    }
}
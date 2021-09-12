
namespace MicrocreditCalc
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
            this.chooseDays = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.choosedTariff = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TariffName = new System.Windows.Forms.Label();
            this.DueDay = new System.Windows.Forms.Label();
            this.AmountToPay = new System.Windows.Forms.Label();
            this.CountButton = new System.Windows.Forms.Button();
            this.Epb = new System.Windows.Forms.Label();
            this.Overpay = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumulatively = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseDays
            // 
            this.chooseDays.Location = new System.Drawing.Point(171, 92);
            this.chooseDays.Margin = new System.Windows.Forms.Padding(2);
            this.chooseDays.Name = "chooseDays";
            this.chooseDays.Size = new System.Drawing.Size(146, 22);
            this.chooseDays.TabIndex = 19;
            this.chooseDays.TextChanged += new System.EventHandler(this.chooseDays_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 22);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 285);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Overpayment amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Effective interest rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Amount to pay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tariff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Due day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numbers of days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Credit amount";
            // 
            // choosedTariff
            // 
            this.choosedTariff.FormattingEnabled = true;
            this.choosedTariff.Location = new System.Drawing.Point(171, 33);
            this.choosedTariff.Name = "choosedTariff";
            this.choosedTariff.Size = new System.Drawing.Size(146, 24);
            this.choosedTariff.TabIndex = 20;
            this.choosedTariff.SelectedIndexChanged += new System.EventHandler(this.choosedTariff_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Choose tariff";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // TariffName
            // 
            this.TariffName.AutoSize = true;
            this.TariffName.Location = new System.Drawing.Point(174, 220);
            this.TariffName.Name = "TariffName";
            this.TariffName.Size = new System.Drawing.Size(0, 17);
            this.TariffName.TabIndex = 22;
            // 
            // DueDay
            // 
            this.DueDay.AutoSize = true;
            this.DueDay.Location = new System.Drawing.Point(174, 237);
            this.DueDay.Name = "DueDay";
            this.DueDay.Size = new System.Drawing.Size(0, 17);
            this.DueDay.TabIndex = 23;
            // 
            // AmountToPay
            // 
            this.AmountToPay.AutoSize = true;
            this.AmountToPay.Location = new System.Drawing.Point(173, 253);
            this.AmountToPay.Name = "AmountToPay";
            this.AmountToPay.Size = new System.Drawing.Size(0, 17);
            this.AmountToPay.TabIndex = 24;
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(171, 159);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(146, 23);
            this.CountButton.TabIndex = 25;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // Epb
            // 
            this.Epb.AutoSize = true;
            this.Epb.Location = new System.Drawing.Point(180, 269);
            this.Epb.Name = "Epb";
            this.Epb.Size = new System.Drawing.Size(0, 17);
            this.Epb.TabIndex = 26;
            // 
            // Overpay
            // 
            this.Overpay.AutoSize = true;
            this.Overpay.Location = new System.Drawing.Point(177, 285);
            this.Overpay.Name = "Overpay";
            this.Overpay.Size = new System.Drawing.Size(0, 17);
            this.Overpay.TabIndex = 27;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(171, 322);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(146, 23);
            this.Refresh.TabIndex = 28;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.Percent,
            this.Cumulatively,
            this.Summ});
            this.dataGridView1.Location = new System.Drawing.Point(351, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(796, 312);
            this.dataGridView1.TabIndex = 29;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 6;
            this.Day.Name = "Day";
            this.Day.Width = 125;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "Percent";
            this.Percent.MinimumWidth = 6;
            this.Percent.Name = "Percent";
            this.Percent.Width = 125;
            // 
            // Cumulatively
            // 
            this.Cumulatively.HeaderText = "Cumulatively";
            this.Cumulatively.MinimumWidth = 6;
            this.Cumulatively.Name = "Cumulatively";
            this.Cumulatively.Width = 125;
            // 
            // Summ
            // 
            this.Summ.HeaderText = "Summ";
            this.Summ.MinimumWidth = 6;
            this.Summ.Name = "Summ";
            this.Summ.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 416);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Overpay);
            this.Controls.Add(this.Epb);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.AmountToPay);
            this.Controls.Add(this.DueDay);
            this.Controls.Add(this.TariffName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.choosedTariff);
            this.Controls.Add(this.chooseDays);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chooseDays;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox choosedTariff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TariffName;
        private System.Windows.Forms.Label DueDay;
        private System.Windows.Forms.Label AmountToPay;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label Epb;
        private System.Windows.Forms.Label Overpay;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumulatively;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summ;
    }
}


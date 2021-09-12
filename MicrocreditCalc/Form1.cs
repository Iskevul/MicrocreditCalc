using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrocreditCalc
{
    public partial class Form1 : Form
    {

        public int sum;
        public int pdays;
        public string tariff;
        public double fullCost;
        public double overpayment;
        public double effectivePercentBet;

        
        public Form1()
        {
            InitializeComponent();

            choosedTariff.Items.Add("oneWeek");
            choosedTariff.Items.Add("oneMonth");
            choosedTariff.Items.Add("free");

            dataGridView1.AllowUserToAddRows = false;

        }

        public void Check(Tariff t, int sum)
        {
            string tariffBox = choosedTariff.Text;
            if (t.minSum > sum || t.maxSum < sum)
            {
                Refr();
                choosedTariff.Text = tariffBox;
                if (choosedTariff.Text != "free")
                    chooseDays.Enabled = false;
                TariffName.Text = tariffBox;
                MessageBox.Show($"Введите сумму в диапозоне от {t.minSum} до {t.maxSum}");
            }
        }

        public void FillGrid(Tariff t)
        {
            double fullPerc = 0;
            double daySum = 0;
            double fullSum = 0;
            for (int i = 1; i <= t.days; i++)
            {
                fullPerc += t.percents[i];
                daySum += sum * t.percents[i];
                fullSum = sum + daySum;
        
                dataGridView1.Rows.Add();
                dataGridView1["Day", dataGridView1.Rows.Count - 1].Value = i;
                dataGridView1["Percent", dataGridView1.Rows.Count - 1].Value = t.percents[i] + " %";
                dataGridView1["Cumulatively", dataGridView1.Rows.Count - 1].Value = daySum;
                dataGridView1["Summ", dataGridView1.Rows.Count - 1].Value = fullSum;
        
            }
        }

        static double CountFullCost(int sum, int days, Dictionary<int, double> percents)
        {
            double cost = sum;
            for (int i = 1; i <= days; i++)
            {
                cost += sum * percents[i];
            }
            return cost;
        }

        static double PercentSum(double sum, double fullCost)
        {
            double overpayment = fullCost - sum;
            return overpayment;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void choosedTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            TariffName.Text = choosedTariff.Text;
            if (choosedTariff.Text != "free")
                chooseDays.Enabled = false;
        }

        private void chooseDays_TextChanged(object sender, EventArgs e)
        {
            DueDay.Text = chooseDays.Text;
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            sum = Convert.ToInt32(textBox1.Text);
            tariff = choosedTariff.Text;
            if (tariff == "free")
            {
                pdays = Convert.ToInt32(chooseDays.Text);
            }
                

            double plus = 0;

            if (tariff == "oneWeek")
            {
                Tariff oneWeek = new Tariff(1000, 10000, 7);
                for (int i = 1; i <= 7; i++)
                {
                    oneWeek.percents.Add(i, plus);
                    plus += 0.02;
                }

                pdays = 7;
                DueDay.Text = "7";
                fullCost = CountFullCost(sum, pdays, oneWeek.percents);
                effectivePercentBet = overpayment / sum / pdays;
                overpayment = PercentSum(sum, fullCost);
                
                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));

                FillGrid(oneWeek);

                Check(oneWeek, sum);
            }
            else if (tariff == "oneMonth")
            {
                Tariff oneMonth = new Tariff(5000, 50000, 30);
                for (int i = 1; i <= 30; i++)
                {
                    if (1 <= i && i <= 10)
                    {
                        oneMonth.percents.Add(i, 0.005);
                    }
                    if (11 <= i && i <= 20)
                    {
                        oneMonth.percents.Add(i, 0.006);
                    }
                    if (21 <= i && i <= 30)
                    {
                        oneMonth.percents.Add(i, 0.007);
                    }
                }

                pdays = 30;
                DueDay.Text = "30";
                fullCost = CountFullCost(sum, pdays, oneMonth.percents);
                overpayment = PercentSum(sum, fullCost);
                effectivePercentBet = overpayment / sum / pdays;

                FillGrid(oneMonth);

                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));

                Check(oneMonth, sum);
            }
            else if (tariff == "free")
            {
                Tariff free = new Tariff(0, 500000, pdays);
                if (pdays > 0)
                {
                    plus = 0;
                    for (int i = 1; i <= pdays; i++)
                    {
                        plus += 0.05;
                        if (plus > 1)
                        {
                            plus = 1;
                        }
                        free.percents.Add(i, plus);
                    }
                }

                pdays = Convert.ToInt32(chooseDays.Text);
                fullCost = CountFullCost(sum, pdays, free.percents);
                overpayment = PercentSum(sum, fullCost);
                effectivePercentBet = overpayment / sum / pdays;

                FillGrid(free);

                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));

                Check(free, sum);
            }


        }

        public void Refr()
        {
            sum = 0;
            pdays = 0;
            tariff = "";
            fullCost = 0;
            overpayment = 0;
            effectivePercentBet = 0;
            AmountToPay.Text = null;
            Epb.Text = null;
            Overpay.Text = null;
            choosedTariff.Text = "";
            chooseDays.Text = "";
            textBox1.Text = "";
            TariffName.Text = "";
            DueDay.Text = "";
            chooseDays.Enabled = true;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refr();
        }

    }

    public class Tariff
    {
        public int minSum;
        public int maxSum;
        public int days;
        public Dictionary<int, double> percents = new Dictionary<int, double>();

        public Tariff(int x, int y, int z) { minSum = x; maxSum = y; days = z; }
        public Tariff(int z) { days = z; }
    }
}

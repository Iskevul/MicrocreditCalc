using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MicrocreditCalc
{
    public partial class Form1 : Form
    {
        public string serialized;
        public int sum;
        public int pdays;
        public string tariff;
        public double fullCost;
        public double overpayment;
        public double effectivePercentBet;
        public Tariff oneWeek  = new Tariff("oneWeek", 1000, 10000, 7);
        public Tariff oneMonth = new Tariff("oneMonth", 5000, 50000, 30);
        public TariffDeveloper fabric = new TariffDeveloper();
        public List<Tariff> tariffBox = new List<Tariff>();
        public List<Tariff> tars = new List<Tariff>();

        //public Tariffs






        public Form1()
        {
            InitializeComponent();


            choosedTariff.Items.Add("oneWeek");
            choosedTariff.Items.Add("oneMonth");
            choosedTariff.Items.Add("free");

            dataGridView1.AllowUserToAddRows = false;
            //dataGridView2.AllowUserToAddRows = false;
            LoadData();

            //foreach (var tar in tars)
            //{
            //    dataGridView2.Rows.Add();
            //    dataGridView2["Nname", dataGridView1.Rows.Count].Value = tar.name;
            //    dataGridView2["MinSum", dataGridView1.Rows.Count].Value = tar.minSum;
            //    dataGridView2["MaxSum", dataGridView1.Rows.Count].Value = tar.maxSum;
            //    dataGridView2["TimeType", dataGridView1.Rows.Count].Value = tar.timeType;
            //    dataGridView2["TimeAmount", dataGridView1.Rows.Count].Value = tar.numberOfTimeUnits;
            //    dataGridView2["Rate", dataGridView1.Rows.Count].Value = tar.rate;
            //    MessageBox.Show(tar.name);
            //}

            //tariffsBox.Tariffs = new Tariff[100];

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
            double fullSum = sum;
            for (int i = 1; i <= t.days; i++)
            {
                fullPerc += t.percents[i];
                daySum += sum * t.percents[i] / 100;
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
                cost += sum * percents[i] / 100;
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
                for (int i = 1; i <= 7; i++)
                {
                    oneWeek.percents.Add(i, plus);
                    plus += 0.15;
                }

                pdays = 7;
                DueDay.Text = "7";
                fullCost = CountFullCost(sum, pdays, oneWeek.percents);
                overpayment = PercentSum(sum, fullCost);
                effectivePercentBet = overpayment / sum / pdays;
                
                
                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));

                FillGrid(oneWeek);

                Check(oneWeek, sum);
            }
            else if (tariff == "oneMonth")
            {
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
                Tariff free = new Tariff("free", 0, 500000, pdays);
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
            else 
            {
                foreach (var tar in tars)
                {
                    if (tariff == tar.name)
                    {
                        OnTariff(tar);
                    }
                }
            }
        }
        //Дописать
        public void OnTariff(Tariff t)
        {
            

            FillGrid(t);
            if (t.timeType == "day")
            {
                fullCost = CountFullCost(sum, t.numberOfTimeUnits, t.percents);
                overpayment = PercentSum(sum, fullCost);
                effectivePercentBet = overpayment / sum / t.numberOfTimeUnits;

                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));
                DueDay.Text = Convert.ToString(t.numberOfTimeUnits);
                
            }
            else if (t.timeType == "week")
            {
                fullCost = CountFullCost(sum, t.numberOfTimeUnits * 7, t.percents);
                overpayment = PercentSum(sum, fullCost);
                effectivePercentBet = overpayment / sum / t.numberOfTimeUnits;

                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));
                DueDay.Text = Convert.ToString(t.numberOfTimeUnits * 7);

            }
            else if (t.timeType == "month")
            {
                fullCost = CountFullCost(sum, t.numberOfTimeUnits * 30, t.percents);
                overpayment = PercentSum(sum, fullCost);
                effectivePercentBet = overpayment / sum / t.numberOfTimeUnits;

                AmountToPay.Text = Convert.ToString(Math.Round(fullCost, 2));
                Epb.Text = Convert.ToString(Math.Round(effectivePercentBet * 100, 2) + "%");
                Overpay.Text = Convert.ToString(Math.Round(overpayment, 2));
                DueDay.Text = Convert.ToString(t.numberOfTimeUnits * 30);

            }
        }

        

        public void SaveData(Tariff t)
        {
            tariffBox.Add(t);
            choosedTariff.Items.Add(t.name);
            serialized = JsonConvert.SerializeObject(tariffBox);
            File.WriteAllText(@"C:\Users\User\Source\Repos\MicrocreditCalc7\MicrocreditCalc\Resources\db1.json", string.Empty);

            if (!File.Exists(@"C:\Users\User\Source\Repos\MicrocreditCalc7\MicrocreditCalc\Resources\db1.json"))
                File.Create(@"C:\Users\User\Source\Repos\MicrocreditCalc7\MicrocreditCalc\Resources\db1.json").Close();
            File.AppendAllText(@"C:\Users\User\Source\Repos\MicrocreditCalc7\MicrocreditCalc\Resources\db1.json", serialized); 
        }

        public void LoadData()
        {
            var jsonString = File.ReadAllText(@"C:\Users\User\Source\Repos\MicrocreditCalc7\MicrocreditCalc\Resources\db1.json");
            tars = JsonConvert.DeserializeObject<List<Tariff>>(jsonString);
            if (tars != null)
            {
                foreach (var tar in tars)
                {
                    tariffBox.Add(tar);
                    choosedTariff.Items.Add(tar.name);
                }
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
            //dataGridView2.Rows.Clear();
            //dataGridView2.Refresh();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Refr();
        }

        private void AddTariff_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                string nameBox = frm.nameBox;
                int minSumBox = Convert.ToInt32(frm.minSumBox);
                int maxSumBox = Convert.ToInt32(frm.maxSumBox);
                string timeTypeBox = frm.timeTypeBox;
                int timeAmountBox = Convert.ToInt32(frm.timeAmountBox);
                string[] rateBox = frm.rateBox.Split(' ');
                double[] rateDouble = new double[rateBox.Length];
                for (int i = 0; i < rateBox.Length; i++)
                {
                    rateDouble[i] = double.Parse(rateBox[i], formatter);
                }
                Tariff NewT = fabric.CreateTariff(nameBox, minSumBox, maxSumBox, timeTypeBox, timeAmountBox, rateDouble);
                choosedTariff.Items.Add(nameBox);
                SaveData(NewT);
                LoadData();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    public class Data
    {
        public Tariff[] Tariffs { get; set; }
    }

    public class Tariff
    {
        public string name { get; set; }
        public int minSum { get; set; }
        public int maxSum { get; set; }
        public int days { get; set; }
        public string timeType { get; set; }
        public int numberOfTimeUnits { get; set; }
        public double[] rate { get; set; }

        public Dictionary<int, double> percents { get; set; }

        public Tariff(string name, int y) { this.name = name; days = y; percents = new Dictionary<int, double>(); }
        public Tariff(string name, int x, int y, int z) { this.name = name; minSum = x; maxSum = y; days = z; percents = new Dictionary<int, double>(); }
        [JsonConstructor]
        public Tariff(string name, int minSum, int maxSum, string timeType, int numberOfTimeUnits, double[] rate)
        {
            this.name = name;
            this.minSum = minSum;
            this.maxSum = maxSum;
            this.timeType = timeType;
            this.numberOfTimeUnits = numberOfTimeUnits;
            this.rate = rate;
            percents = new Dictionary<int, double>();

            int count = 0;

            if (this.timeType == "day")
            {
                for (int i = 1; i <= this.numberOfTimeUnits; i++)
                {
                    this.percents.Add(i, this.rate[i - 1]);
                }
                this.days = this.numberOfTimeUnits;
            }
            else if (this.timeType == "week")
            {
                count = 0;
                for (int i = 1; i <= this.numberOfTimeUnits; i++)
                {
                    for (int j = 1; j <= 7; j++)
                    {
                        count += 1;
                        this.percents.Add(count, this.rate[i - 1]);
                    }
                }
                this.days = this.numberOfTimeUnits * 7;
            }
            else if (this.timeType == "month")
            {
                count = 0;
                for (int i = 1; i <= this.numberOfTimeUnits; i++)
                {
                    for (int j = 1; j <= 30; j++)
                    {
                        count += 1;
                        this.percents.Add(count, this.rate[i - 1]);
                    }
                }
                this.days = this.numberOfTimeUnits * 30;
            }
        }
    }

    public class TariffDeveloper
    {
        public Tariff CreateTariff(string name, int minSum, int maxSum, string timeType, int numberOfTimeUnits, double[] rate)
        {
            return new Tariff(name, minSum, maxSum, timeType, numberOfTimeUnits, rate);
        }
    }
}

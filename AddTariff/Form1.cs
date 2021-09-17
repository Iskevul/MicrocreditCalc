using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AddTariff
{
    public partial class Form1 : Form
    {
        public List<Tariff> tariffBox;
        public TariffDeveloper fabric = new TariffDeveloper();

        public Form1()
        {
            InitializeComponent();
            TTimeType.Items.Add("day");
            TTimeType.Items.Add("week");
            TTimeType.Items.Add("month");
        }

        private void Send_Click(object sender, EventArgs e)
        {
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
            string nameBox = TName.Text;
            int minSumBox = Convert.ToInt32(TMinSum.Text);
            int maxSumBox = Convert.ToInt32(TMaxSum.Text);
            string timeTypeBox = TTimeType.Text;
            int timeAmountBox = Convert.ToInt32(TTimeAmount.Text);
            string[] rateBox = TRate.Text.Split(' ');
            double[] rateDouble = new double[rateBox.Length];
            for (int i = 0; i < rateBox.Length; i++)
            {
                rateDouble[i] = double.Parse(rateBox[i], formatter);
            }
            Tariff NewT = fabric.CreateTariff(nameBox, minSumBox, maxSumBox, timeTypeBox, timeAmountBox, rateDouble);
            //choosedTariff.Items.Add(nameBox);
            SaveData(NewT);
            Refr();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Refr();
        }

        public void Refr()
        {
            TName.Text = "";
            TMinSum.Text = "";
            TMaxSum.Text = "";
            TTimeType.Text = "";
            TTimeAmount.Text = "";
            TRate.Text = "";
        }

        public void SaveData(Tariff t)
        {
            //choosedTariff.Items.Add(t.name);

            if (File.Exists(@"..\..\..\packages\db1.json"))
            {
                var jsonString = File.ReadAllText(@"..\..\..\packages\db1.json");
                tariffBox = JsonConvert.DeserializeObject<List<Tariff>>(jsonString);
            }

            tariffBox.Add(t);


            string serialized;
            serialized = JsonConvert.SerializeObject(tariffBox);
            File.WriteAllText(@"..\..\..\packages\db1.json", string.Empty);

            if (!File.Exists(@"..\..\..\packages\db1.json"))
                File.Create(@"..\..\..\packages\db1.json").Close();
            File.AppendAllText(@"..\..\..\packages\db1.json", serialized);
        }

        public class TariffDeveloper
        {
            public Tariff CreateTariff(string name, int minSum, int maxSum, string timeType, int numberOfTimeUnits, double[] rate)
            {
                return new Tariff(name, minSum, maxSum, timeType, numberOfTimeUnits, rate);
            }
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
    }
}

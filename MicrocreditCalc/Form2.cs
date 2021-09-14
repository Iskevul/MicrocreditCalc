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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TTimeType.Items.Add("day");
            TTimeType.Items.Add("week");
            TTimeType.Items.Add("month");
        }

        public string nameBox { get; set; }
        public string minSumBox { get; set; }
        public string maxSumBox { get; set; }
        public string timeTypeBox { get; set; }
        public string timeAmountBox { get; set; }
        public string rateBox { get; set; }

        private void Send_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            nameBox = TName.Text;
            minSumBox = TMinSum.Text;
            maxSumBox = TMaxSum.Text;
            timeTypeBox = TTimeType.Text;
            timeAmountBox = TTimeAmount.Text;
            rateBox = TRate.Text;
            Close();
        }
    }
}

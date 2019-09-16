using System;
using System.Windows.Forms;

namespace DepositCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            decimal sl = salaryLevel.Value;
            decimal dc = depositCurrent.Value;
            decimal sp = salaryPercent.Value;
            decimal dp = depositPercent.Value;
            decimal mc = monthsCount.Value;

            decimal dr = dc;
            decimal pr = dc * ((dp / 100) / 12);

            for(int i = 0; i < mc; i++)
            {
                dr = dr + (dr * ((dp / 100) / 12)) + (sl * (sp / 100));
                pr = dr * ((dp / 100) / 12);
            }

            depositResult.Value = dr;
            percentResult.Value = pr;
        }
    }
}

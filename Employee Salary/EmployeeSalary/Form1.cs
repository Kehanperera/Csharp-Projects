using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double medal, al, epfetf, basesal, tot = 0, net = 0;
            basesal = Convert.ToDouble(Basic_salary.Text);
            al = Convert.ToDouble( Allowance.Text);
            medal = Convert.ToDouble( Med_Allowance.Text);

            epfetf = basesal - (0.13*basesal);

            tot = basesal + medal + al;
             net = epfetf + medal + al - (0.05*tot);
            Total.Text = tot.ToString();

            Net_Total.Text = net.ToString();
            


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELECTRIRICTY_BILL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double Unit, tot, eu, ec;
            Unit = Convert.ToDouble(Units.Text);

            if (Com_Type.SelectedIndex == 0)
            {
                if (Unit <= 100)
                {
                    tot = 500 + 200;
                    Total.Text = tot.ToString();
                }

                else if (Unit > 100)
                {
                    eu = Unit - 100;
                    ec = eu * 20;
                    tot = 500 + 200 + ec;
                    Total.Text = tot.ToString();
                    
                }

            }
             else if (Com_Type.SelectedIndex == 1)
                if (Unit <= 100)
                {
                    tot = 800 + 600;
                    Total.Text = tot.ToString();

                }
                else if (Unit > 100)
                {
                    eu = Unit - 100;
                    ec = eu * 50;
                    tot = 800 + 600 + ec;
                    Total.Text = tot.ToString();

                }


        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Units.Clear();
            Total.Clear();  
            
        }

        private void btn_ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

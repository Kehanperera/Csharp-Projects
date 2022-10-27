using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog_bill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            double day, Night, tot=0, grandtot;
            day = Convert.ToDouble(day_txt.Text);
            Night = Convert.ToDouble(night_txt.Text);
            if (com_type.SelectedIndex == 0)
            {
                if (day <= 50 & Night <= 10)
                    tot = 400 + 200 + 200;

                else if (day > 50 & Night <= 10)
                    tot = ((day - 50) * 10) + 400 + 200 + 200;

                else if (day <= 50 & Night > 10)
                    tot = ((Night - 10) * 20) + 200 + 200 + 400;

                else if (day > 50 & Night > 10)
                    tot = ((day - 50) * 10) + ((Night - 10) * 20) + 400 + 200 + 200;

                if (tot <= 1000)
                    grandtot = tot + 250;
                else
                    grandtot = tot + 350;
                Total.Text = grandtot.ToString();
                
            }
            else if (com_type.SelectedIndex == 1)
            {
                if (day <= 10 & Night <= 100)
                    tot = 200 + 600 + 400;
                else if (day > 10 & Night <= 100)
                    tot = ((day - 10) * 20) + 200 + 600 + 400;
                else if (day <= 10 & Night > 100)
                    tot = ((Night - 100) * 10) + 200 + 600 + 400;
                else if (day >= 10 & Night > 100)
                    tot=((day - 10) * 20) + ((Night - 100) * 10) + 200 + 600 + 400;

                if (tot <= 1500)
                    grandtot = tot + 350;
                else
                    grandtot = tot + 450;
                Total.Text = grandtot.ToString();


            }


        }
    }
}

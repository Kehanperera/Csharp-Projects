using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registr_form
{
    public partial class Registration_form : Form
    {
        public Registration_form()
        {
            InitializeComponent();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text.Length == 0 || txt_fname.Text.Any(char.IsDigit))
                MessageBox.Show("First Name cannot be left blank or cannot have any numbers or characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_lname.Text.Length == 0 || txt_lname.Text.Any(char.IsDigit))
                MessageBox.Show("Last Name cannot be left blank or cannot have any numbers or characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_address.Text.Length == 0)

                MessageBox.Show("Address Cannot Be Left Blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (Convert.ToInt32(txt_age.Text) < 18 || Convert.ToInt32(txt_age.Text) < 60)
                MessageBox.Show("Age is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (rbn_male.Checked == false & rbn_female.Checked == false)
                MessageBox.Show("Please Select A Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            else if (txt_tp.Text.Length != 10 & txt_tp.Text.Any(char.IsLetter))
                MessageBox.Show("Invalid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }  


        private void dob_picker_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dob_picker.Value.Year;
            txt_age.Text = age.ToString();

        }
    }
}

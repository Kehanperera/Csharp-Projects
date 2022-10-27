namespace EmployeeSalary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Basic_salary = new System.Windows.Forms.TextBox();
            this.Allowance = new System.Windows.Forms.TextBox();
            this.Med_Allowance = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Net_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Basic_salary
            // 
            this.Basic_salary.Location = new System.Drawing.Point(314, 47);
            this.Basic_salary.Name = "Basic_salary";
            this.Basic_salary.Size = new System.Drawing.Size(100, 22);
            this.Basic_salary.TabIndex = 0;
            // 
            // Allowance
            // 
            this.Allowance.Location = new System.Drawing.Point(314, 98);
            this.Allowance.Name = "Allowance";
            this.Allowance.Size = new System.Drawing.Size(100, 22);
            this.Allowance.TabIndex = 1;
            // 
            // Med_Allowance
            // 
            this.Med_Allowance.Location = new System.Drawing.Point(314, 147);
            this.Med_Allowance.Name = "Med_Allowance";
            this.Med_Allowance.Size = new System.Drawing.Size(100, 22);
            this.Med_Allowance.TabIndex = 2;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(314, 215);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(100, 22);
            this.Total.TabIndex = 3;
            // 
            // Net_Total
            // 
            this.Net_Total.Location = new System.Drawing.Point(314, 301);
            this.Net_Total.Name = "Net_Total";
            this.Net_Total.Size = new System.Drawing.Size(100, 22);
            this.Net_Total.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Basic Salary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medical Allowance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Net Total";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(329, 376);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(85, 23);
            this.btn_calc.TabIndex = 10;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(509, 376);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(75, 23);
            this.btn_ex.TabIndex = 11;
            this.btn_ex.Text = "Exit";
            this.btn_ex.UseVisualStyleBackColor = true;
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(160, 376);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 12;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Net_Total);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Med_Allowance);
            this.Controls.Add(this.Allowance);
            this.Controls.Add(this.Basic_salary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Basic_salary;
        private System.Windows.Forms.TextBox Allowance;
        private System.Windows.Forms.TextBox Med_Allowance;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox Net_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_ex;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Timer timer1;
    }
}


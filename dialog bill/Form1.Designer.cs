namespace dialog_bill
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
            this.com_type = new System.Windows.Forms.ComboBox();
            this.day_txt = new System.Windows.Forms.TextBox();
            this.night_txt = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // com_type
            // 
            this.com_type.FormattingEnabled = true;
            this.com_type.Items.AddRange(new object[] {
            "Day Blast",
            "Night Blast"});
            this.com_type.Location = new System.Drawing.Point(369, 94);
            this.com_type.Name = "com_type";
            this.com_type.Size = new System.Drawing.Size(121, 24);
            this.com_type.TabIndex = 0;
            // 
            // day_txt
            // 
            this.day_txt.Location = new System.Drawing.Point(369, 146);
            this.day_txt.Name = "day_txt";
            this.day_txt.Size = new System.Drawing.Size(121, 22);
            this.day_txt.TabIndex = 1;
            // 
            // night_txt
            // 
            this.night_txt.Location = new System.Drawing.Point(369, 197);
            this.night_txt.Name = "night_txt";
            this.night_txt.Size = new System.Drawing.Size(121, 22);
            this.night_txt.TabIndex = 2;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(369, 254);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(121, 22);
            this.Total.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Data Package";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Units at Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Units at Night";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total";
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(399, 333);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 8;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(610, 333);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(75, 23);
            this.btn_ex.TabIndex = 9;
            this.btn_ex.Text = "Exit";
            this.btn_ex.UseVisualStyleBackColor = true;
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(205, 332);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 10;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.night_txt);
            this.Controls.Add(this.day_txt);
            this.Controls.Add(this.com_type);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox com_type;
        private System.Windows.Forms.TextBox day_txt;
        private System.Windows.Forms.TextBox night_txt;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_ex;
        private System.Windows.Forms.Button btn_clr;
    }
}


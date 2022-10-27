namespace ELECTRIRICTY_BILL
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
            this.Com_Type = new System.Windows.Forms.ComboBox();
            this.Units = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Com_Type
            // 
            this.Com_Type.FormattingEnabled = true;
            this.Com_Type.Items.AddRange(new object[] {
            "Domestic Customer",
            "Business Customer"});
            this.Com_Type.Location = new System.Drawing.Point(347, 84);
            this.Com_Type.Name = "Com_Type";
            this.Com_Type.Size = new System.Drawing.Size(121, 24);
            this.Com_Type.TabIndex = 0;
            // 
            // Units
            // 
            this.Units.Location = new System.Drawing.Point(347, 175);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(121, 22);
            this.Units.TabIndex = 1;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(347, 246);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(121, 22);
            this.Total.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Units";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(203, 343);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(75, 23);
            this.btn_cls.TabIndex = 6;
            this.btn_cls.Text = "Clear";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(393, 343);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 7;
            this.btn_calc.Text = "Calculate";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_ex
            // 
            this.btn_ex.Location = new System.Drawing.Point(602, 342);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(75, 23);
            this.btn_ex.TabIndex = 8;
            this.btn_ex.Text = "Exit";
            this.btn_ex.UseVisualStyleBackColor = true;
            this.btn_ex.Click += new System.EventHandler(this.btn_ex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ex);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.Com_Type);
            this.Name = "Form1";
            this.Text = "Electricity bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_Type;
        private System.Windows.Forms.TextBox Units;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_ex;
    }
}


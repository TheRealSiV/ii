
namespace Lab3
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
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.constLabel_Code = new System.Windows.Forms.Label();
            this.constLabel_City = new System.Windows.Forms.Label();
            this.constLabel_Facc = new System.Windows.Forms.Label();
            this.constLabel_Univ = new System.Windows.Forms.Label();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.listBox_Facs = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.Location = new System.Drawing.Point(6, 47);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(151, 303);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.constLabel_Code);
            this.groupBox1.Controls.Add(this.constLabel_City);
            this.groupBox1.Controls.Add(this.constLabel_Facc);
            this.groupBox1.Controls.Add(this.constLabel_Univ);
            this.groupBox1.Controls.Add(this.textBox_Code);
            this.groupBox1.Controls.Add(this.textBox_City);
            this.groupBox1.Controls.Add(this.listBox_Facs);
            this.groupBox1.Controls.Add(this.listBox_Univ);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "k";
            // 
            // constLabel_Code
            // 
            this.constLabel_Code.AutoSize = true;
            this.constLabel_Code.Location = new System.Drawing.Point(191, 307);
            this.constLabel_Code.Name = "constLabel_Code";
            this.constLabel_Code.Size = new System.Drawing.Size(81, 13);
            this.constLabel_Code.TabIndex = 7;
            this.constLabel_Code.Text = "University Code";
            // 
            // constLabel_City
            // 
            this.constLabel_City.AutoSize = true;
            this.constLabel_City.Location = new System.Drawing.Point(191, 248);
            this.constLabel_City.Name = "constLabel_City";
            this.constLabel_City.Size = new System.Drawing.Size(24, 13);
            this.constLabel_City.TabIndex = 6;
            this.constLabel_City.Text = "City";
            // 
            // constLabel_Facc
            // 
            this.constLabel_Facc.AutoSize = true;
            this.constLabel_Facc.Location = new System.Drawing.Point(191, 28);
            this.constLabel_Facc.Name = "constLabel_Facc";
            this.constLabel_Facc.Size = new System.Drawing.Size(49, 13);
            this.constLabel_Facc.TabIndex = 5;
            this.constLabel_Facc.Text = "Faculties";
            // 
            // constLabel_Univ
            // 
            this.constLabel_Univ.AutoSize = true;
            this.constLabel_Univ.Location = new System.Drawing.Point(7, 28);
            this.constLabel_Univ.Name = "constLabel_Univ";
            this.constLabel_Univ.Size = new System.Drawing.Size(53, 13);
            this.constLabel_Univ.TabIndex = 4;
            this.constLabel_Univ.Text = "University";
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(191, 326);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(151, 20);
            this.textBox_Code.TabIndex = 3;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(191, 267);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(151, 20);
            this.textBox_City.TabIndex = 2;
            // 
            // listBox_Facs
            // 
            this.listBox_Facs.FormattingEnabled = true;
            this.listBox_Facs.Location = new System.Drawing.Point(191, 47);
            this.listBox_Facs.Name = "listBox_Facs";
            this.listBox_Facs.Size = new System.Drawing.Size(151, 186);
            this.listBox_Facs.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.ListBox listBox_Facs;
        private System.Windows.Forms.Label constLabel_Code;
        private System.Windows.Forms.Label constLabel_City;
        private System.Windows.Forms.Label constLabel_Facc;
        private System.Windows.Forms.Label constLabel_Univ;
    }
}



namespace Lab2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oPERATIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuMinus = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuMul = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 23);
            this.textBox2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPERATIONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oPERATIONToolStripMenuItem
            // 
            this.oPERATIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPlus,
            this.toolStripMenuMinus,
            this.toolStripMenuMul});
            this.oPERATIONToolStripMenuItem.Name = "oPERATIONToolStripMenuItem";
            this.oPERATIONToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.oPERATIONToolStripMenuItem.Text = "OPERATION";
            this.oPERATIONToolStripMenuItem.Click += new System.EventHandler(this.oPERATIONToolStripMenuItem_Click);
            // 
            // toolStripMenuPlus
            // 
            this.toolStripMenuPlus.Name = "toolStripMenuPlus";
            this.toolStripMenuPlus.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuPlus.Text = "OR";
            this.toolStripMenuPlus.Click += new System.EventHandler(this.toolStripMenuPlus_Click);
            // 
            // toolStripMenuMinus
            // 
            this.toolStripMenuMinus.Name = "toolStripMenuMinus";
            this.toolStripMenuMinus.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuMinus.Text = "AND";
            this.toolStripMenuMinus.Click += new System.EventHandler(this.toolStripMenuMinus_Click);
            // 
            // toolStripMenuMul
            // 
            this.toolStripMenuMul.Name = "toolStripMenuMul";
            this.toolStripMenuMul.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuMul.Text = "XOR";
            this.toolStripMenuMul.Click += new System.EventHandler(this.toolStripMenuMul_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(245, 25);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oPERATIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPlus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMinus;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuMul;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


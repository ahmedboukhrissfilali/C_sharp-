
namespace formeApp1
{
    partial class clacule
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nb1 = new System.Windows.Forms.Label();
            this.nb2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.rdbp = new System.Windows.Forms.RadioButton();
            this.rdbs = new System.Windows.Forms.RadioButton();
            this.rdbd = new System.Windows.Forms.RadioButton();
            this.rdbmul = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(421, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(421, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 1;
            // 
            // nb1
            // 
            this.nb1.AutoSize = true;
            this.nb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb1.Location = new System.Drawing.Point(270, 34);
            this.nb1.Name = "nb1";
            this.nb1.Size = new System.Drawing.Size(32, 18);
            this.nb1.TabIndex = 2;
            this.nb1.Text = "nb1";
            // 
            // nb2
            // 
            this.nb2.AutoSize = true;
            this.nb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nb2.Location = new System.Drawing.Point(270, 76);
            this.nb2.Name = "nb2";
            this.nb2.Size = new System.Drawing.Size(32, 18);
            this.nb2.TabIndex = 3;
            this.nb2.Text = "nb2";
            this.nb2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(505, 170);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(103, 30);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "resulta";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // rdbp
            // 
            this.rdbp.AutoSize = true;
            this.rdbp.Location = new System.Drawing.Point(259, 136);
            this.rdbp.Name = "rdbp";
            this.rdbp.Size = new System.Drawing.Size(31, 17);
            this.rdbp.TabIndex = 6;
            this.rdbp.TabStop = true;
            this.rdbp.Text = "+";
            this.rdbp.UseVisualStyleBackColor = true;
            // 
            // rdbs
            // 
            this.rdbs.AutoSize = true;
            this.rdbs.Location = new System.Drawing.Point(259, 177);
            this.rdbs.Name = "rdbs";
            this.rdbs.Size = new System.Drawing.Size(28, 17);
            this.rdbs.TabIndex = 7;
            this.rdbs.TabStop = true;
            this.rdbs.Text = "-";
            this.rdbs.UseVisualStyleBackColor = true;
            // 
            // rdbd
            // 
            this.rdbd.AutoSize = true;
            this.rdbd.Location = new System.Drawing.Point(259, 213);
            this.rdbd.Name = "rdbd";
            this.rdbd.Size = new System.Drawing.Size(30, 17);
            this.rdbd.TabIndex = 8;
            this.rdbd.TabStop = true;
            this.rdbd.Text = "/";
            this.rdbd.UseVisualStyleBackColor = true;
            // 
            // rdbmul
            // 
            this.rdbmul.AutoSize = true;
            this.rdbmul.Location = new System.Drawing.Point(259, 260);
            this.rdbmul.Name = "rdbmul";
            this.rdbmul.Size = new System.Drawing.Size(29, 17);
            this.rdbmul.TabIndex = 9;
            this.rdbmul.TabStop = true;
            this.rdbmul.Text = "*";
            this.rdbmul.UseVisualStyleBackColor = true;
            // 
            // clacule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbmul);
            this.Controls.Add(this.rdbd);
            this.Controls.Add(this.rdbs);
            this.Controls.Add(this.rdbp);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nb2);
            this.Controls.Add(this.nb1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "clacule";
            this.Text = "clacule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nb1;
        private System.Windows.Forms.Label nb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.RadioButton rdbp;
        private System.Windows.Forms.RadioButton rdbs;
        private System.Windows.Forms.RadioButton rdbd;
        private System.Windows.Forms.RadioButton rdbmul;
    }
}
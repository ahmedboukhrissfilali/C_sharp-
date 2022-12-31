namespace Program_Paire_npair
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
            this.lbl_Resultats = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_N1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Resultats
            // 
            this.lbl_Resultats.AutoSize = true;
            this.lbl_Resultats.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Resultats.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultats.ForeColor = System.Drawing.Color.Red;
            this.lbl_Resultats.Location = new System.Drawing.Point(12, 197);
            this.lbl_Resultats.Name = "lbl_Resultats";
            this.lbl_Resultats.Size = new System.Drawing.Size(0, 26);
            this.lbl_Resultats.TabIndex = 9;
            this.lbl_Resultats.Click += new System.EventHandler(this.lbl_Resultats_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "resultas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_N1
            // 
            this.lbl_N1.AutoSize = true;
            this.lbl_N1.Location = new System.Drawing.Point(77, 54);
            this.lbl_N1.Name = "lbl_N1";
            this.lbl_N1.Size = new System.Drawing.Size(29, 20);
            this.lbl_N1.TabIndex = 6;
            this.lbl_N1.Text = "N1";
            this.lbl_N1.Click += new System.EventHandler(this.lbl_N1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 279);
            this.Controls.Add(this.lbl_Resultats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_N1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Resultats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_N1;
    }
}


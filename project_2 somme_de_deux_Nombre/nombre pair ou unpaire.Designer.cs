namespace project_2_somme_de_deux_Nombre
{
    partial class nombre_pair_ou_unpaire
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
            this.lbl_N1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Resultats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_N1
            // 
            this.lbl_N1.AutoSize = true;
            this.lbl_N1.Location = new System.Drawing.Point(45, 46);
            this.lbl_N1.Name = "lbl_N1";
            this.lbl_N1.Size = new System.Drawing.Size(29, 20);
            this.lbl_N1.TabIndex = 0;
            this.lbl_N1.Text = "N1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "resultas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Resultats
            // 
            this.lbl_Resultats.AutoSize = true;
            this.lbl_Resultats.BackColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Resultats.Font = new System.Drawing.Font("Microsoft YaHei Light", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultats.ForeColor = System.Drawing.Color.Red;
            this.lbl_Resultats.Location = new System.Drawing.Point(114, 166);
            this.lbl_Resultats.Name = "lbl_Resultats";
            this.lbl_Resultats.Size = new System.Drawing.Size(0, 57);
            this.lbl_Resultats.TabIndex = 5;
            // 
            // nombre_pair_ou_unpaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 246);
            this.Controls.Add(this.lbl_Resultats);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_N1);
            this.Name = "nombre_pair_ou_unpaire";
            this.Text = "nombre_pair_ou_unpaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_N1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Resultats;
    }
}
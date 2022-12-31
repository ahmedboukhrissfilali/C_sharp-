namespace Project_1_affichier
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.Lbl_prenom = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.Btn_aff = new System.Windows.Forms.Button();
            this.Lbl_aff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(54, 65);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(42, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Nom";
            // 
            // Lbl_prenom
            // 
            this.Lbl_prenom.AutoSize = true;
            this.Lbl_prenom.Location = new System.Drawing.Point(54, 111);
            this.Lbl_prenom.Name = "Lbl_prenom";
            this.Lbl_prenom.Size = new System.Drawing.Size(64, 20);
            this.Lbl_prenom.TabIndex = 1;
            this.Lbl_prenom.Text = "Prenom";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(195, 65);
            this.txt_Nom.Multiline = true;
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(340, 26);
            this.txt_Nom.TabIndex = 2;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(195, 105);
            this.txt_Prenom.Multiline = true;
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(340, 26);
            this.txt_Prenom.TabIndex = 3;
            // 
            // Btn_aff
            // 
            this.Btn_aff.Location = new System.Drawing.Point(335, 159);
            this.Btn_aff.Name = "Btn_aff";
            this.Btn_aff.Size = new System.Drawing.Size(200, 44);
            this.Btn_aff.TabIndex = 4;
            this.Btn_aff.Text = "affichier";
            this.Btn_aff.UseVisualStyleBackColor = true;
            this.Btn_aff.Click += new System.EventHandler(this.Btn_aff_Click);
            // 
            // Lbl_aff
            // 
            this.Lbl_aff.AutoSize = true;
            this.Lbl_aff.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Lbl_aff.Location = new System.Drawing.Point(51, 274);
            this.Lbl_aff.Name = "Lbl_aff";
            this.Lbl_aff.Size = new System.Drawing.Size(0, 64);
            this.Lbl_aff.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_aff);
            this.Controls.Add(this.Btn_aff);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.Lbl_prenom);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label Lbl_prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.Button Btn_aff;
        private System.Windows.Forms.Label Lbl_aff;
    }
}


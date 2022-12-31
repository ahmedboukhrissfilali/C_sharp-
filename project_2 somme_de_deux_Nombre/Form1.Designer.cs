namespace project_2_somme_de_deux_Nombre
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
            this.Lbl_Nombre1 = new System.Windows.Forms.Label();
            this.Lbl_Nombre2 = new System.Windows.Forms.Label();
            this.txt_N1 = new System.Windows.Forms.TextBox();
            this.Txt_N2 = new System.Windows.Forms.TextBox();
            this.Btn_aff = new System.Windows.Forms.Button();
            this.Lbl_aff = new System.Windows.Forms.Label();
            this.txt_Re = new System.Windows.Forms.TextBox();
            this.lbl_RESULTAT = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Nombre1
            // 
            this.Lbl_Nombre1.AutoSize = true;
            this.Lbl_Nombre1.Location = new System.Drawing.Point(60, 44);
            this.Lbl_Nombre1.Name = "Lbl_Nombre1";
            this.Lbl_Nombre1.Size = new System.Drawing.Size(83, 20);
            this.Lbl_Nombre1.TabIndex = 0;
            this.Lbl_Nombre1.Text = "Numbre_1";
            this.Lbl_Nombre1.Click += new System.EventHandler(this.Lbl_Nombre1_Click);
            // 
            // Lbl_Nombre2
            // 
            this.Lbl_Nombre2.AutoSize = true;
            this.Lbl_Nombre2.Location = new System.Drawing.Point(60, 87);
            this.Lbl_Nombre2.Name = "Lbl_Nombre2";
            this.Lbl_Nombre2.Size = new System.Drawing.Size(74, 20);
            this.Lbl_Nombre2.TabIndex = 1;
            this.Lbl_Nombre2.Text = "Nombre2";
            this.Lbl_Nombre2.Click += new System.EventHandler(this.Lbl_Nombre2_Click);
            // 
            // txt_N1
            // 
            this.txt_N1.Location = new System.Drawing.Point(190, 37);
            this.txt_N1.Multiline = true;
            this.txt_N1.Name = "txt_N1";
            this.txt_N1.Size = new System.Drawing.Size(243, 26);
            this.txt_N1.TabIndex = 2;
            this.txt_N1.TextChanged += new System.EventHandler(this.txt_N1_TextChanged);
            // 
            // Txt_N2
            // 
            this.Txt_N2.Location = new System.Drawing.Point(190, 87);
            this.Txt_N2.Multiline = true;
            this.Txt_N2.Name = "Txt_N2";
            this.Txt_N2.Size = new System.Drawing.Size(243, 26);
            this.Txt_N2.TabIndex = 3;
            this.Txt_N2.TextChanged += new System.EventHandler(this.Txt_N2_TextChanged);
            // 
            // Btn_aff
            // 
            this.Btn_aff.Location = new System.Drawing.Point(342, 197);
            this.Btn_aff.Name = "Btn_aff";
            this.Btn_aff.Size = new System.Drawing.Size(91, 29);
            this.Btn_aff.TabIndex = 4;
            this.Btn_aff.Text = "Calculer";
            this.Btn_aff.UseVisualStyleBackColor = true;
            this.Btn_aff.Click += new System.EventHandler(this.Btn_aff_Click);
            // 
            // Lbl_aff
            // 
            this.Lbl_aff.AutoSize = true;
            this.Lbl_aff.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_aff.ForeColor = System.Drawing.Color.Red;
            this.Lbl_aff.Location = new System.Drawing.Point(186, 246);
            this.Lbl_aff.Name = "Lbl_aff";
            this.Lbl_aff.Size = new System.Drawing.Size(0, 64);
            this.Lbl_aff.TabIndex = 5;
            this.Lbl_aff.Click += new System.EventHandler(this.Lbl_aff_Click);
            // 
            // txt_Re
            // 
            this.txt_Re.Location = new System.Drawing.Point(268, 136);
            this.txt_Re.Multiline = true;
            this.txt_Re.Name = "txt_Re";
            this.txt_Re.Size = new System.Drawing.Size(165, 26);
            this.txt_Re.TabIndex = 6;
            this.txt_Re.TextChanged += new System.EventHandler(this.txt_Re_TextChanged);
            // 
            // lbl_RESULTAT
            // 
            this.lbl_RESULTAT.AutoSize = true;
            this.lbl_RESULTAT.Location = new System.Drawing.Point(138, 142);
            this.lbl_RESULTAT.Name = "lbl_RESULTAT";
            this.lbl_RESULTAT.Size = new System.Drawing.Size(69, 20);
            this.lbl_RESULTAT.TabIndex = 7;
            this.lbl_RESULTAT.Text = "Resultat";
            this.lbl_RESULTAT.Click += new System.EventHandler(this.lbl_RESULTAT_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(180, 197);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(91, 29);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 308);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_RESULTAT);
            this.Controls.Add(this.txt_Re);
            this.Controls.Add(this.Lbl_aff);
            this.Controls.Add(this.Btn_aff);
            this.Controls.Add(this.Txt_N2);
            this.Controls.Add(this.txt_N1);
            this.Controls.Add(this.Lbl_Nombre2);
            this.Controls.Add(this.Lbl_Nombre1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nombre1;
        private System.Windows.Forms.Label Lbl_Nombre2;
        private System.Windows.Forms.TextBox txt_N1;
        private System.Windows.Forms.TextBox Txt_N2;
        private System.Windows.Forms.Button Btn_aff;
        private System.Windows.Forms.Label Lbl_aff;
        private System.Windows.Forms.TextBox txt_Re;
        private System.Windows.Forms.Label lbl_RESULTAT;
        private System.Windows.Forms.Button btn_Clear;
    }
}


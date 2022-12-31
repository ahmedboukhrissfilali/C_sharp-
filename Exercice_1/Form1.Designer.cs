namespace Exercice_1
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
            this.lbl_Montants = new System.Windows.Forms.Label();
            this.Lbl_Reduction = new System.Windows.Forms.Label();
            this.Lbl_SP = new System.Windows.Forms.Label();
            this.txt_Saisir = new System.Windows.Forms.TextBox();
            this.txt_Taux_R = new System.Windows.Forms.TextBox();
            this.txt_Montant_Pay = new System.Windows.Forms.TextBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Montants
            // 
            this.lbl_Montants.AutoSize = true;
            this.lbl_Montants.Location = new System.Drawing.Point(27, 67);
            this.lbl_Montants.Name = "lbl_Montants";
            this.lbl_Montants.Size = new System.Drawing.Size(197, 20);
            this.lbl_Montants.TabIndex = 0;
            this.lbl_Montants.Text = "Saisir le montants en MAD";
            // 
            // Lbl_Reduction
            // 
            this.Lbl_Reduction.AutoSize = true;
            this.Lbl_Reduction.Location = new System.Drawing.Point(27, 124);
            this.Lbl_Reduction.Name = "Lbl_Reduction";
            this.Lbl_Reduction.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Reduction.TabIndex = 1;
            this.Lbl_Reduction.Text = "le Taux de reduction";
            // 
            // Lbl_SP
            // 
            this.Lbl_SP.AutoSize = true;
            this.Lbl_SP.Location = new System.Drawing.Point(27, 183);
            this.Lbl_SP.Name = "Lbl_SP";
            this.Lbl_SP.Size = new System.Drawing.Size(128, 20);
            this.Lbl_SP.TabIndex = 2;
            this.Lbl_SP.Text = "la somme a paye";
            // 
            // txt_Saisir
            // 
            this.txt_Saisir.Location = new System.Drawing.Point(267, 61);
            this.txt_Saisir.Name = "txt_Saisir";
            this.txt_Saisir.Size = new System.Drawing.Size(343, 26);
            this.txt_Saisir.TabIndex = 3;
            // 
            // txt_Taux_R
            // 
            this.txt_Taux_R.Location = new System.Drawing.Point(267, 118);
            this.txt_Taux_R.Name = "txt_Taux_R";
            this.txt_Taux_R.Size = new System.Drawing.Size(343, 26);
            this.txt_Taux_R.TabIndex = 4;
            // 
            // txt_Montant_Pay
            // 
            this.txt_Montant_Pay.Location = new System.Drawing.Point(267, 177);
            this.txt_Montant_Pay.Name = "txt_Montant_Pay";
            this.txt_Montant_Pay.Size = new System.Drawing.Size(343, 26);
            this.txt_Montant_Pay.TabIndex = 5;
            this.txt_Montant_Pay.TextChanged += new System.EventHandler(this.txt_Montant_Pay_TextChanged);
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(267, 266);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(343, 47);
            this.btn_Calc.TabIndex = 6;
            this.btn_Calc.Text = "Calcule";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.btn_Calc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.txt_Montant_Pay);
            this.Controls.Add(this.txt_Taux_R);
            this.Controls.Add(this.txt_Saisir);
            this.Controls.Add(this.Lbl_SP);
            this.Controls.Add(this.Lbl_Reduction);
            this.Controls.Add(this.lbl_Montants);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Montants;
        private System.Windows.Forms.Label Lbl_Reduction;
        private System.Windows.Forms.Label Lbl_SP;
        private System.Windows.Forms.TextBox txt_Saisir;
        private System.Windows.Forms.TextBox txt_Taux_R;
        private System.Windows.Forms.TextBox txt_Montant_Pay;
        private System.Windows.Forms.Button btn_Calc;
    }
}


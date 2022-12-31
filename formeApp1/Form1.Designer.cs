
namespace formeApp1
{
    partial class mayForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mbutton = new System.Windows.Forms.Button();
            this.mlabel = new System.Windows.Forms.Label();
            this.mbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            // 
            // mbutton
            // 
            this.mbutton.Location = new System.Drawing.Point(337, 94);
            this.mbutton.Name = "mbutton";
            this.mbutton.Size = new System.Drawing.Size(115, 26);
            this.mbutton.TabIndex = 1;
            this.mbutton.Text = "affichage";
            this.mbutton.UseVisualStyleBackColor = true;
            this.mbutton.Click += new System.EventHandler(this.mbutton_Click);
            // 
            // mlabel
            // 
            this.mlabel.AutoSize = true;
            this.mlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mlabel.Location = new System.Drawing.Point(361, 63);
            this.mlabel.Name = "mlabel";
            this.mlabel.Size = new System.Drawing.Size(52, 18);
            this.mlabel.TabIndex = 2;
            this.mlabel.Text = "label1";
            this.mlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // mbutton2
            // 
            this.mbutton2.Location = new System.Drawing.Point(337, 133);
            this.mbutton2.Name = "mbutton2";
            this.mbutton2.Size = new System.Drawing.Size(114, 24);
            this.mbutton2.TabIndex = 3;
            this.mbutton2.Text = "affichage2";
            this.mbutton2.UseVisualStyleBackColor = true;
            this.mbutton2.Click += new System.EventHandler(this.mbutton2_Click);
            // 
            // mayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mbutton2);
            this.Controls.Add(this.mlabel);
            this.Controls.Add(this.mbutton);
            this.Controls.Add(this.textBox1);
            this.Name = "mayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ma pr forme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mbutton;
        private System.Windows.Forms.Label mlabel;
        private System.Windows.Forms.Button mbutton2;
    }
}


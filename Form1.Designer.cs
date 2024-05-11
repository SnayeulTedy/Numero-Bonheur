namespace MonNumeroBonheur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDivorce = new System.Windows.Forms.RadioButton();
            this.rbMarie = new System.Windows.Forms.RadioButton();
            this.rbCelibataire = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btChangerCouleur = new System.Windows.Forms.Button();
            this.btRechercher = new System.Windows.Forms.Button();
            this.tbDDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbDivorce);
            this.groupBox1.Controls.Add(this.rbMarie);
            this.groupBox1.Controls.Add(this.rbCelibataire);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 135);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Civilité";
            // 
            // rbDivorce
            // 
            this.rbDivorce.AutoSize = true;
            this.rbDivorce.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDivorce.Location = new System.Drawing.Point(284, 71);
            this.rbDivorce.Name = "rbDivorce";
            this.rbDivorce.Size = new System.Drawing.Size(89, 23);
            this.rbDivorce.TabIndex = 0;
            this.rbDivorce.Text = "Divorcé";
            this.rbDivorce.UseVisualStyleBackColor = true;
            // 
            // rbMarie
            // 
            this.rbMarie.AutoSize = true;
            this.rbMarie.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMarie.Location = new System.Drawing.Point(160, 71);
            this.rbMarie.Name = "rbMarie";
            this.rbMarie.Size = new System.Drawing.Size(75, 23);
            this.rbMarie.TabIndex = 0;
            this.rbMarie.Text = "Marié";
            this.rbMarie.UseVisualStyleBackColor = true;
            // 
            // rbCelibataire
            // 
            this.rbCelibataire.AutoSize = true;
            this.rbCelibataire.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelibataire.Location = new System.Drawing.Point(27, 71);
            this.rbCelibataire.Name = "rbCelibataire";
            this.rbCelibataire.Size = new System.Drawing.Size(117, 23);
            this.rbCelibataire.TabIndex = 0;
            this.rbCelibataire.Text = "Celibataire";
            this.rbCelibataire.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trouvez votre chiffre porte bonheur";
            // 
            // btChangerCouleur
            // 
            this.btChangerCouleur.BackColor = System.Drawing.Color.White;
            this.btChangerCouleur.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChangerCouleur.Location = new System.Drawing.Point(237, 369);
            this.btChangerCouleur.Name = "btChangerCouleur";
            this.btChangerCouleur.Size = new System.Drawing.Size(157, 44);
            this.btChangerCouleur.TabIndex = 8;
            this.btChangerCouleur.Text = "Changer couleur";
            this.btChangerCouleur.UseVisualStyleBackColor = false;
            this.btChangerCouleur.Click += new System.EventHandler(this.btChangerCouleur_Click);
            // 
            // btRechercher
            // 
            this.btRechercher.BackColor = System.Drawing.Color.White;
            this.btRechercher.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRechercher.Location = new System.Drawing.Point(39, 369);
            this.btRechercher.Name = "btRechercher";
            this.btRechercher.Size = new System.Drawing.Size(146, 44);
            this.btRechercher.TabIndex = 9;
            this.btRechercher.Text = "Rechercher";
            this.btRechercher.UseVisualStyleBackColor = false;
            this.btRechercher.Click += new System.EventHandler(this.btRechercher_Click);
            // 
            // tbDDN
            // 
            this.tbDDN.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDDN.Location = new System.Drawing.Point(93, 313);
            this.tbDDN.Multiline = true;
            this.tbDDN.Name = "tbDDN";
            this.tbDDN.Size = new System.Drawing.Size(231, 32);
            this.tbDDN.TabIndex = 7;
            this.tbDDN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date de naisance au format (JJ/MM/AAAA)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btChangerCouleur);
            this.Controls.Add(this.btRechercher);
            this.Controls.Add(this.tbDDN);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MISTER~S Numero Porte-Bonheur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDivorce;
        private System.Windows.Forms.RadioButton rbMarie;
        private System.Windows.Forms.RadioButton rbCelibataire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChangerCouleur;
        private System.Windows.Forms.Button btRechercher;
        private System.Windows.Forms.TextBox tbDDN;
        private System.Windows.Forms.Label label2;
    }
}


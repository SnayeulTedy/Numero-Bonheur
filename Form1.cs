using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MonNumeroBonheur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //nous utilisons la region pour regrouper tout les evenement du formulaire
        #region Controles 
        private void btRechercher_Click(object sender, EventArgs e)
        {
            DateTime dateNaissance;
            bool dateValide = DateTime.TryParse(tbDDN.Text, out dateNaissance);//contrainte pour verifier si la date est correctement saisie. 

            if (!dateValide)
            {
                MessageBox.Show("Vous avez saisi une date invalide.", "Avis d'invalidité", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                
            }
            else
            {
                int jour = dateNaissance.Day;//Recupere le jour sur la date de naissance.
                int mois = dateNaissance.Month;//Recupere le mois sur la date de naissance.
                //MessageBox.Show("jour et mois :" + jour + "," + mois);
                int num = 0;
                if (rbCelibataire.Checked == true)
                {
                    num = 3;
                }
                else if (rbMarie.Checked == true)
                {
                    num = 2;
                }
                else if (rbDivorce.Checked == true)
                {
                    num = 1;
                }
                else
                {
                    MessageBox.Show("Veuillez bien choisir une civilité.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (num > 0)
                {
                    int numeroBonheur = (jour * 2 + mois * 3 + num * 5) % 100;
                    MessageBox.Show("© TIPAM1 SNAYEUL TEDY 2024. All rights reserved: " + "\n\n\n  Votre numero porte-bonheur est : " + numeroBonheur, "numero bonheur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btChangerCouleur_Click(object sender, EventArgs e)
        {
            ColorDialog changerCouleur = new ColorDialog();//cree une boite dans laquelle on choisi la couleur.
            if (changerCouleur.ShowDialog() == DialogResult.OK)//ici on choisi la premiere couleur.
            {
                Color premiereCouleur = changerCouleur.Color;
                if (changerCouleur.ShowDialog() == DialogResult.OK)//ici on choisi la deuxieme couleur.
                {
                    Color deuxiemecouleur = changerCouleur.Color;
                    appliquerDegrade(premiereCouleur, deuxiemecouleur);// appele la methode qui applique le degrade 
                }
            }
        }
       
        #endregion
        // ici la region pour les methodes. 
        #region Methodes
        
        private void appliquerDegrade(Color premiereCouleur, Color deuxiemeCouleur)//la procedure qui applique le degarde
        {
            LinearGradientBrush degrade = new LinearGradientBrush(this.ClientRectangle, premiereCouleur, deuxiemeCouleur, LinearGradientMode.Vertical);
            Graphics degrader = this.CreateGraphics();
            degrader.FillRectangle(degrade, this.ClientRectangle);//pour appliquer le changement de couleur au formulaire.
        }

        #endregion
    }
}

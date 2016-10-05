using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace DiagMagic
{
	//  <summary>
	//  Description Résumé de UserControl.
	//  </summary>
	public class Define_Grille : System.Windows.Forms.UserControl
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		private System.ComponentModel.Container components = null;
		internal Dacris.NETXP.Controls.XPGroupBox Fond;
		internal System.Windows.Forms.RadioButton Fond_Blanc;
		internal System.Windows.Forms.RadioButton Fond_Noir;
		internal Dacris.NETXP.Controls.XPGroupBox Dimensions;
		internal System.Windows.Forms.RadioButton Predef;
		internal System.Windows.Forms.RadioButton Perso;
		internal System.Windows.Forms.ComboBox Dim_pred;
		internal System.Windows.Forms.Label lbl_W;
		internal System.Windows.Forms.Label lbl_H;
		internal System.Windows.Forms.NumericUpDown Width_Perso;
		internal System.Windows.Forms.NumericUpDown Height_Perso;
		internal System.Windows.Forms.Label Warning;
		internal Dacris.NETXP.Controls.XPButton Test_Fond;
		internal System.Windows.Forms.NumericUpDown Red;
		internal System.Windows.Forms.NumericUpDown Green;
		internal System.Windows.Forms.NumericUpDown Blue;
		internal System.Windows.Forms.Label lbl_R;
		internal System.Windows.Forms.Label lbl_G;
		internal System.Windows.Forms.Label lbl_B;
		internal System.Windows.Forms.RadioButton Fond_Perso;
		internal System.Windows.Forms.RadioButton Fond_Bleu;
		internal System.Windows.Forms.RadioButton Fond_Rouge;
		internal System.Windows.Forms.RadioButton Fond_Vert;
		internal Dacris.NETXP.Controls.XPButton Fond_Help;
		internal Dacris.NETXP.Controls.XPButton Rappel;
		internal Dacris.NETXP.Controls.XPGroupBox Color_Q;
		internal System.Windows.Forms.RadioButton Monochrom;
		internal System.Windows.Forms.RadioButton Fond_Jaune;
		protected internal System.Windows.Forms.NumericUpDown Nbre_Cotons;
		protected internal System.Windows.Forms.CheckBox Limit_Nbre;
		internal System.Windows.Forms.RadioButton Couleur;

		public Define_Grille()
		{
			/  Cet appel est requis par le concepteur Windows.Forms.
			InitializeComponent();

			/  TODO: Ajouter le code d'initialisation après l'appel de InitForm

		}
		//  <summary>
		//  Nettoyage des ressources utilisées.
		//  </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				 components.Dispose();
		 }
		 base.Dispose(disposing);
		}

		#region Code généré par le concepteur de composant
		//  <summary>
		//  Méthode requise pour la gestion du concepteur  - ne pas modifier 
		//  le contenu de cette méthode avec l'éditeur de code.
		//  </summary>
		private void InitializeComponent()
		{
			this.Fond = new Dacris.NETXP.Controls.XPGroupBox();
			this.Fond_Jaune = new System.Windows.Forms.RadioButton();
			this.Rappel = new Dacris.NETXP.Controls.XPButton();
			this.Fond_Help = new Dacris.NETXP.Controls.XPButton();
			this.Fond_Vert = new System.Windows.Forms.RadioButton();
			this.Fond_Rouge = new System.Windows.Forms.RadioButton();
			this.Fond_Bleu = new System.Windows.Forms.RadioButton();
			this.Fond_Perso = new System.Windows.Forms.RadioButton();
			this.Test_Fond = new Dacris.NETXP.Controls.XPButton();
			this.Red = new System.Windows.Forms.NumericUpDown();
			this.Green = new System.Windows.Forms.NumericUpDown();
			this.Blue = new System.Windows.Forms.NumericUpDown();
			this.lbl_R = new System.Windows.Forms.Label();
			this.lbl_G = new System.Windows.Forms.Label();
			this.lbl_B = new System.Windows.Forms.Label();
			this.Fond_Blanc = new System.Windows.Forms.RadioButton();
			this.Fond_Noir = new System.Windows.Forms.RadioButton();
			this.Dimensions = new Dacris.NETXP.Controls.XPGroupBox();
			this.Height_Perso = new System.Windows.Forms.NumericUpDown();
			this.Width_Perso = new System.Windows.Forms.NumericUpDown();
			this.lbl_H = new System.Windows.Forms.Label();
			this.lbl_W = new System.Windows.Forms.Label();
			this.Dim_pred = new System.Windows.Forms.ComboBox();
			this.Perso = new System.Windows.Forms.RadioButton();
			this.Predef = new System.Windows.Forms.RadioButton();
			this.Warning = new System.Windows.Forms.Label();
			this.Color_Q = new Dacris.NETXP.Controls.XPGroupBox();
			this.Nbre_Cotons = new System.Windows.Forms.NumericUpDown();
			this.Limit_Nbre = new System.Windows.Forms.CheckBox();
			this.Couleur = new System.Windows.Forms.RadioButton();
			this.Monochrom = new System.Windows.Forms.RadioButton();
			this.Fond.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
			this.Dimensions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Height_Perso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Width_Perso)).BeginInit();
			this.Color_Q.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Nbre_Cotons)).BeginInit();
			this.SuspendLayout();
			/  
			/  Fond
			/  
			this.Fond.BackColor = System.Drawing.SystemColors.Control;
			this.Fond.Controls.Add(this.Fond_Jaune);
			this.Fond.Controls.Add(this.Rappel);
			this.Fond.Controls.Add(this.Fond_Help);
			this.Fond.Controls.Add(this.Fond_Vert);
			this.Fond.Controls.Add(this.Fond_Rouge);
			this.Fond.Controls.Add(this.Fond_Bleu);
			this.Fond.Controls.Add(this.Fond_Perso);
			this.Fond.Controls.Add(this.Test_Fond);
			this.Fond.Controls.Add(this.Red);
			this.Fond.Controls.Add(this.Green);
			this.Fond.Controls.Add(this.Blue);
			this.Fond.Controls.Add(this.lbl_R);
			this.Fond.Controls.Add(this.lbl_G);
			this.Fond.Controls.Add(this.lbl_B);
			this.Fond.Controls.Add(this.Fond_Blanc);
			this.Fond.Controls.Add(this.Fond_Noir);
			this.Fond.Location = new System.Drawing.Point(152, 8);
			this.Fond.Name = "Fond";
			this.Fond.Size = new System.Drawing.Size(416, 152);
			this.Fond.TabIndex = 2;
			this.Fond.TabStop = false;
			this.Fond.Text = "Couleur du fond de l\'image";
			/  
			/  Fond_Jaune
			/  
			this.Fond_Jaune.BackColor = System.Drawing.Color.Yellow;
			this.Fond_Jaune.ForeColor = System.Drawing.Color.Black;
			this.Fond_Jaune.Location = new System.Drawing.Point(344, 32);
			this.Fond_Jaune.Name = "Fond_Jaune";
			this.Fond_Jaune.Size = new System.Drawing.Size(56, 24);
			this.Fond_Jaune.TabIndex = 24;
			this.Fond_Jaune.Text = "Jaune";
			this.Fond_Jaune.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Rappel
			/  
			this.Rappel.Location = new System.Drawing.Point(16, 80);
			this.Rappel.Name = "Rappel";
			this.Rappel.Size = new System.Drawing.Size(56, 48);
			this.Rappel.TabIndex = 23;
			this.Rappel.Text = "Rappel de L\'image";
			/  
			/  Fond_Help
			/  
			this.Fond_Help.Location = new System.Drawing.Point(80, 104);
			this.Fond_Help.Name = "Fond_Help";
			this.Fond_Help.Size = new System.Drawing.Size(24, 24);
			this.Fond_Help.TabIndex = 22;
			this.Fond_Help.Text = "&?";
			this.Fond_Help.Click += new System.EventHandler(this.Fond_Help_Click);
			/  
			/  Fond_Vert
			/  
			this.Fond_Vert.BackColor = System.Drawing.Color.Lime;
			this.Fond_Vert.ForeColor = System.Drawing.Color.Black;
			this.Fond_Vert.Location = new System.Drawing.Point(280, 32);
			this.Fond_Vert.Name = "Fond_Vert";
			this.Fond_Vert.Size = new System.Drawing.Size(48, 24);
			this.Fond_Vert.TabIndex = 21;
			this.Fond_Vert.Text = "Vert";
			this.Fond_Vert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Fond_Rouge
			/  
			this.Fond_Rouge.BackColor = System.Drawing.Color.Red;
			this.Fond_Rouge.ForeColor = System.Drawing.Color.Black;
			this.Fond_Rouge.Location = new System.Drawing.Point(208, 32);
			this.Fond_Rouge.Name = "Fond_Rouge";
			this.Fond_Rouge.Size = new System.Drawing.Size(56, 24);
			this.Fond_Rouge.TabIndex = 20;
			this.Fond_Rouge.Text = "Rouge";
			this.Fond_Rouge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Fond_Bleu
			/  
			this.Fond_Bleu.BackColor = System.Drawing.Color.Blue;
			this.Fond_Bleu.ForeColor = System.Drawing.Color.White;
			this.Fond_Bleu.Location = new System.Drawing.Point(144, 32);
			this.Fond_Bleu.Name = "Fond_Bleu";
			this.Fond_Bleu.Size = new System.Drawing.Size(48, 24);
			this.Fond_Bleu.TabIndex = 19;
			this.Fond_Bleu.Text = "Bleu";
			this.Fond_Bleu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Fond_Perso
			/  
			this.Fond_Perso.Location = new System.Drawing.Point(88, 72);
			this.Fond_Perso.Name = "Fond_Perso";
			this.Fond_Perso.Size = new System.Drawing.Size(88, 24);
			this.Fond_Perso.TabIndex = 18;
			this.Fond_Perso.Text = "Personalisé";
			this.Fond_Perso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Fond_Perso.CheckedChanged += new System.EventHandler(this.Fond_Perso_Check);
			/  
			/  Test_Fond
			/  
			this.Test_Fond.Enabled = false;
			this.Test_Fond.Location = new System.Drawing.Point(128, 104);
			this.Test_Fond.Name = "Test_Fond";
			this.Test_Fond.Size = new System.Drawing.Size(56, 24);
			this.Test_Fond.TabIndex = 17;
			this.Test_Fond.Text = "Aperçu";
			this.Test_Fond.Click += new System.EventHandler(this.Test_Fond_Click);
			/  
			/  Red
			/  
			this.Red.Enabled = false;
			this.Red.Location = new System.Drawing.Point(264, 120);
			this.Red.Maximum = new System.Decimal(new int[] {
		              255,
		              0,
		              0,
                 });
			this.Red.Name = "Red";
			this.Red.Size = new System.Drawing.Size(128, 20);
			this.Red.TabIndex = 16;
			/  
			/  Green
			/  
			this.Green.Enabled = false;
			this.Green.Location = new System.Drawing.Point(264, 96);
			this.Green.Maximum = new System.Decimal(new int[] {
		                255,
		                0,
		                0                      });
			this.Green.Name = "Green";
			this.Green.Size = new System.Drawing.Size(128, 20);
			this.Green.TabIndex = 15;
			/  
			/  Blue
			/  
			this.Blue.Enabled = false;
			this.Blue.Location = new System.Drawing.Point(264, 72);
			this.Blue.Maximum = new System.Decimal(new int[] {
		               255,
		               0,
		               0                     });
			this.Blue.Name = "Blue";
			this.Blue.Size = new System.Drawing.Size(128, 20);
			this.Blue.TabIndex = 14;
			/  
			/  lbl_R
			/  
			this.lbl_R.AutoSize = true;
			this.lbl_R.Enabled = false;
			this.lbl_R.Location = new System.Drawing.Point(208, 120);
			this.lbl_R.Name = "lbl_R";
			this.lbl_R.Size = new System.Drawing.Size(38, 16);
			this.lbl_R.TabIndex = 13;
			this.lbl_R.Text = "Rouge";
			/  
			/  lbl_G
			/  
			this.lbl_G.AutoSize = true;
			this.lbl_G.Enabled = false;
			this.lbl_G.Location = new System.Drawing.Point(216, 96);
			this.lbl_G.Name = "lbl_G";
			this.lbl_G.Size = new System.Drawing.Size(25, 16);
			this.lbl_G.TabIndex = 12;
			this.lbl_G.Text = "Vert";
			/  
			/  lbl_B
			/  
			this.lbl_B.AutoSize = true;
			this.lbl_B.Enabled = false;
			this.lbl_B.Location = new System.Drawing.Point(216, 72);
			this.lbl_B.Name = "lbl_B";
			this.lbl_B.Size = new System.Drawing.Size(27, 16);
			this.lbl_B.TabIndex = 11;
			this.lbl_B.Text = "Bleu";
			/  
			/  Fond_Blanc
			/  
			this.Fond_Blanc.BackColor = System.Drawing.Color.White;
			this.Fond_Blanc.Checked = true;
			this.Fond_Blanc.ForeColor = System.Drawing.Color.Black;
			this.Fond_Blanc.Location = new System.Drawing.Point(8, 32);
			this.Fond_Blanc.Name = "Fond_Blanc";
			this.Fond_Blanc.Size = new System.Drawing.Size(56, 24);
			this.Fond_Blanc.TabIndex = 0;
			this.Fond_Blanc.TabStop = true;
			this.Fond_Blanc.Text = "Blanc";
			this.Fond_Blanc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Fond_Noir
			/  
			this.Fond_Noir.BackColor = System.Drawing.Color.Black;
			this.Fond_Noir.ForeColor = System.Drawing.Color.White;
			this.Fond_Noir.Location = new System.Drawing.Point(80, 32);
			this.Fond_Noir.Name = "Fond_Noir";
			this.Fond_Noir.Size = new System.Drawing.Size(48, 24);
			this.Fond_Noir.TabIndex = 3;
			this.Fond_Noir.Text = "Noir";
			this.Fond_Noir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Dimensions
			/  
			this.Dimensions.BackColor = System.Drawing.SystemColors.Control;
			this.Dimensions.Controls.Add(this.Height_Perso);
			this.Dimensions.Controls.Add(this.Width_Perso);
			this.Dimensions.Controls.Add(this.lbl_H);
			this.Dimensions.Controls.Add(this.lbl_W);
			this.Dimensions.Controls.Add(this.Dim_pred);
			this.Dimensions.Controls.Add(this.Perso);
			this.Dimensions.Controls.Add(this.Predef);
			this.Dimensions.Location = new System.Drawing.Point(8, 8);
			this.Dimensions.Name = "Dimensions";
			this.Dimensions.Size = new System.Drawing.Size(400, 136);
			this.Dimensions.TabIndex = 3;
			this.Dimensions.TabStop = false;
			this.Dimensions.Text = "Dimensions";
			/  
			/  Height_Perso
			/  
			this.Height_Perso.Enabled = false;
			this.Height_Perso.Location = new System.Drawing.Point(304, 104);
			this.Height_Perso.Maximum = new System.Decimal(new int[] {
		                 99,
		                 0,
		                 0                       });
			this.Height_Perso.Minimum = new System.Decimal(new int[] {
		                 1,
		                 0,
		                 0                       });
			this.Height_Perso.Name = "Height_Perso";
			this.Height_Perso.Size = new System.Drawing.Size(56, 20);
			this.Height_Perso.TabIndex = 6;
			this.Height_Perso.ThousandsSeparator = true;
			this.Height_Perso.Value = new System.Decimal(new int[] {
		                  1,
		                  0,
		                  0                        });
			/  
			/  Width_Perso
			/  
			this.Width_Perso.Enabled = false;
			this.Width_Perso.Location = new System.Drawing.Point(304, 64);
			this.Width_Perso.Maximum = new System.Decimal(new int[] {
		                99,
		                0,
		                0                      });
			this.Width_Perso.Minimum = new System.Decimal(new int[] {
		                1,
		                0,
		                0                      });
			this.Width_Perso.Name = "Width_Perso";
			this.Width_Perso.Size = new System.Drawing.Size(56, 20);
			this.Width_Perso.TabIndex = 5;
			this.Width_Perso.ThousandsSeparator = true;
			this.Width_Perso.Value = new System.Decimal(new int[] {
		                 1,
		                 0,
		                 0                       });
			/  
			/  lbl_H
			/  
			this.lbl_H.AutoSize = true;
			this.lbl_H.Enabled = false;
			this.lbl_H.Location = new System.Drawing.Point(184, 104);
			this.lbl_H.Name = "lbl_H";
			this.lbl_H.Size = new System.Drawing.Size(94, 16);
			this.lbl_H.TabIndex = 4;
			this.lbl_H.Text = "Hauteur (Height) :";
			/  
			/  lbl_W
			/  
			this.lbl_W.AutoSize = true;
			this.lbl_W.Enabled = false;
			this.lbl_W.Location = new System.Drawing.Point(184, 64);
			this.lbl_W.Name = "lbl_W";
			this.lbl_W.Size = new System.Drawing.Size(89, 16);
			this.lbl_W.TabIndex = 3;
			this.lbl_W.Text = "Largeur (Width) :";
			/  
			/  Dim_pred
			/  
			this.Dim_pred.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Dim_pred.Location = new System.Drawing.Point(24, 80);
			this.Dim_pred.Name = "Dim_pred";
			this.Dim_pred.Size = new System.Drawing.Size(136, 21);
			this.Dim_pred.TabIndex = 2;
			/  
			/  Perso
			/  
			this.Perso.Location = new System.Drawing.Point(216, 24);
			this.Perso.Name = "Perso";
			this.Perso.Size = new System.Drawing.Size(152, 16);
			this.Perso.TabIndex = 1;
			this.Perso.Text = "Dimensions Personnalisées";
			this.Perso.CheckedChanged += new System.EventHandler(this.Perso_Check);
			/  
			/  Predef
			/  
			this.Predef.Checked = true;
			this.Predef.Location = new System.Drawing.Point(24, 24);
			this.Predef.Name = "Predef";
			this.Predef.Size = new System.Drawing.Size(136, 16);
			this.Predef.TabIndex = 0;
			this.Predef.TabStop = true;
			this.Predef.Text = "Dimensions Prédéfinies";
			this.Predef.CheckedChanged += new System.EventHandler(this.Predef_Check);
			/  
			/  Warning
			/  
			this.Warning.Location = new System.Drawing.Point(416, 24);
			this.Warning.Name = "Warning";
			this.Warning.Size = new System.Drawing.Size(200, 104);
			this.Warning.TabIndex = 4;
			this.Warning.Text = "Attention !\n\nSi vous choisissez des dimensions pérsonalisées;\n\nVeillez à respecte" +      "z les proportions de l\'image d\'origine.";
			this.Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Warning.UseMnemonic = false;
			this.Warning.Visible = false;
			/  
			/  Color_Q
			/  
			this.Color_Q.BackColor = System.Drawing.SystemColors.Control;
			this.Color_Q.Controls.Add(this.Nbre_Cotons);
			this.Color_Q.Controls.Add(this.Limit_Nbre);
			this.Color_Q.Controls.Add(this.Couleur);
			this.Color_Q.Controls.Add(this.Monochrom);
			this.Color_Q.Controls.Add(this.Fond);
			this.Color_Q.Location = new System.Drawing.Point(8, 152);
			this.Color_Q.Name = "Color_Q";
			this.Color_Q.Size = new System.Drawing.Size(584, 168);
			this.Color_Q.TabIndex = 5;
			this.Color_Q.TabStop = false;
			this.Color_Q.Text = "Type de Diagramme";
			/  
			/  Nbre_Cotons
			/  
			this.Nbre_Cotons.Enabled = false;
			this.Nbre_Cotons.Location = new System.Drawing.Point(88, 136);
			this.Nbre_Cotons.Maximum = new System.Decimal(new int[] {
		                441,
		                0,
		                0                      });
			this.Nbre_Cotons.Name = "Nbre_Cotons";
			this.Nbre_Cotons.Size = new System.Drawing.Size(56, 20);
			this.Nbre_Cotons.TabIndex = 6;
			this.Nbre_Cotons.Value = new System.Decimal(new int[] {
		                 50,
		                 0,
		                 0                       });
			/  
			/  Limit_Nbre
			/  
			this.Limit_Nbre.Location = new System.Drawing.Point(16, 104);
			this.Limit_Nbre.Name = "Limit_Nbre";
			this.Limit_Nbre.Size = new System.Drawing.Size(128, 40);
			this.Limit_Nbre.TabIndex = 7;
			this.Limit_Nbre.Text = "Limiter le nombre de cotons";
			this.Limit_Nbre.CheckedChanged += new System.EventHandler(this.Limit_Nbre_CkeckedChanged);
			/  
			/  Couleur
			/  
			this.Couleur.Checked = true;
			this.Couleur.Location = new System.Drawing.Point(16, 56);
			this.Couleur.Name = "Couleur";
			this.Couleur.Size = new System.Drawing.Size(72, 24);
			this.Couleur.TabIndex = 4;
			this.Couleur.TabStop = true;
			this.Couleur.Text = "Couleur";
			this.Couleur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Couleur.CheckedChanged += new System.EventHandler(this.Couleur_CheckedChanged);
			/  
			/  Monochrom
			/  
			this.Monochrom.Location = new System.Drawing.Point(16, 24);
			this.Monochrom.Name = "Monochrom";
			this.Monochrom.Size = new System.Drawing.Size(120, 24);
			this.Monochrom.TabIndex = 3;
			this.Monochrom.Text = "Monochromatique";
			this.Monochrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Monochrom.CheckedChanged += new System.EventHandler(this.Monochrom_CheckedChanged);
			/  
			/  Define_Grille
			/  
			this.Controls.Add(this.Color_Q);
			this.Controls.Add(this.Warning);
			this.Controls.Add(this.Dimensions);
			this.Name = "Define_Grille";
			this.Size = new System.Drawing.Size(624, 328);
			this.Fond.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
			this.Dimensions.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Height_Perso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Width_Perso)).EndInit();
			this.Color_Q.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Nbre_Cotons)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		internal void Predef_Check(object sender, System.EventArgs e)
		{
			if(Predef.Checked)
			{
				this.Height_Perso.Enabled = false;
				this.Width_Perso.Enabled = false;
				this.lbl_H.Enabled = false;
				this.lbl_W.Enabled = false;
				this.Dim_pred.Enabled = true;
				this.Warning.Visible = false;
			}
		}

		internal void Perso_Check(object sender, System.EventArgs e)
		{
			if(Perso.Checked)
			{
				this.Height_Perso.Enabled = true;
				this.Width_Perso.Enabled = true;
				this.lbl_H.Enabled = true;
				this.lbl_W.Enabled = true;
				this.Dim_pred.Enabled = false;
				this.Warning.Visible = true;
				MessageBox.Show("Si vous choisissez des dimensions pérsonalisées;\n\nVeillez à respectez les proportions de l\'image d\'origine.","Attention !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}
		}
		
		private void Fond_Perso_Check(object sender, System.EventArgs e)
		{
			if(Fond_Perso.Checked)
			{
				Test_Fond.Enabled = true;
				lbl_R.Enabled = true;
				lbl_G.Enabled = true;
				lbl_B.Enabled = true;
				Red.Enabled = true;
				Green.Enabled = true;
				Blue.Enabled = true;
			}
			else
			{
				Test_Fond.Enabled = false;
				lbl_R.Enabled = false;
				lbl_G.Enabled = false;
				lbl_B.Enabled = false;
				Red.Enabled = false;
				Green.Enabled = false;
				Blue.Enabled = false;
                Fond_Perso.BackColor = Color.FromName("Control");
			}
		}
		
		private void Test_Fond_Click(object sender, System.EventArgs e)
		{
			int R = (int)Red.Value;
			int G = (int)Green.Value;
			int B = (int)Blue.Value;
			try{Fond_Perso.BackColor=Color.FromArgb(R,G,B);}
			catch (Exception) {MessageBox.Show("Désolé; Cette couleur n'est pas disponible...","Désolé !",MessageBoxButtons.OK,MessageBoxIcon.Information);}
		}
		
		private void Fond_Help_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(      "L'ordinateur caractérise une couleur d'après trois valeurs :\n\nLes quantités de Ble" +      "u, Rouge et Vert.\nCes valeurs varient de '0' à '255';\n\n\nSi aucune des couleurs pro" +      "posées (Blanc, Noir, Bleu, Rouge et Vert) ne correspondent au fond de votre image;\nVo" +      "us pouvez en choisir une de votre choix en faisant varier les trois valeurs.\n\nCliquez" +      " sur 'Aperçu' pour voir la couleur que vous avez demandée...\n\n    (À titre indicat" +      "if, Voici les codes de quelques couleurs; [notation : Rouge;Vert;Bleu]) :\n\nBlanc : '2" +      "55;255;2  '\nNoir : '0;0; '\nBleu : '0;0;2  '\nRouge : '2  ;0; '\nVert : '0;2  ; '",      "Aide pour la Couleur du Fond de l'image",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		private void Couleur_CheckedChanged(object sender, System.EventArgs e)
		{
			if(Couleur.Checked)
			{
				Monochrom.Checked = false;
				Limit_Nbre.Enabled = true;
				Limit_Nbre_CkeckedChanged(sender,e);
			}
		}

		private void Monochrom_CheckedChanged(object sender, System.EventArgs e)
		{
			if(Monochrom.Checked)
			{
				Couleur.Checked = false;
				Limit_Nbre.Enabled = false;
				Nbre_Cotons.Enabled = false;
			}
		}

		private void Limit_Nbre_CkeckedChanged(object sender, System.EventArgs e)
		{
		 if(Limit_Nbre.Checked)
			 Nbre_Cotons.Enabled = true;
		else
			 Nbre_Cotons.Enabled = false;
		}
	}
}

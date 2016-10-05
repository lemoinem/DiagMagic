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
	public class Grille : System.Windows.Forms.UserControl
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		#region Composants
			private System.ComponentModel.IContainer components = null;
			protected internal System.Windows.Forms.PictureBox Diag;
		protected internal System.Windows.Forms.Label Lbl_Nbre_Leg;
		protected internal System.Windows.Forms.NumericUpDown Nbre_Leg;
			protected internal System.Windows.Forms.Label Look_Down;
		#endregion

		#region "public Grille()" & "prtected override void Dispose(bool)"
		public Grille()
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
		#endregion

		#region Code généré par le concepteur WinForm (Init_Comp) [No Modif]
		//  <summary>
		//  Méthode requise pour la gestion du concepteur  - ne pas modifier 
		//  le contenu de cette méthode avec l'éditeur de code.
		//  </summary>
		private void InitializeComponent()
		{
			this.Look_Down = new System.Windows.Forms.Label();
			this.Diag = new System.Windows.Forms.PictureBox();
			this.Lbl_Nbre_Leg = new System.Windows.Forms.Label();
			this.Nbre_Leg = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.Nbre_Leg)).BeginInit();
			this.SuspendLayout();
			/  
			/  Look_Down
			/  
			this.Look_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Look_Down.BackColor = System.Drawing.Color.Transparent;
			this.Look_Down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Look_Down.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Look_Down.Location = new System.Drawing.Point(528, 8);
			this.Look_Down.Name = "Look_Down";
			this.Look_Down.Size = new System.Drawing.Size(72, 80);
			this.Look_Down.TabIndex = 4;
			this.Look_Down.Text = "Si vous ne voyez pas les boutons,\n\nregardez en bas.. ";
			this.Look_Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Diag
			/  
			this.Diag.Location = new System.Drawing.Point(8, 8);
			this.Diag.Name = "Diag";
			this.Diag.Size = new System.Drawing.Size(512, 392);
			this.Diag.TabIndex = 5;
			this.Diag.TabStop = false;
			/  
			/  Lbl_Nbre_Leg
			/  
			this.Lbl_Nbre_Leg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Lbl_Nbre_Leg.AutoSize = true;
			this.Lbl_Nbre_Leg.Location = new System.Drawing.Point(8, 424);
			this.Lbl_Nbre_Leg.Name = "Lbl_Nbre_Leg";
			this.Lbl_Nbre_Leg.Size = new System.Drawing.Size(509, 16);
			this.Lbl_Nbre_Leg.TabIndex = 6;
			this.Lbl_Nbre_Leg.Text = "Nombre de colones de légendes : (a diminuer si l\'image contient un log rectalngle" +      " noir sur la droite.. )";
			this.Lbl_Nbre_Leg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Nbre_Leg
			/  
			this.Nbre_Leg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Nbre_Leg.Location = new System.Drawing.Point(520, 424);
			this.Nbre_Leg.Maximum = new System.Decimal(new int[] {
		                10,
		                0,
		                                       });
			this.Nbre_Leg.Name = "Nbre_Leg";
			this.Nbre_Leg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Nbre_Leg.Size = new System.Drawing.Size(64, 20);
			this.Nbre_Leg.TabIndex = 7;
			this.Nbre_Leg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Nbre_Leg.Value = new System.Decimal(new int[] {
		                 10,
		                 0,
		                                         });
			this.Nbre_Leg.ValueChanged += new System.EventHandler(this.Nbre_Leg_Changed);
			/  
			/  Grille
			/  
			this.AutoScroll = true;
			this.Controls.Add(this.Nbre_Leg);
			this.Controls.Add(this.Lbl_Nbre_Leg);
			this.Controls.Add(this.Diag);
			this.Controls.Add(this.Look_Down);
			this.Name = "Grille";
			this.Size = new System.Drawing.Size(608, 456);
			((System.ComponentModel.ISupportInitialize)(this.Nbre_Leg)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Event Nbre_Leg_Changed
		private void Nbre_Leg_Changed(object sender, System.EventArgs e)
		{
			Size new_size = this.Diag.Size;
			new_size.Width = (int)(this.Diag.Image.Width - 130*(10-this.Nbre_Leg.Value));
			this.Diag.Size = new_size;
			Size Marge = this.Look_Down.Size;
			Marge.Height = Marge.Height + 30;
			Marge.Width = Marge.Width + 30;
			this.Size = this.Diag.Size + Marge;
		}
		#endregion
	}
}

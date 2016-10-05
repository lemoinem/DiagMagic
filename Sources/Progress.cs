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
	public class Progress : System.Windows.Forms.UserControl
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		private System.ComponentModel.Container components = null;
		protected internal System.Windows.Forms.ProgressBar Progress_Bar;
		private System.Windows.Forms.GroupBox Wait_Please;

		public Progress()
		{
			// Cet appel est requis par le concepteur Windows.Forms.
			InitializeComponent();

			// TODO: Ajouter le code d'initialisation après l'appel de InitForm

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
			this.Progress_Bar = new System.Windows.Forms.ProgressBar();
			this.Wait_Please = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// Progress_Bar
			// 
			this.Progress_Bar.Cursor = System.Windows.Forms.Cursors.AppStarting;
			this.Progress_Bar.Location = new System.Drawing.Point(16, 48);
			this.Progress_Bar.Name = "Progress_Bar";
			this.Progress_Bar.Size = new System.Drawing.Size(392, 24);
			this.Progress_Bar.TabIndex = 1;
			// 
			// Wait_Please
			// 
			this.Wait_Please.Location = new System.Drawing.Point(8, 16);
			this.Wait_Please.Name = "Wait_Please";
			this.Wait_Please.Size = new System.Drawing.Size(408, 72);
			this.Wait_Please.TabIndex = 2;
			this.Wait_Please.TabStop = false;
			this.Wait_Please.Text = "Veuillez Patienter pendant la conversion de l\'image.. ";
			// 
			// Progress
			// 
			this.BackColor = System.Drawing.Color.LightCoral;
			this.Controls.Add(this.Progress_Bar);
			this.Controls.Add(this.Wait_Please);
			this.Name = "Progress";
			this.Size = new System.Drawing.Size(424, 96);
			this.ResumeLayout(false);
		}
		#endregion
	}
}

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
	public class Start : System.Windows.Forms.UserControl
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		private System.ComponentModel.IContainer components = null;
		protected internal System.Windows.Forms.PictureBox Image;
		protected internal System.Windows.Forms.Label Look_Down;

		public Start()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Start));
			this.Image = new System.Windows.Forms.PictureBox();
			this.Look_Down = new System.Windows.Forms.Label();
			this.SuspendLayout();
			/  
			/  Image
			/  
			this.Image.BackColor = System.Drawing.Color.Azure;
			this.Image.Cursor = System.Windows.Forms.Cursors.Default;
			this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
			this.Image.Location = new System.Drawing.Point(16, 16);
			this.Image.Name = "Image";
			this.Image.Size = new System.Drawing.Size(64, 64);
			this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Image.TabIndex = 2;
			this.Image.TabStop = false;
			/  
			/  Look_Down
			/  
			this.Look_Down.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Look_Down.BackColor = System.Drawing.Color.Transparent;
			this.Look_Down.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Look_Down.Location = new System.Drawing.Point(528, 8);
			this.Look_Down.Name = "Look_Down";
			this.Look_Down.Size = new System.Drawing.Size(72, 80);
			this.Look_Down.TabIndex = 3;
			this.Look_Down.Text = "Si vous ne voyez pas les boutons,\n\nregardez en bas.. ";
			this.Look_Down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Start
			/  
			this.AutoScroll = true;
			this.Controls.Add(this.Look_Down);
			this.Controls.Add(this.Image);
			this.Name = "Start";
			this.Size = new System.Drawing.Size(608, 416);
			this.ResumeLayout(false);

		}
		#endregion
	}
}

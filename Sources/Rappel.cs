using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DiagMagic
{
	//  <summary>
	//  Description Résumé de WinForm1.
	//  </summary>
	public class Rappel : System.Windows.Forms.Form
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.PictureBox Image;
		private Dacris.NETXP.Controls.XPButton OK;
		private Image Img;

		public Rappel(Image IMG)
		{
			//
			// Requis pour la gestion du concepteur Windows Form
			//
			Img = IMG;
			InitializeComponent();
			//
			// TODO: Ajouter tout le code du constructeur après l'appel de InitializeComponent
			//
		}

		//  <summary>
		//  Nettoyage des ressources utilisées.
		//  </summary>
		protected override void Dispose (bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
   base.Dispose(disposing);
		}

		#region Code généré par le concepteur Windows Form
		//  <summary>
		//  Méthode requise pour la gestion du concepteur - ne pas modifier
		//  le contenu de cette méthode avec l'éditeur de code.
		//  </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Rappel));
			this.Image = new System.Windows.Forms.PictureBox();
			this.OK = new Dacris.NETXP.Controls.XPButton();
			this.SuspendLayout();
			// 
			// Image
			// 
			this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
			this.Image.Location = new System.Drawing.Point(8, 8);
			this.Image.Name = "Image";
			this.Image.Size = new System.Drawing.Size(99, 99);
			this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Image.TabIndex = 0;
			this.Image.TabStop = false;
			// 
			// OK
			// 
			this.OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.OK.Location = new System.Drawing.Point(22, 120);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(64, 24);
			this.OK.TabIndex = 1;
			this.OK.Text = "&OK";
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// Rappel
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(112, 146);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.Image);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Rappel";
			this.ShowInTaskbar = false;
			this.Text = "Rappel de l\'image";
			this.Load += new System.EventHandler(this.On_Load);
			this.ResumeLayout(false);

		}
		#endregion
		
		private void OK_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		
		private void On_Load(object sender, System.EventArgs e)
		{
			this.Image.Image = Img;
		}
	}
}

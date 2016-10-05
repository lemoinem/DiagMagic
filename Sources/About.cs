using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Diagnostics;

namespace DiagMagic //À remplacer par le namsespace de l'Application
{
/*
	Pour utiliser ce Form; écrire dans une Method :
	{
		Who About = new Who();
		About.Icon = this.Icon;
		About.Img.Image = this.Img.Image;
		About.ShowDialog();
	}
	this.Img doit contenir l'icône au format 64*64 
*/
	//  <summary>
	//  Description Résumé de WinForm.
	//  </summary>
	public class About : System.Windows.Forms.Form
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label Product;
		protected internal System.Windows.Forms.PictureBox Img;
		private System.Windows.Forms.Label Version;
		private System.Windows.Forms.Label Ver;
		private System.Windows.Forms.Label Copy;
		private System.Windows.Forms.Label Copyright;
		private System.Windows.Forms.Label Sté;
		private System.Windows.Forms.LinkLabel Enterprise;
		private Dacris.NETXP.Controls.XPButton OK;
		private System.Windows.Forms.LinkLabel MathLem;
        private Dacris.NETXP.Controls.XPButton Licence;

		public About()
		{
			/ 
			/  Requis pour la gestion du concepteur Windows Form
			/ 
			InitializeComponent();

			/ 
			/  TODO: Ajouter tout le code du constructeur après l'appel de InitializeComponent
			/ 
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
			this.Product = new System.Windows.Forms.Label();
			this.Img = new System.Windows.Forms.PictureBox();
			this.Version = new System.Windows.Forms.Label();
			this.Ver = new System.Windows.Forms.Label();
			this.Copy = new System.Windows.Forms.Label();
			this.Copyright = new System.Windows.Forms.Label();
			this.Sté = new System.Windows.Forms.Label();
			this.Enterprise = new System.Windows.Forms.LinkLabel();
			this.OK = new Dacris.NETXP.Controls.XPButton();
			this.MathLem = new System.Windows.Forms.LinkLabel();
			this.Licence = new Dacris.NETXP.Controls.XPButton();
			this.SuspendLayout();
			/  
			/  Product
			/  
			this.Product.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Product.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Product.Font = new System.Drawing.Font("Batang", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)) ;
			this.Product.Location = new System.Drawing.Point(80, 28 ;
			this.Product.Name = "Product";
			this.Product.Size = new System.Drawing.Size(204, 24);
			this.Product.TabIndex = 0;
			this.Product.Text = "PRODUCT";
			this.Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Img
			/  
			this.Img.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Img.Location = new System.Drawing.Point(8, 8);
			this.Img.Name = "Img";
			this.Img.Size = new System.Drawing.Size(64, 64);
			this.Img.TabIndex = 1;
			this.Img.TabStop = false;
			this.Img.Text = "Icon !!";
			/  
			/  Version
			/  
			this.Version.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Version.AutoSize = true;
			this.Version.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Version.Location = new System.Drawing.Point(128, 80);
			this.Version.Name = "Version";
			this.Version.Size = new System.Drawing.Size(55, 16);
			this.Version.TabIndex = 2;
			this.Version.Text = "VERSION";
			this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Ver
			/  
			this.Ver.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Ver.AutoSize = true;
			this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Ver.Location = new System.Drawing.Point(45, 80);
			this.Ver.Name = "Ver";
			this.Ver.Size = new System.Drawing.Size(49, 16);
			this.Ver.TabIndex = 3;
			this.Ver.Text = "Version :";
			this.Ver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Copy
			/  
			this.Copy.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Copy.AutoSize = true;
			this.Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Copy.Location = new System.Drawing.Point(40, 152);
			this.Copy.Name = "Copy";
			this.Copy.Size = new System.Drawing.Size(59, 16);
			this.Copy.TabIndex = 5;
			this.Copy.Text = "Copyright :";
			this.Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Copyright
			/  
			this.Copyright.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Copyright.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Copyright.Location = new System.Drawing.Point(112, 152);
			this.Copyright.Name = "Copyright";
			this.Copyright.Size = new System.Drawing.Size(152, 64);
			this.Copyright.TabIndex = 4;
			this.Copyright.Text = "© Copyright\nGLYS Informatique\n2003-2004\n\nMathieu Lemoine";
			this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Copyright.UseMnemonic = false;
			/  
			/  Sté
			/  
			this.Sté.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Sté.AutoSize = true;
			this.Sté.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Sté.Location = new System.Drawing.Point(38, 112);
			this.Sté.Name = "Sté";
			this.Sté.Size = new System.Drawing.Size(62, 16);
			this.Sté.TabIndex = 7;
			this.Sté.Text = "Entreprise :";
			this.Sté.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			/  
			/  Enterprise
			/  
			this.Enterprise.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Enterprise.AutoSize = true;
			this.Enterprise.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.Enterprise.Location = new System.Drawing.Point(128, 112);
			this.Enterprise.Name = "Enterprise";
			this.Enterprise.TabIndex = 6;
			this.Enterprise.TabStop = true;
			this.Enterprise.Text = "GLYS Informatique";
			this.Enterprise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Enterprise.Click += new System.EventHandler(this.Enterprise_Click);
			/  
			/  OK
			/  
			this.OK.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OK.Location = new System.Drawing.Point(96, 256);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(64, 24);
			this.OK.TabIndex = 8;
			this.OK.Text = "OK";
			this.OK.Click += new System.EventHandler(this.OK_CLick);
			/  
			/  MathLem
			/  
			this.MathLem.Location = new System.Drawing.Point(128, 200);
			this.MathLem.Name = "MathLem";
			this.MathLem.Size = new System.Drawing.Size(120, 16);
			this.MathLem.TabIndex = 9;
			this.MathLem.TabStop = true;
			this.MathLem.Text = "Mathieu Lemoine";
			this.MathLem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.MathLem.Click += new System.EventHandler(this.MathLem_Click);
			/  
			/  Licence
			/  
			this.Licence.Location = new System.Drawing.Point(24, 200);
			this.Licence.Name = "Licence";
			this.Licence.Size = new System.Drawing.Size(80, 24);
			this.Licence.TabIndex = 10;
			this.Licence.Text = "Licence";
			this.Licence.Click += new System.EventHandler(this.Licence_Click);
			/  
			/  About
			/  
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 286);
			this.Controls.Add(this.Licence);
			this.Controls.Add(this.MathLem);
			this.Controls.Add(this.Product);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.Sté);
			this.Controls.Add(this.Enterprise);
			this.Controls.Add(this.Copy);
			this.Controls.Add(this.Ver);
			this.Controls.Add(this.Version);
			this.Controls.Add(this.Copyright);
			this.Controls.Add(this.Img);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.ShowInTaskbar = false;
			this.Text = "À Propos de";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.OnLoad);
			this.ResumeLayout(false);

		}
		#endregion
		
		private void OnLoad(object sender, System.EventArgs e)
		{
			string FullName = Assembly.GetExecutingAssembly().FullName;
			string Name = FullName.Substring(0,FullName.IndexOf(','));
			this.Text = "À Propos de " + Name;
			this.Product.Text = Name;
            int length = FullName.IndexOf(',',FullName.IndexOf('=')) - FullName.IndexOf('=') - 1; 
			string Version = FullName.Substring(FullName.IndexOf('=')+1,length);
			this.Version.Text = Version;
		}

		private void OK_CLick(object sender, System.EventArgs e)
		{
		/**/this.Close();//*/Application.Exit();//Ajouter une étoile après la première

		}

		private void MathLem_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Vous pouvez contacter Mathieu Lemoine à l'Adresse Suivante :\n\n\nÀ l'attention de M. Mathieu Lemoine\nGLYS Informatique\n2 chemin des aubes\n13940 Mollégès\n\nOu aux numéros suivants :\n06.87.59.16.09\nEt\n04.32.61.05.26\n\nEn dehors des Heures de cours.. \n;)","Coordonnées de Mathieu Lemoine",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
			
		private void Licence_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(      "La distribution, l\'installation et l\'utilisation de " + '"' + "Master Mind" + '"' + " sont soumis à l'accord de la présente licence :\n\n\n" +      '"' + "Master Mind" + '"' +      " est un FreeWare : Vous pouvez le copiez et le distribuer gratuitement comme bon vous semble, à condition de ne pas le modifier, ni le programme, ni le programme d'instalation; et de faire figurer les informations telles que la présente licence et le Copyright avec." +      "\nSi vous pouviez tout de même nous envoyer un mail (à 'GLYS-Informatique@fr.st') pour nous dire ce que vous pensez de ce logiciel...\n\nMecri d'Avance...\n\nGLYS Informatique",      "Licence",      MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void Enterprise_Click(object sender, System.EventArgs e)
		{
			Process GLYS = new Process();
			GLYS.StartInfo.FileName = "http://ww .GLYS.fr.st";
			GLYS.Start();
		}

	#region Need For EXE
		/*// À faire Passe en Commentaire en retirant la seconde étoile de cette ligne.
			static void Main()
			{
				Application.Run(new About());
			}
		/**/
	#endregion
		
	}
}

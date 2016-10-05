using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Microsoft.Win32;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace DiagMagic
{
	//  <summary>
	/  Description Résumé de WinForm.
	//  </summary>
  	public class MainForm : System.Windows.Forms.Form
	{
		//  <summary>
		//  Variable requise par le concepteur.
		//  </summary>
		#region Composants

			//Container
			private System.ComponentModel.IContainer components;

			#region Copmosants Utilisateur
		   		private DiagMagic.Start Start_Panel;
				private DiagMagic.Define_Grille Define_Grille_Panel;
				private DiagMagic.Grille Grille_Panel;
				private DiagMagic.Progress Progress_Panel;
			#endregion

			#region Composants Personnels
				private System.Drawing.Image Image_Init = null; //Image Vide
				private File_Gest Filer = File_Gest.Empty; //Gestionnaire de Fichier
				private System.Resources.ResourceManager Bitmaps = new System.Resources.ResourceManager("Bitmaps",System.Reflection.Assembly.LoadFile("F:\\Windows\\System32\\Diag Magic.resources.dll")); //Ressources
				/*Resizer*/
					private System.Windows.Forms.PictureBox Img;
					private System.Windows.Forms.PictureBox Resizer;
				/*Tableaux pour les cotons*/
					double[] Couleurs = DMC.Couleurs;
					string[] Names = DMC.Names;
			#endregion

			#region Menu
				//MyMainMenu
				private System.Windows.Forms.MainMenu MyMainMenu;
				private System.Windows.Forms.MenuItem File;
				private System.Windows.Forms.MenuItem Open_File;
				private System.Windows.Forms.MenuItem Save_File;
				private System.Windows.Forms.MenuItem Save     _As;
				private System.Windows.Forms.MenuItem Print;
				private System.Windows.Forms.MenuItem Sep;
				private System.Windows.Forms.MenuItem Quit_App;
				private System.Windows.Forms.MenuItem Reduice;

				//SysTrayMenu
				private System.Windows.Forms.ContextMenu SysTrayMenu;
				private System.Windows.Forms.MenuItem Show_App;
				private System.Windows.Forms.MenuItem Quit_Tray;

				//ProgressMenu
				private System.Windows.Forms.MenuItem ProgressMenu;

				//Menu ?
				private System.Windows.Forms.MenuItem Help;
				private System.Windows.Forms.MenuItem About;
				private System.Windows.Forms.MenuItem Sep2;
				private System.Windows.Forms.MenuItem Aide;

			#endregion

			#region Bouttons
				private Dacris.NETXP.Controls.XPButton Next;
				private Dacris.NETXP.Controls.XPButton Back;
				private Dacris.NETXP.Controls.XPButton Save_Grille;
				private Dacris.NETXP.Controls.XPButton Print_Grille;
			#endregion

			#region Autres Composants
				//SysTray
				private System.Windows.Forms.NotifyIcon SysTray;

				//Open Image Dialogue
				private System.Windows.Forms.Open    Dialog OpenImg;

				//Save Grille Dialogue
				private System.Windows.Forms.Save    Dialog SaveGrille;

                //Open Help Dialogue
				private System.Windows.Forms.Open    Dialog OpenHelp;
				
				/*Printer*/
					private System.Drawing.Printing.PrintDocument Printer;
					private System.Windows.Forms.PrintDialog Dialog_Printer;

                //Légende
				private System.Windows.Forms.ListBox Leg;
			#endregion

		#endregion

  #region "public MainForm" & "protected override void Dispose (bool)"
  public MainForm()
		{
			//
			// Requis pour la gestion du concepteur Windows Form
			//
			InitializeComponent();
			//
			// Ajouter tout le code du constructeur après l'appel de InitializeComponent
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
		#endregion

  #region Code généré par le concepteur WinForm {Init_Comp} [No Modif]
		//  <summary>
		//  Méthode requise pour la gestion du concepteur - ne pas modifier
		//  le contenu de cette méthode avec l'éditeur de code.
		//  </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.MyMainMenu = new System.Windows.Forms.MainMenu();
			this.     = new System.Windows.Forms.MenuItem();
			this.Open_     = new System.Windows.Forms.MenuItem();
			this.Save_     = new System.Windows.Forms.MenuItem();
			this.Save     _As = new System.Windows.Forms.MenuItem();
			this.Print = new System.Windows.Forms.MenuItem();
			this.Sep = new System.Windows.Forms.MenuItem();
			this.Quit_App = new System.Windows.Forms.MenuItem();
			this.Reduice = new System.Windows.Forms.MenuItem();
			this.Help = new System.Windows.Forms.MenuItem();
			this.Aide = new System.Windows.Forms.MenuItem();
			this.Sep2 = new System.Windows.Forms.MenuItem();
			this.About = new System.Windows.Forms.MenuItem();
			this.ProgressMenu = new System.Windows.Forms.MenuItem();
			this.OpenImg = new System.Windows.Forms.Open    Dialog();
			this.SaveGril   = new System.Windows.Forms.Save    Dialog();
			this.Next = new Dacris.NETXP.Controls.XPButton();
			this.SysTray = new System.Windows.Forms.NotifyIcon(this.components);
			this.SysTrayMenu = new System.Windows.Forms.ContextMenu();
			this.Show_App = new System.Windows.Forms.MenuItem();
			this.Quit_Tray = new System.Windows.Forms.MenuItem();
			this.Define_Grille_Panel = new DiagMagic.Define_Grille();
			this.Grille_Panel = new DiagMagic.Grille();
			this.Back = new Dacris.NETXP.Controls.XPButton();
			this.Save_Grille = new Dacris.NETXP.Controls.XPButton();
			this.Progress_Panel = new DiagMagic.Progress();
			this.Img = new System.Windows.Forms.PictureBox();
			this.Start_Panel = new DiagMagic.Start();
			this.OpenHelp = new System.Windows.Forms.Open    Dialog();
			this.Resizer = new System.Windows.Forms.PictureBox();
			this.Leg = new System.Windows.Forms.ListBox();
			this.Print_Grille = new Dacris.NETXP.Controls.XPButton();
			this.Printer = new System.Drawing.Printing.PrintDocument();
			this.Dialog_Printer = new System.Windows.Forms.PrintDialog();
			this.SuspendLayout();
			// 
			// MyMainMenu
			// 
			this.MyMainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
					                   this.    ,
					                   this.Reduic ,
					                   this.Help,
					                   this.ProgressMenu});
			// 
			//     
			// 
			this.    .Index = 0;
			this.    .MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
					                this.Open_    ,
					                this.Save_    ,
					                this.Save     _As,
					                this.Print,
					                this.Sep,
					                this.Quit_App});
			this.    .Text = "&    ";
			// 
			// Open_    
			// 
			this.Open_    .Index = 0;
			this.Open_    .Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.Open_    .Text = "&Ouvrir";
			this.Open_    .Click += new System.EventHandler(this.Open_    _Click);
			// 
			// Save     
			// 
			this.Save     .Enabled = false;
			this.Save     .Index = 1;
			this.Save_    .Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.Save_    .Text = "&Enregistrer";
			this.Save_    .Click += new System.EventHandler(this.Save_    _Click);
			// 
			// Save     _As
			// 
			this.Save     _As.Enabled = false;
			this.Save     _As.Index = 2;
			this.Save     _As.Shortcut = System.Windows.Forms.Shortcut.F12;
			this.Save     _As.Text = "Enregistrer so&us.. ";
			this.Save     _As.Click += new System.EventHandler(this.Save_    _As_Click);
			// 
			// Print
			// 
			this.Print.Enabled = false;
			this.Print.Index = 3;
			this.Print.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.Print.Text = "Im&primer";
			// 
			// Sep
			// 
			this.Sep.Index = 4;
			this.Sep.Text = "-";
			// 
			// Quit_App
			// 
			this.Quit_App.Index = 5;
			this.Quit_App.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.Quit_App.Text = "&Quitter";
			this.Quit_App.Click += new System.EventHandler(this.Quit_App_Click);
			// 
			// Reduic 
			// 
			this.Reduic .Index = 1;
			this.Reduic .Text = "&Réduire";
			this.Reduic .Click += new System.EventHandler(this.Reduic _Click);
			// 
			// Help
			// 
			this.Help.Index = 2;
			this.Help.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
					                this.Aide,
					                this.Sep2,
					                this.About});
			this.Help.Text = "&?";
			// 
			// Aide
			// 
			this.Aid .Index = 0;
			this.Aid .Shortcut = System.Windows.Forms.Shortcut.F1;
			this.Aid .Text = "&Aid ";
			this.Aid .Click += new System.EventHandler(this.Help_Click);
			// 
			// Sep2
			// 
			this.Sep2.Index = 1;
			this.Sep2.Text = "-";
			// 
			// About
			// 
			this.About.Index = 2;
			this.About.Shortcut = System.Windows.Forms.Shortcut.CtrlF1;
			this.About.Text = "À Pro&pos de \"DiagMagic\"";
			this.About.Click += new System.EventHandler(this.About_Click);
			// 
			// ProgressMenu
			// 
			this.ProgressMenu.Index = 3;
			this.ProgressMenu.Text = "Veuillez Patienter pendant la conversion de l\'Image..  (0%)";
			this.ProgressMenu.Visible = false;
			// 
			// OpenImg
			// 
			this.OpenImg.DefaultExt = "*.bmp;*.jpg";
			this.OpenImg.   ter = "Toutes les Images (.jpg;.bmp)|*.jpg;*.bmp|Toutes les Images Bitmap (.bmp)|*.bmp|T" +
				"outes les Images Jpeg (.jpg)|*.jpg";
			this.OpenImg.Title = "Ouvrir une Image";
			// 
			// SaveGrille
			// 
			this.SaveGrill .CreatePrompt = true;
			this.SaveGrill .DefaultExt = "jpg";
			this.SaveGrill .    Name = "Grill .jpg";
			this.SaveGrill .   ter = "Diagramme DiagMagic (.jpg)|*.jpg";
			this.SaveGrill .Title = "Sauvegarder la Grill ";
			// 
			// Next
			// 
			this.Next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Next.Location = new System.Drawing.Point(520, 404);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(128, 24);
			this.Next.TabIndex = 3;
			this.Next.Text = "&Suivant   -- >";
			this.Next.Click += new System.EventHandler(this.Next_to_Define_Grille_Click);
			// 
			// SysTray
			// 
			this.SysTray.ContextMenu = this.SysTrayMenu;
			this.SysTray.Icon = ((System.Drawing.Icon)(resources.GetObject("SysTray.Icon")));
			this.SysTray.Text = "DiagMagic";
			this.SysTray.Click += new System.EventHandler(this.Show_App_Click);
			// 
			// SysTrayMenu
			// 
			this.SysTrayMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
					                	this.Show_App,
					              			this.Quit_Tray});
			// 
			// Show_App
			// 
			this.Show_App.DefaultItem = true;
			this.Show_App.Index = 0;
			this.Show_App.Text = "&Afficher";
			this.Show_App.Click += new System.EventHandler(this.Show_App_Click);
			// 
			// Quit_Tray
			// 
			this.Quit_Tray.Index = 1;
			this.Quit_Tray.Text = "&Quitter";
			this.Quit_Tray.Click += new System.EventHandler(this.Quit_App_Click);
			// 
			// Define_Grille_Panel
			// 
			this.Define_Grille_Panel.Location = new System.Drawing.Point(8, 48);
			this.Define_Grille_Panel.Name = "Define_Grille_Panel";
			this.Define_Grille_Panel.Size = new System.Drawing.Size(624, 384);
			this.Define_Grille_Panel.TabIndex = 4;
			this.Define_Grille_Panel.Visible = false;
			// 
			// Grille_Panel
			// 
			this.Grille_Panel.AutoScroll = true;
			this.Grille_Panel.Location = new System.Drawing.Point(8, 8);
			this.Grille_Panel.Name = "Grille_Panel";
			this.Grille_Panel.Size = new System.Drawing.Size(608, 416);
			this.Grille_Panel.TabIndex = 5;
			this.Grille_Panel.Visible = false;
			// 
			// Back
			// 
			this.Back.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Back.Enabled = false;
			this.Back.Location = new System.Drawing.Point(80, 404);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(128, 24);
			this.Back.TabIndex = 6;
			this.Back.Text = "<--    &Précédent";
			this.Back.Click += new System.EventHandler(this.Back_To_Img_Click);
			// 
			// Save Grille
			// 
			this.Save Grille.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Save Grille.Enabled = false;
			this.Save Grille.Location = new System.Drawing.Point(224, 404);
			this.Save Grille.Name = "Save Grille";
			this.Save Grille.Size = new System.Drawing.Size(128, 24);
			this.Save Grille.TabIndex = 8;
			this.Save Grille.Text = "&Enregistrer la Grille";
			this.Save Gril  .Click += new System.EventHandler(this.Save_    _As_Click);
			// 
			// Progress_Panel
			// 
			this.Progress_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Progress_Panel.BackColor = System.Drawing.Color.LightCoral;
			this.Progress_Panel.Location = new System.Drawing.Point(152, 102);
			this.Progress_Panel.Name = "Progress_Panel";
			this.Progress_Panel.Size = new System.Drawing.Size(424, 112);
			this.Progress_Panel.TabIndex = 11;
			this.Progress_Panel.Visible = false;
			// 
			// Img
			// 
			this.Img.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Img.Enabled = false;
			this.Img.Image = ((System.Drawing.Image)(resources.GetObject("Img.Image")));
			this.Img.Location = new System.Drawing.Point(24, 15);
			this.Img.Name = "Img";
			this.Img.Size = new System.Drawing.Size(64, 64);
			this.Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.Img.TabIndex = 12;
			this.Img.TabStop = false;
			this.Img.Visible = false;
			// 
			// Start_Panel
			// 
			this.Start_Panel.AutoScroll = true;
			this.Start_Panel.Location = new System.Drawing.Point(0, 0);
			this.Start_Panel.Name = "Start_Panel";
			this.Start_Panel.Size = new System.Drawing.Size(608, 416);
			this.Start_Panel.TabIndex = 13;
			// 
			// OpenHelp
			// 
			this.OpenHelp.DefaultExt = "htm";
			this.OpenHelp.    Name = "Index.mht";
			this.OpenHelp.   ter = "Fichier d\'aide DiagMagic(Index.mht)|Index.mht";
			this.OpenHelp.Title = "Ouverture du Fichier d\'aide";
			// 
			// Resizer
			// 
			this.Resizer.Image = ((System.Drawing.Image)(resources.GetObject("Resizer.Image")));
			this.Resizer.Location = new System.Drawing.Point(200, 64);
			this.Resizer.Name = "Resizer";
			this.Resizer.Size = new System.Drawing.Size(255, 255);
			this.Resizer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Resizer.TabIndex = 14;
			this.Resizer.TabStop = false;
			this.Resizer.Visible = false;
			// 
			// Leg
			// 
			this.Leg.Location = new System.Drawing.Point(8, 8);
			this.Leg.Name = "Leg";
			this.Leg.Size = new System.Drawing.Size(200, 238);
			this.Leg.TabIndex = 15;
			this.Leg.Visible = false;
			// 
			// Print_Grille
			// 
			this.Print Grille.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Print Grille.Enabled = false;
			this.Print Grille.Location = new System.Drawing.Point(376, 405);
			this.Print Grille.Name = "Print Grille";
			this.Print Grille.Size = new System.Drawing.Size(128, 24);
			this.Print Grille.TabIndex = 16;
			this.Print Grille.Text = "Im&primer la Grille";
			this.Print Gril  .Click += new System.EventHandler(this.Print_Click);
			// 
			// Printer
			// 
			this.Printer.DocumentName = "Grille DiagMagic";
			this.Printer.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Printer_PrintPage);
			// 
			// Dialog_Printer
			// 
			this.Dialog_Printer.Document = this.Printer;
			this.Dialog_Printer.PrintTo     = true;
			this.Dialog_Printer.ShowHelp = true;
			// 
			// MainForm
			// 
			this.AcceptButton = this.Next;
			this.AllowDrop = true;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.Back;
			this.ClientSize = new System.Drawing.Size(641, 459);
			this.Controls.Add(this.Print Gril  );
			this.Controls.Add(this.Leg);
			this.Controls.Add(this.Progress_Panel);
			this.Controls.Add(this.Next);
			this.Controls.Add(this.Save Gril  );
			this.Controls.Add(this.Back);
			this.Controls.Add(this.Resizer);
			this.Controls.Add(this.Start_Panel);
			this.Controls.Add(this.Img);
			this.Controls.Add(this.Gril  _Panel);
			this.Controls.Add(this.Define_Grille_Panel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.MyMainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DiagMagic";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}
		#endregion                             

  #region "static void Main()"
		//  <summary>
		//  Le point d'entrée principal de l'application.
		//  </summary>
		[STAThread]
		static void Main()
		{
				Application.Run(new MainForm());
		}
        #endregion

  #region Fonctions Personnelles

  #region Image.IsValid()
		private bool Image_IsValid()
		{
			if(Start_Panel.Image.Image == null)
			{
				MessageBox.Show("Veuillez choissir une image à traduire","Image absente !",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		#endregion

  #region Prédef Dimension
		private void PredefDim()
		{
			Define_Grille_Panel.Dim_pred.Items.Clear();
			decimal prop_img = (decimal)Start_Panel.Image.Image.Size.Height/(decimal)Start_Panel.Image.Image.Size.Width;
			for(int i = 1;i<=99;i++)
			{
				Size Ajusted = Ajust(prop_img,i,prop_img>1);
				Define_Grille_Panel.Dim_pred.Items.Add(Ajusted);
				if(i==99)
				{
					Define_Grille_Panel.Width_Perso.Value = Ajusted.Width;
					Define_Grille_Panel.Height_Perso.Value = Ajusted.Height;
				}
			}
 	}
		#endregion

  #region Define_Grille.IsValid()
		private bool Define_Grille_Panel_IsValid()
		{
			if(Define_Grille_Panel.Predef.Checked)
			{
				if(Define_Grille_Panel.Dim_pred.Text == "")
				{
					MessageBox.Show("Vous devez sélectionner une taille parmi celles qui sont prédéfinies,\nou en choisir une personalisée.. ","Erreur : Aucune Taille sélectionnée",MessageBoxButtons.OK,MessageBoxIcon.Error);
					return false; 
				}
			}

			if(Define_Grille_Panel.Perso.Checked)
			{
				decimal prop_img = (decimal)Start_Panel.Image.Image.Size.Height/(decimal)Start_Panel.Image.Image.Size.Width;
				Size Size_Max = Ajust(prop_img,99,(prop_img>1));

				if((Define_Grille_Panel.Height_Perso.Value > 99)|(Define_Grille_Panel.Width_Perso.Value > 99))
				{
					DialogResult Result = MessageBox.Show("Vous avez choisi une taille qui risque de ralentir considérablement l'ordinateur;\n\nDésirez-vous que la taille soit réajustée à la plus grande taille disponible ?\n(Vous devrez ensuite confirmer cette nouvelle valeur)\n\nRépondez \'Non\' pour continuer avec la taille que vous avez demandé.. ","Attention : Taille trop importante !",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
					if(Result == DialogResult.Yes)
					{
						Define_Grille_Panel.Width_Perso.Value = Size_Max.Width;
						Define_Grille_Panel.Height_Perso.Value = Size_Max.Height;
						return false;
					}
					if(Result == DialogResult.No)
						MessageBox.Show("Il se pourrait qu'il y ait des erreurs pendant la traduction de l'image.. ","Attenttion : Erreur Possible !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}

				decimal prop_ask = Define_Grille_Panel.Height_Perso.Value/Define_Grille_Panel.Width_Perso.Value;
				if(prop_ask!=prop_img)
				{
					DialogResult Result =  MessageBox.Show("Les dimensions que vous avez demandées ne conservent pas les proportions de l'image d'origine.. \n\nVoulez-vous que la taille soit automatiquement réajustée aux proportions d'origine en fonction de la Hauteur que vous avez demandée ?\n(Vous devrez ensuite confirmer cette nouvelle valeur)\n\nSi vous répondez \'Non\', un redimensionnement vous sera proposé en fonction de la Largeur.. \n\n\nVous pouvez aussi cliquez sur \'Annuler\', pour modifier manuellement les dimensions \n\n\n\nSi vous souhaitez continuez avec ces dimensions, répondez \'Non\' à cette boîte de Dialogue et à la suivante ","Attention : les Dimensions ne respectent pas les proportions de l'image d'origine!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
					if(Result == DialogResult.Cancel)
						return false;
					if(Result == DialogResult.Yes)
					{
						Size Ajusted = Ajust(prop_img,(int)Define_Grille_Panel.Height_Perso.Value,true);
						Define_Grille_Panel.Height_Perso.Value = Ajusted.Height;
						Define_Grille_Panel.Width_Perso.Value = Ajusted.Width;
						return false;		                
					}
					if(Result == DialogResult.No)
					{
						Result =  MessageBox.Show("Les dimensions que vous avez demandées ne conservent pas les proportions de l'image d'origine, et vous avez refusé un redimensionnement automatique selon la hauteur.. \n\nVoulez-vous que la taille soit automatiquement réajustée aux proportions d'origine en fonction de la Largeur que vous avez demandée ?\n(Vous devrez ensuite confirmer cette nouvelle valeur)\n\nSi vous souhaitez continuez avec ces dimensions, répondez \'Non\'.. \n\n\nVous pouvez aussi cliquez sur \'Annuler\', pour modifier manuellement les dimensions ","Attention : les Dimensions ne respectent pas les proportions de l'image d'origine!",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
						if(Result == DialogResult.Cancel)
							return false;
						if(Result == DialogResult.Yes)
						{
							Size Ajusted = Ajust(prop_img,(int)Define_Grille_Panel.Width_Perso.Value,false);
							Define_Grille_Panel.Height_Perso.Value = Ajusted.Height;
							Define_Grille_Panel.Width_Perso.Value = Ajusted.Width;
							return false;
						}
						if(Result == DialogResult.No)
							MessageBox.Show("Il se pourrait qu'il y ait des erreurs pendant la traduction de l'image.. ","Attenttion : Erreur Possible !!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
				}
			}
			return true;
		}
		#endregion
		
  #region Ajust(decimal,int,bool)
		private Size Ajust(decimal prop_img,int Value,bool IsHeight)
		{
			if(prop_img==1)
				return new Size(Value,Value);
			if(IsHeight)
				return new Size((int)(Value/prop_img),Value);
			else
				return new Size(Value,(int)(Value*prop_img));
		}
		#endregion

  #region Resizer

  #region Surcharge ResizeImg(Image,int,int)
		private void ResizeImg(PictureBox Resizer, Image Grand, int WidthMin, int HeightMin)
		{
			Size SMin = new Size(WidthMin,HeightMin);
			ResizeImg(Resizer,Grand,SMin);
		}
		#endregion

  #region Corps ResizeImg(Image,Size)
		private void ResizeImg(PictureBox Resizer, Image Grand, Size SMin)
		{
			Resizer.Size = SMin;
			Graphics Graph = Graphics.FromImage(Resizer.Image);
			Rectangle Rect = new Rectangle(new Point(0),SMin);
			Graph.DrawImage(Grand,Rect);
		}
		#endregion

		#endregion

  #region Modifications des events

	  #region Modifications des events de type "Click"

	 	private void Change_Event_Click(Control Event_Sender,EventHandler Old_Method,EventHandler New_Method)
			{
				Change_Event("Click",Event_Sender,Old_Method,New_Method);		  
			}

            private void Remove_Event_Click(Control Event_Sender,EventHandler Old_Method)
			{
				Remove_Event("Click",Event_Sender,Old_Method);
			}

	 	private void Add_Event_Click(Control Event_Sender,EventHandler New_Method)
			{
				Remove_Event("Click",Event_Sender,New_Method);
			}

	 	#endregion

            #region Change Event (1Remove + 1Add)
	 	private void Change_Event(string Event_Type,Control Event_Sender,EventHandler Old_Method,EventHandler New_Method)
			{
				bool Exception = true;
				if(Event_Type == "Click")
				{
					Remove_Event(Event_Type,Event_Sender,Old_Method);
				 Add_Event(Event_Type,Event_Sender,New_Method);
				 Exception = false; 
				}
				if(Exception)
					throw (new ArgumentException());
			}
	 	#endregion

            #region Remove Event 
	 	private void Remove_Event(string Event_Type,Control Event_Sender,EventHandler Old_Method)
			{
				bool Exception = true;
				if(Event_Type == "Click")
				{
					Event_Sender.Click -= Old_Method;
				 Exception = false;
				}
				if(Exception)
					throw (new ArgumentException());
			}
	 	#endregion

            #region Add Event
	 	private void Add_Event(string Event_Type,Control Event_Sender,EventHandler New_Method)
			{
                bool Exception = true;
				if(Event_Type == "Click")
				{
					Event_Sender.Click += New_Method;
				 Exception = false;
				}
				if(Exception)
					throw (new ArgumentException());
			}
	 	#endregion

	  #region Modification du Bouton Next

	  #region De "Define to Grille" à "Grille to Reboot"
	 	private void Next_Grille_TO_Reboot()
			{
				Next.Text = "&Recommencer";
			 EventHandler Old_Method = new EventHandler(Next_to_Grille_Click);
			 EventHandler New_Method = new EventHandler(ReBoot_Click);
			 Change_Event_Click(Next,Old_Method,New_Method);
			}
	 	#endregion

	  #region De "Grille to Reboot" à "Start to Define"
	 	private void Next_Reboot_TO_Define()
			{
               	Next.Text = "&Suivant   -- >";
				this.Next.Click -= new EventHandler(ReBoot_Click);
				this.Next.Click += new EventHandler(Next_to_Define_Grille_Click);
			}
	 	#endregion

	  #region De "Grille to Reboot" à "Define to Grille"
	 	private void Next_Reboot_TO_Grille()
			{
				this.Next.Text = "&Suivant   -- >";
				this.Next.Click -= new EventHandler(ReBoot_Click);
				this.Next.Click += new EventHandler(Next_to_Grille_Click);
			}
	 	#endregion

	  #region De "Define to Grille" à "Start to Define"
	 	private void Next_Grille_TO_Define()
			{
				this.Next.Click -= new EventHandler(Next_to_Grille_Click);
				this.Next.Click += new EventHandler(Next_to_Define_Grille_Click);
			}
	 	#endregion

	  #endregion

	  #region Modification du Bouton Back

	  #region de "Define to Start" à "Grille to Define"
	 	private void Back_Start_TO_Define()
			{
				this.Back.Click -= new EventHandler(Back_To_Img_Click);
				this.Back.Click += new EventHandler(Back_To_Define_Click);
			}
	 	#endregion

	  #region De "Grille to Define" à "Define to Start"
	 	private void Back_Define_TO_Start()
			{
				this.Back.Click -= new EventHandler(Back_To_Define_Click);
				this.Back.Click += new EventHandler(Back_To_Img_Click);
			}
	 	#endregion

	  #endregion

	 #endregion

  #region Image To Grille

  #region Construction du Diagramme
		private void Img_To_Grille()
		{
		 #region Préparation De l'opération

 		 #region Préparation des indicateurs d'attente
					this.Grille_Panel.Diag.Text = "";
					this.Progress_Panel.Visible = true;//Affichage du Message d'attente et de la Barre de Progression
					this.Progress_Panel.Progress_Bar.Value = 0;//Affichage de l'état de Progression
					this.ProgressMenu.Text = "Veuillez Patienter pendant la conversion de l'Image..  (" + this.Progress_Panel.Progress_Bar.Value + "%)";
					this.ProgressMenu.Visible = true;

 		  #region MessageBox
						MessageBox.Show("Veuillez Patientez pendant la conversion de l'image","Opération Longue",MessageBoxButtons.OK,MessageBoxIcon.Information);
			  #endregion

		  #endregion

     region Récupération des Données
    bool IsColor = Define_Grille_Panel.Couleur.Checked;
				Size SMin=Size.Empty;
				if(Define_Grille_Panel.Predef.Checked)
				 SMin = (Size)Define_Grille_Panel.Dim_pred.SelectedItem; ;
				if(Define_Grille_Panel.Perso.Checked)
				{
				 SMin.Height = (int)Define_Grille_Panel.Height_Perso.Value;
				 SMin.Width = (int)Define_Grille_Panel.Width_Perso.Value;
				}
	 		ResizeImg(Resizer,Start_Panel.Image.Image,SMin);
			 Bitmap Img = (Bitmap)this.Resizer.Image; //Conversion de l'image en image utilisable
				int Marge = 0;
				if (IsColor)
				 Marge = 1450;
				this.Grille_Panel.Diag.Size = new Size((SMin.Width-1)*18+2+Marge,(SMin.Height-1)*18+2);
				this.Grille_Size_Changed(null,null);
				Grille_Panel.Diag.Image = new Bitmap((SMin.Width-1)*18+2+Marge,(SMin.Height-1)*18+2);
				Graphics Graph_Grille = Graphics.FromImage(Grille_Panel.Diag.Image);
				Graph_Grille.Clear(Color.Black);
				Leg.Items.Clear();
		  #endregion

     region Limitation du nombre de cotons
				if(Define_Grille_Panel.Limit_Nbre.Checked)
				{    
					Couleurs = new double[(int)Define_Grille_Panel.Nbre_Cotons.Value+1];
				 Names = new string[(int)Define_Grille_Panel.Nbre_Cotons.Value];
				 double Col = (double)255/(double)Define_Grille_Panel.Nbre_Cotons.Value*(double)15;
					for(int i=0;i<=Define_Grille_Panel.Nbre_Cotons.Value;i++)
					{
						Couleurs[i] = Col*((double)Define_Grille_Panel.Nbre_Cotons.Value-(double)i);
					}
					for(int i=0;i<Define_Grille_Panel.Nbre_Cotons.Value;i++)
					{
						double color = ((double)Couleurs.GetValue(i)+(double)Couleurs.GetValue(i+1))/(double)2;
						for(int j=0;j<=440;j++)
						{
							if((color<=(double)DMC.Couleurs.GetValue(j))&(color>=(double)DMC.Couleurs.GetValue(j+1)))
							 Names[i] = (string)DMC.Names.GetValue(j);
						}
					}
				} else {
					Couleurs = DMC.Couleurs;
					Names = DMC.Names;
				}
		  #endregion
		  
 		 #region Préparation de la Légende
				if(IsColor)
				{
					#region Couleur du Fond
					int FB = 0;
					int FR = 0;
					int FG = 0;
					if(Define_Grille_Panel.Fond_Blanc.Checked)
					{
						FB=255;
						FG=255;
						FR=255;
					}
					if(Define_Grille_Panel.Fond_Noir.Checked)
					{
						FB=0;
						FR=0;
						FG=0;
					}
					if(Define_Grille_Panel.Fond_Bleu.Checked)
					{
						FB=255;
						FR=0;
						FG=0;
					}
					if(Define_Grille_Panel.Fond_Vert.Checked)
					{
						FG=255;
						FB=0;
						FR=0;
					}
					if(Define_Grille_Panel.Fond_Rouge.Checked)
					{
						FR=255;
						FB=0;
						FG=0;
					}
					if(Define_Grille_Panel.Fond_Jaune.Checked)
					{
						FR=255;
						FB=0;
						FG=255;
					}
					if(Define_Grille_Panel.Fond_Perso.Checked)
					{
						FR=(int)Define_Grille_Panel.Red.Value;
						FG=(int)Define_Grille_Panel.Green.Value;
						FB=(int)Define_Grille_Panel.Blue.Value;
					}
			  #endregion
					int color = FR*7 + FG*3 + FB*5 + FG*FB*FG;
					string name = "";
					int Nbre_Cotons = 440;
					if(Define_Grille_Panel.Limit_Nbre.Checked)
					 Nbre_Cotons = (int)Define_Grille_Panel.Nbre_Cotons.Value-1;
					for(int j=0;j<=440;j++)
					{
						if((color<=(double)DMC.Couleurs.GetValue(j))&(color>=(double)DMC.Couleurs.GetValue(j+1)))
							name = (string)Names.GetValue(j);
					}
					int Pos_Leg=this.Leg.Items.Count;
					Leg.Items.Add(name);
				 Bitmap Symbol = (Bitmap)Bitmaps.GetObject("0");
					Graph_Grille.DrawImage(Symbol,new Rectangle(SMin.Width*18+20,Pos_Leg*18+2,16,16));
					Graph_Grille.DrawString(name,this.Font,new SolidBrush(Color.White),SMin.Width*18+40,Pos_Leg*18+2,StringFormat.GenericDefault);
				}
		 	#endregion

	  #endregion

	  #region Traduction de l'image en Diagramme
			decimal prog1 = 0;
			decimal prog2 = 0;
			for(int y = 1;y < SMin.Height;y++) //Lancement de la Boucle de Traduction de Point
			{
				for(int x = 1; x < SMin.Width;x++)
				{
				 Bitmap Symbol = (Bitmap)Bitmaps.GetObject("0");
					try {Symbol = Symbolise(Img.GetPixel(x,y),IsColor,Graph_Grille,SMin);} //Symbolisation du Point
				 catch (Exception) {}
					finally
					{
						prog2=((decimal)x/((decimal)SMin.Width*(decimal)SMin.Height))*(decimal)100;
						this.Progress_Panel.Progress_Bar.Value = (int)(prog1+prog2); //Mise à Jour de la Barre de Progression
						this.ProgressMenu.Text = "Veuillez Patienter pendant la conversion de l'Image..  (" + this.Progress_Panel.Progress_Bar.Value + "%)"; //Mise À Jour de l'état de Progression
						Graph_Grille.DrawImage(Symbol,new Rectangle((x-1)*18+2,(y-1)*18+2,16,16));
					}
				}
		 	prog1=((decimal)y/(decimal)SMin.Height)*(decimal)100;
			}
	 	#endregion

	  #region Suppression des Indicateurs de Progressions
			this.Progress_Panel.Visible = false; //Effacement du Message d'attente et de la barre de progression
			this.ProgressMenu.Visible = false; //Effacement de l'état de Progression
	 	#endregion
        }
		#endregion

  #region Symbolisation de la couleur d'un point

	  #region Tri
				private Bitmap Symbolise(Color Pixel,bool Color,Graphics Graph_Grille,Size SMin)
				{
					if(Color)
						return Symbolise_Color(Pixel,Graph_Grille,SMin);
					else return Symbolise_N_B(Pixel);
				}
	 	#endregion

	  #region Monochromatique
				private Bitmap Symbolise_N_B(Color Pixel)
				{
					#region Couleur du Fond
						int FB = 0;
						int FR = 0;
						int FG = 0;
						if(Define_Grille_Panel.Fond_Blanc.Checked)
						{
							FB=255;
							FG=255;
							FR=255;
						}
						if(Define_Grille_Panel.Fond_Noir.Checked)
						{
							FB=0;
							FR=0;
							FG=0;
						}
						if(Define_Grille_Panel.Fond_Bleu.Checked)
						{
							FB=255;
							FR=0;
							FG=0;
						}
						if(Define_Grille_Panel.Fond_Vert.Checked)
						{
							FG=255;
							FB=0;
							FR=0;
						}
						if(Define_Grille_Panel.Fond_Rouge.Checked)
						{
							FR=255;
							FB=0;
							FG=0;
						}
						if(Define_Grille_Panel.Fond_Jaune.Checked)
						{
							FR=255;
							FB=0;
							FG=255;
						}
						if(Define_Grille_Panel.Fond_Perso.Checked)
						{
							FR=(int)Define_Grille_Panel.Red.Value;
							FG=(int)Define_Grille_Panel.Green.Value;
							FB=(int)Define_Grille_Panel.Blue.Value;
						}
			  #endregion

					int B = Pixel.B;
					int R = Pixel.R;
					int G = Pixel.G;
					if((B>=(FB+85))|(R>=(FR+85))|(G>=(FG+85))|((B+R+G)>=(FB+FR+FG+100)))
						return (Bitmap)Bitmaps.GetObject("3");
					if((B<=(FB-85))|(R<=(FR-85))|(G<=(FG-85))|((B+R+G)<=(FB+FR+FG-100)))
						return (Bitmap)Bitmaps.GetObject("3");
					return (Bitmap)Bitmaps.GetObject("0");
				}
		#endregion

 		#region Couleur
				 private Bitmap Symbolise_Color(Color Pixel,Graphics Graph_Grille,Size SMin)
				 {
					DMC Point = new DMC(Pixel.R,Pixel.G,Pixel.B);
					string name = (string)DMC.Names.GetValue(0);
					int Nbre_Cotons = 440;
					if(Define_Grille_Panel.Limit_Nbre.Checked)
					 Nbre_Cotons = (int)Define_Grille_Panel.Nbre_Cotons.Value-1;
					for(int i=0;i<=Nbre_Cotons;i++)
					{
						double CouleurMax = (double)Couleurs.GetValue(i);
						double CouleurMin = (double)Couleurs.GetValue(i+1);
						if((Point.GetColor()<=CouleurMax)&(Point.GetColor()>=CouleurMin))
						{
							name = (string)Names.GetValue(i);
						}						
					}
					int Pos_Symb = this.Leg.Items.IndexOf(name);
					if(Pos_Symb==-1)
					{
						Pos_Symb=this.Leg.Items.Count;
						int Pos_Leg = Pos_Symb;
						int Col_Leg = 0;
						Leg.Items.Add(name);
					 Bitmap Symbol = (Bitmap)Bitmaps.GetObject(Pos_Leg.ToString());
						for(;SMin.Height<Pos_Leg;Pos_Leg-=(SMin.Height+1))
							Col_Leg++;
						Graph_Grille.DrawImage(Symbol,new Rectangle(SMin.Width*18+20+Col_Leg*130,Pos_Leg*18+2,16,16));
						Graph_Grille.DrawString(name,this.Font,new SolidBrush(Color.White),SMin.Width*18+40+Col_Leg*130,Pos_Leg*18+2,StringFormat.GenericDefault);
					}
					return (Bitmap)Bitmaps.GetObject(Pos_Symb.ToString());
				}
	  #endregion

	 #endregion

  #endregion
		
  #region Recadrage de l'Image
		private void Reframe_Img(PictureBox PictBox)
		{
		if(PictBox.Image.Size!=PictBox.Size)
		{
			 Bitmap Old_Image = (Bitmap)PictBox.Image;
				PictBox.Image = new Bitmap(PictBox.Size.Width,PictBox.Size.Height);
				Graphics New_Image_Graph = Graphics.FromImage(PictBox.Image);
				New_Image_Graph.DrawImage(Old_Image,new Rectangle(new Point(0),PictBox.Size),new Rectangle(new Point(0),PictBox.Size) GraphicsUnit.Pixel);
		}
		}
		#endregion

		#endregion

  #region Clicks

  #region Open    e
		private void Open_    _Click(object sender, System.EventArgs e)
		{
		try{this.Start_Panel.Image.Image = System.Drawing.Image.From    (    r.Open r(OpenImg));}
	 catch (Exception) {}
		finally{this.Image_Size_Changed(sender,e);}
 	}
		#endregion

  #region Quit App
		private void Quit_App_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion

  #region Save    e
		private void Save_    _Click(object sender, System.EventArgs e)
		{
			Reframe_Img(Grille_Panel.Diag);
			Grille_Panel.Nbre_Leg.Value = 10;
			    r.Save_Img_In_   e(Grille_Panel.Diag.Image,ImageFormat.Jpeg,File_Gest.In,SaveGrill );
		}
		#endregion

  #region Save As
		private void Save_    _As_Click(object sender, System.EventArgs e)
		{
			Reframe_Img(Grille_Panel.Diag);
			Grille_Panel.Nbre_Leg.Value = 10;
			    r.Save_Img_In_   e(Grille_Panel.Diag.Image,ImageFormat.Jpeg,File_Gest.As,SaveGrill );
		}
		#endregion

  #region Reduic 
		private void Reduic _Click(object sender, System.EventArgs e)
		{
            this.SysTray.Visible = true;
			this.Hide();
		}
		#endregion

  #region Show App
		private void Show_App_Click(object sender, System.EventArgs e)
		{
			this.Show();
			this.SysTray.Visible = false;
		}
		#endregion

  #region Next

  #region To Define Grille
		private void Next_to_Define_Gril  _Click(object sender, System.EventArgs e)
		{
			if (Image_IsValid())
			{
                PredefDim();
				this.Start_Panel.Visible = false;
				this.Define_Grille_Panel.Visible = true;
				this.Grille_Panel.Visible = false;
				this.Back.Enabled = true;
			 EventHandler Old_Method = new EventHandler(Next_to_Define_Grille_Click);
			 EventHandler New_Method = new EventHandler(Next_to_Grille_Click);
			 Change_Event_Click(Next,Old_Method,New_Method);
				this.Open_    .Enabled = false;
			}
 	}
		#endregion

  #region To Grille
		private void Next_to_Gril  _Click(object sender, System.EventArgs e)
		{
			if (Define_Grille_Panel_IsValid())
			{
				this.Next_Grille_TO_Reboot();
				this.Back_Start_TO_Define();
				this.Start_Panel.Visible = false;
				this.Define_Grille_Panel.Visible = false;
				this.Grille_Panel.Visible = true;
				if(Define_Grille_Panel.Couleur.Checked)
				{
				 Grille_Panel.Lbl_Nbre_Leg.Visible = true;
				 Grille_Panel.Nbre_Leg.Visible = true;
				} else {
				 Grille_Panel.Lbl_Nbre_Leg.Visible = false;
				 Grille_Panel.Nbre_Leg.Visible = false;
				}
				Img_To_Grille();
				this.Save Grille.Enabled = true;
				Print Grille.Enabled = true;
				this.Save   le.Enabled = true;
				this.Save     _As.Enabled = true;
				Print.Enabled = true;
			}
		}
		#endregion

		#endregion

  #region Back

  #region To Img
		private void Back_To_Img_Click(object sender, System.EventArgs e)
		{
			this.Back.Enabled = false;
			this.Next_Grille_TO_Define();
			this.Start_Panel.Visible = true;
			this.Define_Grille_Panel.Visible = false;
			this.Grille_Panel.Visible = false;
			this.Open_    .Enabled = true;
		}
		#endregion

  #region To Define
		private void Back_To_Defin _Click(object sender, System.EventArgs e)
		{
			this.Back_Define_TO_Start();
            this.Next_Reboot_TO_Grille();
			this.Start_Panel.Visible = false;
			this.Define_Grille_Panel.Visible = true;
			this.Grille_Panel.Visible = false;
			this.Save Grille.Enabled = false;
			Print Grille.Enabled = false;
			this.Grille_Panel.Diag.Text = "";
			this.Save     .Enabled = false;
			this.Save     _As.Enabled = false;
			Print.Enabled = false;
		}
		#endregion

  #region To Start
		private void ReBoot_Click(object sender, System.EventArgs e)
		{
			this.Back_Define_TO_Start();
			this.Back.Enabled = false;
            this.Next_Reboot_TO_Define();
			this.Start_Panel.Image.Image = this.Image_Init;
			this.Save Grille.Enabled = false;
			Print Grille.Enabled = false;
			this.Start_Panel.Visible = true;
			this.Grille_Panel.Visible = false;
			this.Define_Grille_Panel.Visible = false;
			this.Grille_Panel.Diag.Text = "";
			this.Save     .Enabled = false;
			this.Save     _As.Enabled = false;
			Print.Enabled = false;
			this.Open_    .Enabled = true;
		}
		#endregion

  #endregion

  #region About
		private void About_Click(object sender, System.EventArgs e)
		{
			About À_propos = new About();
			À_propos.Icon = this.Icon;
			À_propos.Img.Image = this.Img.Image;
			À_propos.ShowDialog();
		}
		#endregion

  #region Help
		private void Help_Click(object sender, System.EventArgs e)
		{
            string Help     = "";
			try
			{
				RegistryKey RegKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\GLYS Informatique\\Diag Magic");
				Help    =(string)RegKey.GetValue("Help     ","F:\\Program     s\\GLYS Informatique\\Diag Magic\\Help\\Index.mht");
				Proc ss Help = new Proc ss();
				Help.StartInfo.    Name = Help    ;
				Help.Start();
			}
		 catch (Exception)
			{
			try
			{
				DialogResult Result = MessageBox.Show("Impossible de trouver le Fichier d'aide, voulez-vous faire une recherche manuelle ?","Impossible de trouver le fichier d'aide",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
				if(Result == DialogResult.Yes)
				{
					Proc ss Help = new Proc ss();
					string     Help =     r.Open r(OpenHelp);
					Help.StartInfo.    Name =     Help;
					RegistryKey RegKey = Registry.LocalMachin .CreateSubKey("SOFTWARE\\GLYS Informatique\\Diag Magic");
					RegKey.SetValue("Help     ",    Help);
					Help.Start();
				} else throw (new System.Exception()) ;
			} catch (Exception) {MessageBox.Show("Une Erreure s'est produite rendant l'aide indisponible.. \nVeuillez contacté le Concepteur de ce Logiciel ou relancer le programme d'installation.. ","Error !",MessageBoxButtons.OK,MessageBoxIcon.Error);}
			}
 	}
		#endregion

  #region Rappel
		private void Rappel_Click(object sender, EventArgs e)
		{
			Rappel Rap = new Rappel(Start_Panel.Image.Image);
			Rap.Size = new Size(Start_Panel.Image.Image.Size.Width + 25,Start_Panel.Image.Image.Size.Height + 70);
			if(Define_Grille_Panel.Fond_Perso.Checked)
				Rap.BackColor = Define_Grille_Panel.Fond_Perso.BackColor;
			Rap.ShowDialog();
		}
		#endregion

  #region Print
		private void Print_Click(object sender, System.EventArgs e)
		{
			Reframe_Img(Grille_Panel.Diag);
			Grille_Panel.Nbre_Leg.Value = 10;
			if(Dialog_Printer.ShowDialog() == DialogResult.OK)
				try {Printer.Print();} catch (Exception) {}
 	}
		#endregion
		
		#endregion

  #region Events Divers

  #region Changement de la Taille de l'Image
		private void Image_Size_Changed(object sender, System.EventArgs e)
		{
			System.Drawing.Size Marge = this.Start_Panel.Look_Down.Size;
			Marge.Height = Marge.Height + 30;
			Marge.Width = Marge.Width + 30;
            if(this.Start_Panel.Image.Image != null)
			this.Start_Panel.Size = this.Start_Panel.Image.Image.Size + Marge;
			else
			this.Start_Panel.Size = Marge;
 	}
		#endregion

  #region Changement de la Taille de la Grille
		private void Grille_Size_Changed(object sender, System.EventArgs e)
		{
			Size Marge = this.Grille_Panel.Look_Down.Size;
			Marge.Height = Marge.Height + 30;
			Marge.Width = Marge.Width + 30;
			this.Grille_Panel.Size = this.Grille_Panel.Diag.Size + Marge;
 	}
		#endregion

  #region Chargement du Form Principal
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			Define_Grille_Panel.Rappel.Click += new EventHandler(Rappel_Click);
		}
		#endregion

  #region Impression de la Grille
		private void Printer_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImage(Grille_Panel.Diag.Image,new Rectangle(30,30,Grille_Panel.Diag.Image.Size.Width,Grille_Panel.Diag.Image.Size.Height));
		}
		#endregion

  #endregion
 	}
}

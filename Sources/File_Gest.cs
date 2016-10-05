using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DiagMagic
{
	public class File_Gest
	{
		#region Variables
		public string Text_To_Save;
		public string File_To_Save;
		public Image Img_To_Save;
		#endregion
		
		#region Constructeurs

		#region Constructeur par défaut
		public File_Gest()
		{
			if(!(Directory.Exists("F:\\Temp")) 
				Directory.CreateDirectory("F:\\Temp");
			if(!(File.Exists("F:\\Temp\\Name.Ext")) 
				File.Create("F:\\Temp\\Name.Ext");
			this.File_To_Save = "F:\\Temp\\Name.Ext";
			this.Text_To_Save = "Text_To_Save";
			this.Img_To_Save = new Bitmap(32,32);
		}
		#endregion

        #region Constructeur avec File_To_Save
		public File_Gest(string File_To_Save)
		{
			if(!(Directory.Exists("F:\\Temp")) 
				Directory.CreateDirectory("F:\\Temp");
			if(!(File.Exists("F:\\Temp\\Name.Ext")) 
				File.Create("F:\\Temp\\Name.Ext");
			this.File_To_Save = File_To_Save;
			this.Text_To_Save = "Text_To_Save";
			this.Img_To_Save = new Bitmap(32,32);
		}
		#endregion

		#endregion

  #region Constante
		public static File_Gest Empty =	new File_Gest();
		public static string In = "In";
		public static string As = "As";
		#endregion

  #region Opener
		public string Opener(System.Windows.Forms.OpenFileDialog OpenDialogue)
		{
			if(!(Directory.Exists("F:\\Temp")) 
				Directory.CreateDirectory("F:\\Temp");
			if(!(File.Exists("F:\\Temp\\name.ext")) 
			   File.Create("F:\\Temp\\name.ext");
			OpenDialogue.Multiselect = false;
			DialogResult Result = OpenDialogue.ShowDialog();
			if(Result == DialogResult.OK 
				return OpenDialogue.FileName;
			return "F:\\Temp\\name.ext";
		}
		#endregion
        
  #region Saver
		public string Saver(System.Windows.Forms.SaveFileDialog SaveDialogue)
		{
            if(SaveDialogue.ShowDialog() == DialogResult.OK 
				return SaveDialogue.FileName.ToString();
			else
				return "F:\\Temp\\name.ext";
		}
		#endregion

        #region Save Text In File
		public void Save_Text_In_File(string Text,string SaveType,System.Windows.Forms.SaveFileDialog SaveDialogue)
		{
			this.Text_To_Save = Text;

			if((this.File_To_Save=="F:\\Temp\\Name.Ext") | (SaveType=="As") 
				this.File_To_Save = Saver(SaveDialogue);
			try
				{
					if(File.Exists(this.File_To_Save) 
						File.Delete(this.File_To_Save);
					StreamWriter File_To_Save = File.CreateText(this.File_To_Save);
					File_To_Save.Write(this.Text_To_Save);
					File_To_Save.Close();
				}
				catch (Exception) {MessageBox.Show("Le fichier spécifié est déjà ouvert; Veuillez le fermer avant d'y accéder.","Fichier Inaccessible",MessageBoxButtons.OK,MessageBoxIcon.Error);}
		}
		#endregion
	
  #region Save Image In File
		public void Save_Img_In_File(Image Img,ImageFormat Format,string SaveType,System.Windows.Forms.SaveFileDialog SaveDialogue)
		{
			this.Img_To_Save = Img;

			if((this.File_To_Save=="F:\\Temp\\Name.Ext") | (SaveType=="As") 
				this.File_To_Save = Saver(SaveDialogue);
			try
			{
				if(File.Exists(this.File_To_Save) 
					File.Delete(this.File_To_Save);
				this.Img_To_Save.Save(this.File_To_Save,Format);
			}
			catch (Exception) {MessageBox.Show("Le fichier spécifié est déjà ouvert; Veuillez le fermer avant d'y accéder.","Fichier Inaccessible",MessageBoxButtons.OK,MessageBoxIcon.Error);}
		}
		#endregion
	}
}

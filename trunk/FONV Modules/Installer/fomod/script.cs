using System;
using fomm.Scripting;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;


class Script : FalloutNewVegasBaseScript {

	const string title = "Project NEVADA";

	static ASCIIEncoding encoding;

	static bool cyberwareSelected = true;
	static bool installSelected = false;

	static Form installerForm;
	static PictureBox contentPicture;
    static PictureBox exitButton;
    static PictureBox installButton;
    static PictureBox coreButton;
    static PictureBox cyberwareButton;
    static PictureBox coreCheckbox;
    static PictureBox cyberwareCheckbox;
	
	static Image imageChecked;
	static Image imageUnchecked;
	static Image imageInstall;
	static Image imageInstallHi;
	static Image imageExit;
	static Image imageExitHi;
	static Image imageLogo;
	static Image imageCore;
	static Image imageCoreHi;
	static Image imageCoreDesc;
	static Image imageCyberware;
	static Image imageCyberwareHi;
	static Image imageCyberwareDesc;
	
	static System.Media.SoundPlayer hoverPlayer;
	static System.Media.SoundPlayer acceptPlayer;
	static System.Media.SoundPlayer denyPlayer;
	
	
	public static bool OnActivate()
	{
        
        encoding = new ASCIIEncoding();
		InitializeComponents();
		
		installerForm.ShowDialog();
		
		if (installSelected == false)
			return false;
			
		if (! InstallModuleCore())
			return false;
			
		
		if (cyberwareSelected) {
			if (! InstallModuleCyberware())
				return false;
		}
		
		return true;
	}
	
	
	static bool InstallModuleCore()
	{
		string text;
		
		// Install base files
		string[] excludes = new string[] {
			"includes_HUDMainMenu.xml",
			"includes_StartMenu.xml",
			"hud_main_menu.xml",
			"start_menu.xml"
		};
		InstallModuleFiles("Core", excludes);
		
		UpdateInclude("menus/prefabs/includes_HUDMainMenu.xml", @"pnx\pnxhud.xml");
		UpdateInclude("menus/prefabs/includes_StartMenu.xml", @"pnx\pnxpause.xml");
		
		UpdateUIFile("menus/main/hud_main_menu.xml", "menus/main/hud_main_menu.xml", "includes_HUDMainMenu.xml");
		UpdateUIFile("menus/options/start_menu.xml", "menus/options/start_menu.xml", "includes_StartMenu.xml");
	
		return true;
	}
	
	
	static bool InstallModuleCyberware()
	{
		string text;
		
		// Install base files
		string[] excludes = new string[] {
			"includes_TutorialMenu.xml",
			"tutorial_menu.xml"
		};
		InstallModuleFiles("Cyberware", excludes);
		
		UpdateInclude("menus/prefabs/includes_TutorialMenu.xml", @"pnx\pnximplants.xml");
		
		UpdateUIFile("menus/tutorial_menu.xml", "menus/tutorial_menu.xml", "includes_TutorialMenu.xml");
	
		return true;
	}
	
	
	// Installs include from fomod if not present, appends editString otherwise
	static bool UpdateInclude(string path, string includePath)
	{
		if (! DataFileExists(path)) {
			return InstallFileFromFomod(path);
			
		} else {
				// 
			bool editSuccess = AppendInclude(path, includePath);
		
			if (! editSuccess) {
				MessageBox("Failed to access " + path + ". Reinstall the mod with all other applications closed, or try a manual installation (see readme).", title);
			}
			
			return editSuccess;
		}
    }
    
    
    // Installs include from fomod if not present, appends editString otherwise
	static bool UpdateUIFile(string path, string srcPath, string includePath)
	{
		if (! DataFileExists(path)) {
			return InstallFileFromFomod(srcPath, path);
		} else {

			bool editSuccess = AppendIncludeToMenu(path, includePath);
		
			if (! editSuccess) {
				MessageBox("Failed to access " + path + ". Reinstall the mod with all other applications closed, or try a manual installation (see readme).", title);
			}
			
			return editSuccess;
		}
    }
    
    
    static void InitializeComponents()
    {
    	hoverPlayer = new System.Media.SoundPlayer();
		acceptPlayer = new System.Media.SoundPlayer();
		denyPlayer = new System.Media.SoundPlayer();
    
	    hoverPlayer.Stream = GetStreamFromFomod("fomod/soundHover.wav");
		acceptPlayer.Stream = GetStreamFromFomod("fomod/soundAccept.wav");
		denyPlayer.Stream = GetStreamFromFomod("fomod/soundDeny.wav");
		
		imageChecked = GetImageFromFomod("fomod/InstallerChecked.png");
		imageUnchecked = GetImageFromFomod("fomod/InstallerUnchecked.png");
		imageInstall = GetImageFromFomod("fomod/InstallerInstall.png");
		imageInstallHi = GetImageFromFomod("fomod/InstallerInstallHi.png");
		imageExit = GetImageFromFomod("fomod/InstallerExit.png");
		imageExitHi = GetImageFromFomod("fomod/InstallerExitHi.png");
		imageLogo = GetImageFromFomod("fomod/InstallerLogo.png");
		imageCore = GetImageFromFomod("fomod/InstallerCore.png");
		imageCoreHi = GetImageFromFomod("fomod/InstallerCoreHi.png");
		imageCoreDesc = GetImageFromFomod("fomod/InstallerCoreDesc.png");
		imageCyberware = GetImageFromFomod("fomod/InstallerCyberware.png");
		imageCyberwareHi = GetImageFromFomod("fomod/InstallerCyberwareHi.png");
		imageCyberwareDesc = GetImageFromFomod("fomod/InstallerCyberDesc.png");
    
    	installerForm = CreateCustomForm();
    
        cyberwareCheckbox = new System.Windows.Forms.PictureBox();
        coreCheckbox = new System.Windows.Forms.PictureBox();
        contentPicture = new System.Windows.Forms.PictureBox();
        cyberwareButton = new System.Windows.Forms.PictureBox();
        coreButton = new System.Windows.Forms.PictureBox();
        installButton = new System.Windows.Forms.PictureBox();
        exitButton = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(cyberwareCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(coreCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(contentPicture)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(cyberwareButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(coreButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(installButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(exitButton)).BeginInit();
        installerForm.SuspendLayout();
        // 
        // cyberwareCheckbox
        // 
        cyberwareCheckbox.Image = imageChecked;
        cyberwareCheckbox.Location = new System.Drawing.Point(497, 37);
        cyberwareCheckbox.Name = "cyberwareCheckbox";
        cyberwareCheckbox.Size = new System.Drawing.Size(62, 62);
        cyberwareCheckbox.TabIndex = 8;
        cyberwareCheckbox.TabStop = false;
        // 
        // coreCheckbox
        // 
        coreCheckbox.Image = imageChecked;
        coreCheckbox.Location = new System.Drawing.Point(236, 37);
        coreCheckbox.Name = "coreCheckbox";
        coreCheckbox.Size = new System.Drawing.Size(64, 62);
        coreCheckbox.TabIndex = 7;
        coreCheckbox.TabStop = false;
        // 
        // contentPicture
        // 
        contentPicture.Image = imageLogo;
        contentPicture.Location = new System.Drawing.Point(8, 115);
        contentPicture.Name = "contentPicture";
        contentPicture.Size = new System.Drawing.Size(768, 418);
        contentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        contentPicture.TabIndex = 0;
        contentPicture.TabStop = false;
        // 
        // cyberwareButton
        // 
        cyberwareButton.Image = imageCyberware;
        cyberwareButton.Location = new System.Drawing.Point(565, 28);
        cyberwareButton.Name = "cyberwareButton";
        cyberwareButton.Size = new System.Drawing.Size(128, 81);
        cyberwareButton.TabIndex = 6;
        cyberwareButton.TabStop = false;
        cyberwareButton.Click += delegate(object sender, EventArgs e) {
			acceptPlayer.Play();

			if (cyberwareSelected == true) {
				cyberwareSelected = false;
				cyberwareCheckbox.Image = imageUnchecked;
			} else {
				cyberwareSelected = true;
				cyberwareCheckbox.Image = imageChecked;
			}
		};
        cyberwareButton.MouseEnter += delegate(object sender, EventArgs e) {
			cyberwareButton.Image = imageCyberwareHi;
			contentPicture.Image = imageCyberwareDesc;
			hoverPlayer.Play();
		};
        cyberwareButton.MouseLeave += delegate(object sender, EventArgs e) {
			cyberwareButton.Image = imageCyberware;
			contentPicture.Image = imageLogo;
		};
        // 
        // coreButton
        // 
        coreButton.Image = imageCore;
        coreButton.Location = new System.Drawing.Point(100, 28);
        coreButton.Name = "coreButton";
        coreButton.Size = new System.Drawing.Size(130, 81);
        coreButton.TabIndex = 3;
        coreButton.TabStop = false;
        coreButton.Click += delegate(object sender, EventArgs e) {
			denyPlayer.Play();
		};
        coreButton.MouseEnter += delegate(object sender, EventArgs e) {
			coreButton.Image = imageCoreHi;
			contentPicture.Image = imageCoreDesc;
			hoverPlayer.Play();
		};
        coreButton.MouseLeave += delegate(object sender, EventArgs e) {
			coreButton.Image = imageCore;
			contentPicture.Image = imageLogo;
		};
        // 
        // installButton
        // 
        installButton.Image = imageInstall;
        installButton.Location = new System.Drawing.Point(603, 539);
        installButton.Name = "installButton";
        installButton.Size = new System.Drawing.Size(173, 102);
        installButton.TabIndex = 2;
        installButton.TabStop = false;
        installButton.Click += delegate(object sender, EventArgs e) {
			installSelected = true;
			installerForm.Close();
		};
        installButton.MouseEnter += delegate(object sender, EventArgs e) {
			installButton.Image = imageInstallHi;
			hoverPlayer.Play();
		};
        installButton.MouseLeave += delegate(object sender, EventArgs e) {
			installButton.Image = imageInstall;
		};
        // 
        // exitButton
        // 
        exitButton.Image = imageExit;
        exitButton.Location = new System.Drawing.Point(8, 539);
        exitButton.Name = "exitButton";
        exitButton.Size = new System.Drawing.Size(125, 102);
        exitButton.TabIndex = 1;
        exitButton.TabStop = false;
        exitButton.Click += delegate(object sender, EventArgs e) {
			installSelected = false;
			installerForm.Close();
		};
        exitButton.MouseEnter += delegate(object sender, EventArgs e) {
			exitButton.Image = imageExitHi;
			hoverPlayer.Play();
		};
        exitButton.MouseLeave += delegate(object sender, EventArgs e) {
			exitButton.Image = imageExit;
		};
        // 
        // InstallerForm
        // 
        installerForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        installerForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        installerForm.BackColor = System.Drawing.Color.Black;
        installerForm.ClientSize = new System.Drawing.Size(784, 647);
        installerForm.Controls.Add(cyberwareCheckbox);
        installerForm.Controls.Add(coreCheckbox);
        installerForm.Controls.Add(contentPicture);
        installerForm.Controls.Add(cyberwareButton);
        installerForm.Controls.Add(coreButton);
        installerForm.Controls.Add(installButton);
        installerForm.Controls.Add(exitButton);
        installerForm.MaximizeBox = false;
        installerForm.MaximumSize = new System.Drawing.Size(800, 685);
        installerForm.MinimizeBox = false;
        installerForm.MinimumSize = new System.Drawing.Size(800, 685);
        installerForm.Name = "installerForm";
        installerForm.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
        installerForm.Text = title;
        ((System.ComponentModel.ISupportInitialize)(cyberwareCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(coreCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(contentPicture)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(cyberwareButton)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(coreButton)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(installButton)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(exitButton)).EndInit();
        installerForm.ResumeLayout(false);
        installerForm.Refresh();
    }
    
    
    static Image GetImageFromFomod(string filename)
	{  
        byte[] data = GetFileFromFomod(filename);
		
		if (data == null)
			return null;
		
        MemoryStream stream = new MemoryStream(data);
        Image image = Image.FromStream(stream);
        s.Close();        	
        
        return image;  
    }
    
    
	static Stream GetStreamFromFomod(string filename)
	{  
		byte[] data = GetFileFromFomod(filename);
		
		if (data == null)
			return null;
			
        return new MemoryStream(data);
    }
	
		
	static void InstallModuleFiles(string name, string[] excludes)
	{
		Stream listStream = GetStreamFromFomod("fomod/" + name + "Files.txt");
		if (listStream == null)
			return;
			
		TextReader tr = new StreamReader(listStream);
		
		List<string> fileList = new List<string>();
		string line;
		while((line = tr.ReadLine()) != null) {
			fileList.Add(line);
		}
		tr.Close();
		
		string[] files = fileList.ToArray();
		
		foreach (string file in files) {
		
			// In case i forgot to remove it :)
			if (file.StartsWith("fomod"))
				continue;
				
			if (file.StartsWith("optional"))
				continue;
				
			bool found = false;
			foreach (string exclude in excludes) {
				if (file.EndsWith(exclude)) {
					found = true;
					continue;
				}
			}
			if (found)
				continue;

			InstallFileFromFomod(file);
		}
	}
	
	
	static bool AppendInclude(string xmlPath, string includePath)
	{
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			return false;
		
		string tmp = encoding.GetString(data);
		
		// Include is already there?
		if (Regex.Match(tmp, "<include src=\"" + Regex.Escape(includePath) + "\" />", RegexOptions.Singleline).Success == true)
			return true;
		
		tmp += "\r\n"
			+ "<!-- BEGIN Added by Project Nevada -->\r\n"
			+ "<include src=\"" + includePath + "\" />\r\n"
			+ "<!-- END Added by Project Nevada -->\r\n";
		
		data = encoding.GetBytes(tmp);
			
		GenerateDataFile(xmlPath, data);
		
		return true;
	}
	
	
	static bool AppendIncludeToMenu(string xmlPath, string includePath)
	{
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			return false;
			
		string tmp = encoding.GetString(data);

		// Include is already there?
		if (Regex.Match(tmp, "<include src=\"" + Regex.Escape(includePath) + "\" />", RegexOptions.Singleline).Success == true)
			return true;
		
		string includeStr = "\r\n"
			+ "\t<!-- BEGIN Added by Project Nevada -->\r\n"
			+ "\t<include src=\"" + includePath + "\" />\r\n"
			+ "\t<!-- END Added by Project Nevada -->\r\n";
		
		tmp = Regex.Replace(tmp,
			"<menu name=\"(\\w+)\">(.*)</menu>\\s*$",
			"<menu name=\"$1\">$2" + includeStr + "</menu>",
			RegexOptions.Singleline);
		
		data = encoding.GetBytes(tmp);
			
		GenerateDataFile(xmlPath, data);
		
		return true;
	}
	
	
	static bool InstallFileFromFomod(string source, string target)
	{
		byte[] data = GetFileFromFomod(source);
		if (data == null)
			return false;
		
		return GenerateDataFile(target, data);
	}
}
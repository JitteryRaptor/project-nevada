using System;
using fomm.Scripting;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using System.Globalization;


class Script : FalloutNewVegasBaseScript {

	const string title = "Project Nevada - Extra Options";

	static ASCIIEncoding encoding;

	static bool cyberwareSelected = true;
	static bool equipmentSelected = false;
	static bool rebalanceSelected = true;
	static bool dlcSelected = true;
	static bool installSelected = false;

	static Form installerForm;
	static PictureBox contentPicture;
    static PictureBox exitButton;
    static PictureBox installButton;
    static PictureBox coreButton;
    static PictureBox cyberwareButton;
    static PictureBox equipmentButton;
    static PictureBox rebalanceButton;
	static PictureBox dlcButton;
    static PictureBox coreCheckbox;
    static PictureBox cyberwareCheckbox;
    static PictureBox equipmentCheckbox;
    static PictureBox rebalanceCheckbox;
	static PictureBox dlcCheckbox;
	
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
	static Image imageEquipment;
	static Image imageEquipmentHi;
	static Image imageEquipmentDesc;
	static Image imageRebalance;
	static Image imageRebalanceHi;
	static Image imageRebalanceDesc;
	static Image imageDLC;
	static Image imageDLCHi;
	static Image imageDLCDesc;
	
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
		
		if (equipmentSelected) {
			if (! InstallModuleEquipment())
				return false;
		}
		
		if (rebalanceSelected) {
			if (! InstallModuleRebalance())
				return false;
		}
		
		if (dlcSelected) {
			if (! InstallModuleDLC())
				return false;
		}
		
		return true;
	}
	
	
	static bool InstallModuleCore()
	{	
		// Install base files
		string[] excludes = new string[0];
		InstallModuleFiles("Core", excludes);
		
		UpdateInclude("menus/prefabs/includes_HUDMainMenu.xml", @"pnx\pnxeohud.xml", new string[] {"menus/options/start_menu.xml"});
	
		return true;
	}
	
	
	static bool InstallModuleCyberware()
	{	
		if (! DataFileExists("Project Nevada - Cyberware.esp")) {
			MessageBox("Cyberware is not installed. The Cyberware Additions plugin will not be installed", "Error!");
			return false;
		}
		else {
			// Install base files
			string[] excludes = new string[0];
			InstallModuleFiles("Cyberware", excludes);
			return true;
		}
	}
	
	
	static bool InstallModuleEquipment()
	{	
		if (! DataFileExists("Project Nevada - Equipment.esm")) {
			MessageBox("Equipment is not installed. The Equipment Addons plugin will not be installed", "Error!");
			return false;
		}
		else {
			// Install base files
			string[] excludes = new string[0];
			InstallModuleFiles("Equipment", excludes);
			return true;
		}
	}
	
	
	static bool InstallModuleRebalance()
	{	
		if (! DataFileExists("Project Nevada - Rebalance.esp")) {
			MessageBox("Rebalance is not installed. The Rebalance Complete plugin will not be installed", "Error!");
			return false;
		}
		else {
			// Install base files
			string[] excludes = new string[0];
			InstallModuleFiles("Rebalance", excludes);
			return true;
		}
	}
	
	
	static bool InstallModuleDLC()
	{	
		if ((DataFileExists("Project Nevada - Dead Money.esp")) || (DataFileExists("Project Nevada - Honest Hearts.esp")) || ((DataFileExists("Project Nevada - Old World Blues.esp")) || (DataFileExists("Project Nevada - Old World Blues (no Cyberware).esp"))) || (DataFileExists("Project Nevada - Lonesome Road.esp")))
			MessageBox("You are currently using the Project Nevada - DLC Patches. Extra Options has a new plugin that combines all of the DLC Patches, but requires both Cyberware and Rebalance in order to work. If you use all of the Project Nevada modules, you can remove the DLC Patches and use the new patch instead. Otherwise, you can delete the combined patch file.\r\n\r\nIn order to switch to the new plugin, you will first need to disable all of the old ones, and then save your game. The only items you will lose will be any Lonesome Road Remote Satchel Charges, and Gun Runner's Arsenal Remote Fat Mines.\r\n\r\nThe new file will be installed as disabled. Make sure you enable it before playing!", "Notice!");

		// Install base files
		string[] excludes = new string[0];
		InstallModuleFiles("DLC", excludes);
		
		SetPluginActivation("Project Nevada - All DLC.esp", false);
		
		return true;
	}
	
	
	// Appends editString if not present, otherwise keeps existing file (or generates blank one)	
	static void UpdateInclude(string path, string includePath, string[] parents)
	{
		byte[] data = GenerateInclude(path, includePath, parents);		
		GenerateDataFile(path, data);
    }
    
    
    // Installs include from fomod if not present, appends editString otherwise
	static bool UpdateUIFile(string path, string srcPath, string includePath)
	{
		if (! DataFileExists(path)) {
			return InstallFileFromFomod(srcPath, path);
		} else {

			bool editSuccess = AppendIncludeToMenu(path, includePath);
		
			if (! editSuccess) {
				MessageBox("Failed to access " + path + ". You might have to re-install the mod with all other applications closed, or try a manual installation (see readme).", title);
			}
			
			return editSuccess;
		}
    }
    
    static bool IsPNMCMOutdated()
    {
    	byte[] oldFile = GetExistingDataFile("menus/prefabs/MCM/MCM.xml");
    	if (oldFile == null)
    		return false;
    	
    	byte[] newFile = GetFileFromFomod("menus/prefabs/MCM/MCM.xml");
    	
    	return (ExtractMCMVersion(oldFile) > ExtractMCMVersion(newFile));
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
		imageEquipment = GetImageFromFomod("fomod/InstallerEquipment.png");
		imageEquipmentHi = GetImageFromFomod("fomod/InstallerEquipmentHi.png");
		imageEquipmentDesc = GetImageFromFomod("fomod/InstallerEquipmentDesc.png");
		imageRebalance = GetImageFromFomod("fomod/InstallerRebalance.png");
		imageRebalanceHi = GetImageFromFomod("fomod/InstallerRebalanceHi.png");
		imageRebalanceDesc = GetImageFromFomod("fomod/InstallerRebalanceDesc.png");
		imageDLC = GetImageFromFomod("fomod/InstallerDLC.png");
		imageDLCHi = GetImageFromFomod("fomod/InstallerDLCHi.png");
		imageDLCDesc = GetImageFromFomod("fomod/InstallerDLCDesc.png");
    
    	installerForm = CreateCustomForm();
    
		dlcCheckbox = new System.Windows.Forms.PictureBox();
    	rebalanceCheckbox = new System.Windows.Forms.PictureBox();
    	equipmentCheckbox = new System.Windows.Forms.PictureBox();
        cyberwareCheckbox = new System.Windows.Forms.PictureBox();
        coreCheckbox = new System.Windows.Forms.PictureBox();
        contentPicture = new System.Windows.Forms.PictureBox();
		dlcButton = new System.Windows.Forms.PictureBox();
        rebalanceButton = new System.Windows.Forms.PictureBox();
        equipmentButton = new System.Windows.Forms.PictureBox();
        cyberwareButton = new System.Windows.Forms.PictureBox();
        coreButton = new System.Windows.Forms.PictureBox();
        installButton = new System.Windows.Forms.PictureBox();
        exitButton = new System.Windows.Forms.PictureBox();
		((System.ComponentModel.ISupportInitialize)(dlcCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(rebalanceCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(equipmentCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(cyberwareCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(coreCheckbox)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(contentPicture)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(dlcButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(rebalanceButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(equipmentButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(cyberwareButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(coreButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(installButton)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(exitButton)).BeginInit();
        installerForm.SuspendLayout();
		// 
        // dlcCheckbox
        // 
        dlcCheckbox.Image = imageChecked;
        dlcCheckbox.Location = new System.Drawing.Point(613, 115);
        dlcCheckbox.Name = "dlcCheckbox";
        dlcCheckbox.Size = new System.Drawing.Size(64, 62);
        dlcCheckbox.TabIndex = 12;
        dlcCheckbox.TabStop = false;
        // 
        // rebalanceCheckbox
        // 
        rebalanceCheckbox.Image = imageChecked;
        rebalanceCheckbox.Location = new System.Drawing.Point(483, 115);
        rebalanceCheckbox.Name = "rebalanceCheckbox";
        rebalanceCheckbox.Size = new System.Drawing.Size(64, 62);
        rebalanceCheckbox.TabIndex = 11;
        rebalanceCheckbox.TabStop = false;
        // 
        // equipmentCheckbox
        // 
        equipmentCheckbox.Image = imageUnchecked;
        equipmentCheckbox.Location = new System.Drawing.Point(353, 115);
        equipmentCheckbox.Name = "equipmentCheckbox";
        equipmentCheckbox.Size = new System.Drawing.Size(64, 62);
        equipmentCheckbox.TabIndex = 10;
        equipmentCheckbox.TabStop = false;
        // 
        // cyberwareCheckbox
        // 
        cyberwareCheckbox.Image = imageChecked;
        cyberwareCheckbox.Location = new System.Drawing.Point(223, 115);
        cyberwareCheckbox.Name = "cyberwareCheckbox";
        cyberwareCheckbox.Size = new System.Drawing.Size(64, 62);
        cyberwareCheckbox.TabIndex = 9;
        cyberwareCheckbox.TabStop = false;
        // 
        // coreCheckbox
        // 
        coreCheckbox.Image = imageChecked;
        coreCheckbox.Location = new System.Drawing.Point(93, 115);
        coreCheckbox.Name = "coreCheckbox";
        coreCheckbox.Size = new System.Drawing.Size(64, 62);
        coreCheckbox.TabIndex = 8;
        coreCheckbox.TabStop = false;
        // 
        // contentPicture
        // 
        contentPicture.Image = imageLogo;
        contentPicture.Location = new System.Drawing.Point(8, 183);
        contentPicture.Name = "contentPicture";
        contentPicture.Size = new System.Drawing.Size(768, 350);
        contentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        contentPicture.TabIndex = 0;
        contentPicture.TabStop = false;
		// 
        // dlcButton
        // 
        dlcButton.Image = imageDLC;
        dlcButton.Location = new System.Drawing.Point(580, 28);
        dlcButton.Name = "dlcButton";
        dlcButton.Size = new System.Drawing.Size(130, 81);
        dlcButton.TabIndex = 7;
        dlcButton.TabStop = false;
        dlcButton.Click += delegate(object sender, EventArgs e) {
			acceptPlayer.Play();

			if (dlcSelected == true) {
				dlcSelected = false;
				dlcCheckbox.Image = imageUnchecked;
			} else {
				dlcSelected = true;
				dlcCheckbox.Image = imageChecked;
			}
		};
        dlcButton.MouseEnter += delegate(object sender, EventArgs e) {
			dlcButton.Image = imageDLCHi;
			contentPicture.Image = imageDLCDesc;
			hoverPlayer.Play();
		};
        dlcButton.MouseLeave += delegate(object sender, EventArgs e) {
			dlcButton.Image = imageDLC;
			contentPicture.Image = imageLogo;
		};
		// 
        // rebalanceButton
        // 
        rebalanceButton.Image = imageRebalance;
        rebalanceButton.Location = new System.Drawing.Point(450, 28);
        rebalanceButton.Name = "rebalanceButton";
        rebalanceButton.Size = new System.Drawing.Size(130, 81);
        rebalanceButton.TabIndex = 6;
        rebalanceButton.TabStop = false;
        rebalanceButton.Click += delegate(object sender, EventArgs e) {
			acceptPlayer.Play();

			if (rebalanceSelected == true) {
				rebalanceSelected = false;
				rebalanceCheckbox.Image = imageUnchecked;
			} else {
				rebalanceSelected = true;
				rebalanceCheckbox.Image = imageChecked;
			}
		};
        rebalanceButton.MouseEnter += delegate(object sender, EventArgs e) {
			rebalanceButton.Image = imageRebalanceHi;
			contentPicture.Image = imageRebalanceDesc;
			hoverPlayer.Play();
		};
        rebalanceButton.MouseLeave += delegate(object sender, EventArgs e) {
			rebalanceButton.Image = imageRebalance;
			contentPicture.Image = imageLogo;
		};
        // 
        // equipmentButton
        // 
        equipmentButton.Image = imageEquipment;
        equipmentButton.Location = new System.Drawing.Point(320, 28);
        equipmentButton.Name = "equipmentButton";
        equipmentButton.Size = new System.Drawing.Size(130, 81);
        equipmentButton.TabIndex = 6;
        equipmentButton.TabStop = false;
        equipmentButton.Click += delegate(object sender, EventArgs e) {
			acceptPlayer.Play();

			if (equipmentSelected == true) {
				equipmentSelected = false;
				equipmentCheckbox.Image = imageUnchecked;
			} else {
				equipmentSelected = true;
				equipmentCheckbox.Image = imageChecked;
			}
		};
        equipmentButton.MouseEnter += delegate(object sender, EventArgs e) {
			equipmentButton.Image = imageEquipmentHi;
			contentPicture.Image = imageEquipmentDesc;
			hoverPlayer.Play();
		};
        equipmentButton.MouseLeave += delegate(object sender, EventArgs e) {
			equipmentButton.Image = imageEquipment;
			contentPicture.Image = imageLogo;
		};
        // 
        // cyberwareButton
        // 
        cyberwareButton.Image = imageCyberware;
        cyberwareButton.Location = new System.Drawing.Point(190, 28);
        cyberwareButton.Name = "cyberwareButton";
        cyberwareButton.Size = new System.Drawing.Size(130, 81);
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
        coreButton.Location = new System.Drawing.Point(60, 28);
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
		installerForm.Controls.Add(dlcCheckbox);
        installerForm.Controls.Add(rebalanceCheckbox);
        installerForm.Controls.Add(equipmentCheckbox);
        installerForm.Controls.Add(cyberwareCheckbox);
        installerForm.Controls.Add(coreCheckbox);
        installerForm.Controls.Add(contentPicture);
		installerForm.Controls.Add(dlcButton);
        installerForm.Controls.Add(rebalanceButton);
        installerForm.Controls.Add(equipmentButton);
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
		((System.ComponentModel.ISupportInitialize)(dlcCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(rebalanceCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(equipmentCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(cyberwareCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(coreCheckbox)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(contentPicture)).EndInit();
		((System.ComponentModel.ISupportInitialize)(dlcButton)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(rebalanceButton)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(equipmentButton)).EndInit();
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
        stream.Close();        	
        
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
			if (file.StartsWith("fomod", true, null))
				continue;
				
			if (file.StartsWith("optional", true, null))
				continue;
				
			bool found = false;
			foreach (string exclude in excludes) {
				if (file.EndsWith(exclude, true, null) || file.StartsWith(exclude, true, null)) {
					found = true;
					continue;
				}
			}
			if (found)
				continue;

			InstallFileFromFomod(file);
		}
	}
	
	
	static byte[] GenerateInclude(string xmlPath, string includePath, string[] parents)
	{
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			data = new byte[0];
		
		string tmp = encoding.GetString(data);
		
		// Include is already there?
		if (Regex.Match(tmp, "<include src=\"" + Regex.Escape(includePath) + "\" />", RegexOptions.Singleline).Success == true)
			return data;
		
		// Check additional files for the include
		if (parents != null) {
			foreach (string parentFile in parents) {
				byte[] parentData = GetExistingDataFile(parentFile);
				if (parentData == null)
					continue;
					
				if (Regex.Match(encoding.GetString(parentData), "<include src=\"" + Regex.Escape(includePath) + "\" />", RegexOptions.Singleline).Success == true)
					return data;
			}
		}
		
		tmp += "\r\n"
			+ "<!-- BEGIN Added by " + title + " -->\r\n"
			+ "<include src=\"" + includePath + "\" />\r\n"
			+ "<!-- END Added by " + title + " -->\r\n";
		
		return encoding.GetBytes(tmp);
	}
	
	
	static bool AppendIncludeToMenu(string xmlPath, string includePath)
	{
		byte[] data = GetExistingDataFile(xmlPath);
		
		// Generate empty file of nothing there to append yet
		if (data == null)
			return false;
			
		string tmp = encoding.GetString(data);

		// Include is already there?
		if (Regex.Match(tmp, "<include src=\"" + Regex.Escape(includePath) + "\" />", RegexOptions.Singleline).Success == true)
			return true;
		
		string includeStr = "\r\n\r\n"
			+ "\t<!-- BEGIN Added by " + title + " -->\r\n"
			+ "\t<include src=\"" + includePath + "\" />\r\n"
			+ "\t<!-- END Added by " + title + " -->\r\n";
		
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
	
	
	static float ExtractMCMVersion(byte[] data)
	{
		if (data == null)
			return 0;
			
		string tmp = encoding.GetString(data);	
		
		Match m = Regex.Match(tmp, "<_MCM>(.*)</_MCM>", RegexOptions.Singleline);
		
		try {
			if (m.Success)
				return Single.Parse(m.Groups[1].Value, CultureInfo.InvariantCulture);
			else
				return 0;
		} catch (Exception e) {
			return 0;
		}
	}
}
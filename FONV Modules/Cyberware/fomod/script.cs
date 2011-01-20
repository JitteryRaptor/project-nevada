using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using fomm.Scripting;


class Script : Fallout3BaseScript
{
	const string title = "Project NEVADA";

	static ASCIIEncoding encoding;
	
	public static bool OnActivate()
	{
		encoding = new ASCIIEncoding();
		
		if (! InstallModuleCyberware())
			return false;
		
		return true;
	}
	
	static bool InstallModuleCyberware()
	{	
		// Install base files
		string[] excludes = new string[] {
			"includes_TutorialMenu.xml",
			"tutorial_menu.xml"
		};
		InstallModuleFiles(excludes);
		
		UpdateInclude("menus/prefabs/includes_TutorialMenu.xml", @"pnx\pnximplants.xml");
		
		UpdateUIFile("menus/tutorial_menu.xml", "menus/tutorial_menu.xml", "includes_TutorialMenu.xml");
	
		return true;
	}
	
	static void InstallModuleFiles(string[] excludes)
	{	
		foreach (string file in GetFomodFileList()) {
		
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
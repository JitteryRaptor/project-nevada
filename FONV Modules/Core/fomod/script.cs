using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using fomm.Scripting;


class Script : Fallout3BaseScript
{

	private const string Title = "Project Nevada";

	private static ASCIIEncoding Encoding = new ASCIIEncoding();
	
		
	public static void InstallFiles()
	{
		foreach (string file in GetFomodFileList()) {
			if (Path.GetDirectoryName(file) == "fomod")
				continue;
				
			if (Path.GetDirectoryName(file) == "optional")
				continue;

			if (Path.GetFileName(file) == "includes.xml")
				continue;

			InstallFileFromFomod(file);
		}
	}
	
	public static bool AppendInclude(string xmlPath, string includePath)
	{
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			return false;
		
		string tmp = Encoding.GetString(data);
		
		// Include is already there?
		if (Regex.Match(tmp, "<include src=\"" + Regex.Escape(includePath) + "\" />", RegexOptions.Singleline).Success == true)
			return true;
		
		tmp += "\r\n"
			+ "<!-- BEGIN Added by Project Nevada -->\r\n"
			+ "<include src=\"" + includePath + "\" />\r\n"
			+ "<!-- END Added by Project Nevada -->\r\n";
		
		data = Encoding.GetBytes(tmp);
			
		GenerateDataFile(xmlPath, data);
		
		return true;
	}
	
	public static bool AppendIncludeToMenu(string xmlPath, string includePath)
	{
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			return false;
			
		string tmp = Encoding.GetString(data);

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
		
		data = Encoding.GetBytes(tmp);
			
		GenerateDataFile(xmlPath, data);
		
		return true;
	}
	
	public static bool InstallFileFromFomod(string source, string target)
	{
		byte[] data = GetExistingDataFile(source);
		if (data == null)
			return false;
		
		return GenerateDataFile(target, data);
	}

	public static bool OnActivate()
	{
	
		string text;
	
		// Check NVSE - Had problems false positives on this, so disabled for now
		//if (! ScriptExtenderPresent()) {
		//	text = "The Fallout: New Vegas Script Extender is required to use this mod! Installation aborted.";
		//	MessageBox(text, Title);
		//	return false;
		//}
		
		// Install base files
		InstallFiles();
		
		// Modify includes.xml if necessary
		if (! DataFileExists("menus/prefabs/includes.xml")) {
			InstallFileFromFomod("menus/prefabs/includes.xml");
		} else {
				// 
			bool editSuccess = AppendInclude("menus/prefabs/includes.xml", @"pnx\pnxhud.xml");
		
			if (! editSuccess) {
				text = "Failed to access includes.xml. Guess you'll have to edit it manually (see readme)";
				MessageBox(text, Title);
			}
		

		}

		// Modify hud_main_menu.xml	if necessary
		if (! DataFileExists("menus/main/hud_main_menu.xml")) {
			InstallFileFromFomod("optional/Default HUD/menus/main/hud_main_menu.xml", "menus/main/hud_main_menu.xml");
		} else {

			bool editSuccess = AppendIncludeToMenu("menus/main/hud_main_menu.xml", "includes.xml");
		
			if (! editSuccess) {
				text = "Failed to access hud_main_menu.xml. Guess you'll have to edit it manually (see readme)";
				MessageBox(text, Title);
			}
		}
	
		return true;
	}
}
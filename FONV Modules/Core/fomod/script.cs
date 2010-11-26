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


	public static bool IsPluginInstalled(String name)
	{
	    string[] installedPlugins = GetAllPlugins();
	    foreach (string plugin in installedPlugins)
	        if (plugin.Equals(name, StringComparison.InvariantCultureIgnoreCase))
	             return true;
	    return false;
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
	
	public static void InstallFiles()
	{
		foreach (string file in GetFomodFileList()) {
			if (Path.GetDirectoryName(file) == "fomod")
				continue;

			if (Path.GetFileName(file) == "includes.xml")
				continue;

			InstallFileFromFomod(file);
		}
	}

	public static bool OnActivate()
	{
	
		string text;
	
		// Check NVSE
		if (! ScriptExtenderPresent()) {
			text = "The Fallout: New Vegas Script Extender is required to use this mod! Installation aborted.";
			MessageBox(text, Title);
			return false;
		}
		
		// Install base files
		InstallFiles();
		
		// No need for editing, we're done
		if (! DataFileExists("menus/prefabs/includes.xml")) {
			InstallFileFromFomod("menus/prefabs/includes.xml");
			return true;
		}
		
		// Modify includes.xml
		bool editSuccess = AppendInclude("menus/prefabs/includes.xml", @"pnx\pnxhud.xml");
		
		if (! editSuccess) {
			text = "Failed to access includes.xml. Guess you'll have to edit it manually (see readme)";
			MessageBox(text, Title);
		}
		
		// Modify hud_main_menu.xml
		editSuccess = AppendIncludeToMenu("menus/main/hud_main_menu.xml", "includes.xml");
		
		if (! editSuccess) {
			text = "Failed to access hud_main_menu.xml. Guess you'll have to edit it manually (see readme)";
			MessageBox(text, Title);
		}
		
	
		return true;
	}
}
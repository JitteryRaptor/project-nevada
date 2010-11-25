using System;
using System.Text;
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
		
		tmp += "\r\n"
			+ "<!-- BEGIN Added by Project Nevada -->\r\n"
			+ "<include src= \"" + includePath + "\" />\r\n"
			+ "<!-- END Added by Project Nevada -->\r\n";
		
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
	
		// check NVSE
		if (! ScriptExtenderPresent()) {
			text = "The Fallout: New Vegas Script Extender is required to use this mod! Installation aborted.";
			MessageBox(text, Title);
			return false;
		}
		
		// install base files
		InstallFiles();
		
		// No need for editing, we're done
		if (! DataFileExists("menus/prefabs/includes.xml")) {
			InstallFileFromFomod("menus/prefabs/includes.xml");
			return true;
		}
		
		// Edit XML includes
		bool editSuccess = AppendInclude("menus/prefabs/includes.xml", @"pnx\pnxhud.xml");
		
		if (! editSuccess) {
			text = "Failed to edit includes.xml. Guess you'll have to do it manually (see readme)";
			MessageBox(text, Title);
		}
	
		return true;
	}
}
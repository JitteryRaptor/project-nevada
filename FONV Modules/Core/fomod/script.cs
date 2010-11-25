using System;
//using System.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;
using fomm.Scripting;

class Script : BaseScript {

	private const string Title = "Stealth Boy Reworked";

	private static ASCIIEncoding Encoding = new ASCIIEncoding();


	public static bool IsPluginInstalled(String name) {
	    string[] installedPlugins = GetAllPlugins();
	    foreach (string plugin in installedPlugins)
	        if (plugin.Equals(name, StringComparison.InvariantCultureIgnoreCase))
	             return true;
	    return false;
	}
	
	public static void BackupDataFile(string path) {
		byte[] data = GetExistingDataFile(path);
		
		if (data == null)
			return;
			
		GenerateDataFile(path + ".backup", data);
	}
	
	public static bool AppendIncludeToMenu(string xmlPath, string includePath) {
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			return false;
		
		string includeStr = "\r\n\r\n"
			+ "\t<!-- BEGIN Added by Stealth Boy Reworked -->\r\n"
			+ "\t<include src= \"" + includePath + "\" />\r\n"
			+ "\t<!-- END Added by Stealth Boy Reworked -->\r\n\r\n";
		
		string tmp = Encoding.GetString(data);
		
		tmp = Regex.Replace(tmp,
			"<menu name=\"(\\w+)\">(.*)</menu>\\s*$",
			"<menu name=\"$1\">$2" + includeStr + "</menu>",
			RegexOptions.Singleline);
		
		data = Encoding.GetBytes(tmp);
			
		GenerateDataFile(xmlPath, data);
		
		return true;
	}
	
	// normally better than regex, but messes up formating
	/*public static bool AppendIncludeToXml2(string xmlPath, string includePath) {
		byte[] data = GetExistingDataFile(xmlPath);
		
		if (data == null)
			return false;
		
		try {
			// Replace & with &amp;
			data = Encoding.GetBytes(new Regex(@"&").Replace(Encoding.GetString(data), @"&amp;"));
		
			XmlDocument document = new XmlDocument();
		
			using (MemoryStream inStream = new MemoryStream(data)) {
				document.Load(inStream);
		
				XmlComment comment = document.CreateComment("Inserted by Stealth Boy Reworked:");
				document.DocumentElement.InsertAfter(comment, document.DocumentElement.LastChild);
		
				XmlElement element = document.CreateElement("include");
				XmlAttribute attribute = document.CreateAttribute("src");
				attribute.Value = includePath;
				element.SetAttributeNode(attribute);
				document.DocumentElement.InsertAfter(element, document.DocumentElement.LastChild);
			
				inStream.Close();
			}
		
		
			using (MemoryStream outStream = new MemoryStream()) {
				document.Save(outStream);
				data = outStream.ToArray();
			
				outStream.Close();
			}
		
			// Replace &amp; with &
			data = Encoding.GetBytes(new Regex(@"&amp;").Replace(Encoding.GetString(data), @"&"));
		
			GenerateDataFile(xmlPath, data);
		
		} catch (Exception e) {
			return false;
		}
	
		return true;
	}*/

	public static bool OnActivate() {
	
		string text;
	
		// check FOMM
		if (! ScriptExtenderPresent()) {
			text = "The Fallout 3 Script Extender is required to use this mod. Installation aborted.";
			MessageBox(text, Title);
			return false;
		}
		
		// install base files
		InstallFileFromFomod("StealthBoyReworked.esp");
		SetPluginActivation("StealthBoyReworked.esp", true);
		InstallFileFromFomod("readme - Stealth Boy Reworked.txt");
		
		// ask for HUD
		text = "Would you like to have your Stealth Boy status displayed in the HUD?";
		DialogResult hudChoice = MessageBox(text, Title, MessageBoxButtons.YesNo);
		
		// No HUD, we're done
		if (hudChoice == DialogResult.No)
			return true;
		
		// install HUD base files
		InstallFileFromFomod("textures/interface/hud/glow_hud_right_sf_seperator.dds");
		InstallFileFromFomod("menus/prefabs/schlang/stealthmeter_vanilla.xml");
		InstallFileFromFomod("menus/prefabs/schlang/stealthmeter_dui.xml");
		
		// No need for editing, we're done
		if (! DataFileExists("menus/main/hud_main_menu.xml")) {
			InstallFileFromFomod("menus/main/hud_main_menu.xml");
			return true;
		}
		
		// ask for auto edit
		text = "Automatically edit hud_main_menu.xml?\n"
			+ "If you select No you will have to edit the file manually (see readme).\n"
			+ "If you select Yes, you will be asked to confirm the overwrite.";
		DialogResult autoEditChoice = MessageBox(text, Title, MessageBoxButtons.YesNo);
		
		// No auto edit, we're done
		if (autoEditChoice == DialogResult.No)
			return true;
		
		// 5. edit XML file
		bool duiInstalled = IsPluginInstalled("DarNifiedUIF3.esp");

		string includePath = @"schlang\stealthmeter_" + (duiInstalled ? "dui" : "vanilla") + ".xml";
	
		bool editSuccess = AppendIncludeToMenu("menus/main/hud_main_menu.xml", includePath);
		
		if (! editSuccess) {
			text = "Automated edit failed. Guess you'll have to do it manually (see readme)";
			MessageBox(text, Title);
		}
	
		return true;
	}
}
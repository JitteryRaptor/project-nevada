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

	const string title = "NVSR Patcher";
	
	public static bool OnActivate()
	{
		byte[] data = GetExistingDataFile("NVSE/Plugins/sr_New_Vegas_Stutter_Remover.dll");		
		if (! ApplyPatch(data, "sr_New_Vegas_Stutter_Remover.dif"))
			return false;
		
		return GenerateDataFile("NVSE/Plugins/sr_New_Vegas_Stutter_Remover.dll", data);
	}
	
	static Stream GetStreamFromFomod(string filename)
	{  
		byte[] data = GetFileFromFomod(filename);
		
		if (data == null)
			return null;
			
        return new MemoryStream(data);
    }
    
    static bool ApplyPatch(byte[] data, string patchFile)
	{
		Stream stream = GetStreamFromFomod("fomod/" + patchFile);
		if (stream == null)
			return false;
			
		TextReader tr = new StreamReader(stream);
		
		string line;
		while((line = tr.ReadLine()) != null) {
			Match m = Regex.Match(line, "([0-9a-fA-F]+): ([0-9a-fA-F]+) ([0-9a-fA-F]+)", RegexOptions.Singleline);
		
			try {
			
				UInt32 addr = UInt32.Parse(m.Groups[1].Value, NumberStyles.HexNumber);
				byte oldVal = (byte)UInt32.Parse(m.Groups[2].Value, NumberStyles.HexNumber);
				byte newVal = (byte)UInt32.Parse(m.Groups[3].Value, NumberStyles.HexNumber);
				
				if (data[addr] == oldVal) {
					data[addr] = newVal;
				} else {
					MessageBox("Patching " + addr + " failed.", title);
					return false;
				}
				
			} catch (Exception e) {
				return false;
			}
		}
		tr.Close();
		
		return true;
	}
}
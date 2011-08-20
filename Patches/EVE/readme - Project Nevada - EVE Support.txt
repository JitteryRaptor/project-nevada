########################################################################################################################################
	 _____           _           _    
	|  __ \         (_)         | |   
	| |__) | __ ___  _  ___  ___| |_  
	|  ___/ '__/ _ \| |/ _ \/ __| __| 
 	| |   | | | (_) | |  __/ (__| |_  
	|_|   |_|  \___/| |\___|\___|\__|
	                /_/ 						
	 _   _ ________      __     _____
	| \ | |  ____\ \    / /\   |  __ \   /\
	|  \| | |__   \ \  / /  \  | |  | | /  \
	| . ` |  __|   \ \/ / /\ \ | |  | |/ /\ \
	| |\  | |____   \  / ____ \| |__| / ____ \
	|_| \_|______|   \/_/    \_\_____/_/    \_\

	 _____      _        _              
	| ___ \    | |      | |             
	| |_/ /__ _| |_  ___| |__   ___ ___ 
	|  __// _` | __|/ __| '_ \ / _ | __|
	| |  | (_| | |_| (__| | | |  __|__ \
	|_|   \__,_|\__|\___|_| |_|\___|___/

########################################################################################################################################

Project Nevada - EVE Support

Authors: snakster + Gribbleshnibit8
Contributors: Jonnyeah, Weijiesen

Current Version: 1.0

Download: http://www.newvegasnexus.com/downloads/file.php?id=42363

########################################################################################################################################

	1. Introduction

	2. Changelog
	
	3. Features

	4. Installation

	5. Troubleshooting

	6. Credits & Acknowledgements
	
	7. Contact
	
	8. Permissions

########################################################################################################################################

The following mods are required:

* EVE - Essential Visual Enhancements
	http://www.newvegasnexus.com/downloads/file.php?id=42666
	
* Project Nevada - Equipment Module
	http://www.newvegasnexus.com/downloads/file.php?id=40040
	
########################################################################################################################################



========================================================================================================================================
 1. Introduction
========================================================================================================================================

With this patch, the chargeable weapons in Project Nevada Core and Equipment make use of the enhanced visual effects added by EVE.


========================================================================================================================================
 2. Changelog
========================================================================================================================================

1.0:
- Initial release


========================================================================================================================================
 3. Features
========================================================================================================================================

* AER14 Prototype
	Green charged powered beams have been replaced with purple versions to match the EVE projectile.
	
* AES18 Prototype
	Model has been replaced by EVE's Tri-Beam Laser Rifle with a custom sight that indicate the current charging stage.


========================================================================================================================================
 4. Installation
========================================================================================================================================

We really recommend using the Fallout Mod Manager to install any of these patches!
It will automatically copy the right files and warn you in case you miss any of the required mods.
So before you can get started, you have to choose whether you want to do the FOMM installation (recommended) or a manual installation.

------------------------------------------------------------
 a) Installation with FOMM
------------------------------------------------------------

1.	Start FOMM and click on Package Manager.

2.	In the top-right button menu, click on Add FOMod and select the downloaded archive file.

3.	The patch will now appear in the list. Select it and click Activate. 

4.	If you are prompted to overwrite anything, click Yes to All.

5.	Done!

OR

------------------------------------------------------------
 b) Manual Installation
------------------------------------------------------------

1.	Locate the Data/ folder in your Fallout New Vegas installation directory.
	Typically it's found at Program Files/Steam/SteamApps/common/fallout new vegas/Data/.

2.	Extract the contents of the downloaded archive file to your Data/ folder.

3.	In the New Vegas Launcher, click on Data Files and enable Project Nevada - EVE.esp.

4.	Done!

------------------------------------------------------------
 c) Load Order
------------------------------------------------------------

The Project Nevada EVE patch has to be loaded after the EVE plugin file itself, otherwise your game will not start!
Arrange your load order like this:

		...

	Project Nevada - Core.esm
	Project Nevada - Equipment.esm

		...

	EVE FNV.esp

		...

	Project Nevada - EVE.esp

		...

========================================================================================================================================
 5. Troubleshooting
========================================================================================================================================

Problem: My game crashes right after starting it!

Solution: There are basically two things that can cause this:
	1)	A missing requirement (some plugins depend on other plugins, and if they can't find them the game crashes).
		To fix this, make sure have EVE and the Project Nevada Equipment Module installed.
		Also don't forgot to adjust your load order as described in the next point.
                
	2)	Your load order is wrong.
		You can fix your load order in FOMM by dragging plugins in the mod list. Make sure all patches you're using are placed after
		their requirements. Refer to the previous section for an example.


========================================================================================================================================
 6. Credits
========================================================================================================================================

Weijiesen, author of EVE, for purple laser beams
Jonnyeah, co-author of EVE, for modified EVE Tri-Beam laser model that supports displaying the charging state


========================================================================================================================================
 7. Contact
========================================================================================================================================

For direct contact, send a PM to Gribbleshnibit8 or schlangster at

	http://www.newvegasnexus.com/
		or
	http://forums.bethsoft.com/

If you need help, please leave a comment on our Nexus page instead of contacting us directly.

	
========================================================================================================================================
 8. Permissions
========================================================================================================================================	

Some assets in Project Nevada belong to other authors.
You will need to seek permission from these authors before you can use their assets.

Other than that, you may upload these files to other sites, convert it to work with other games, modify anything or release bug fixes
and improvements, and use our assets without permission, but please give proper credit if you do so.

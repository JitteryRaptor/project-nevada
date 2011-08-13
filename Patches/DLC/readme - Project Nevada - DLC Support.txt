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

Project Nevada - DLC Support

Authors: Gribbleshnibit8 and snakster
Contributors: Aether89, T3T, Zealotlee

Current Version: 1.2

Download: http://www.newvegasnexus.com/downloads/file.php?id=42363

########################################################################################################################################

	1. Introduction

	2. Changelog
	
	3. Features
		a) Dead Money
		b) Honest Hearts
		c) Old World Blues

	4. Installation

	5. Troubleshooting

	6. Credits & Acknowledgements
	
	7. Contact
	
	8. Permissions

########################################################################################################################################



========================================================================================================================================
 1. Introduction
========================================================================================================================================

These patches enable support of all Project Nevada features for DLC-added items. This includes new Visor Overlays for helmets and custom
Grenade Hotkey icons for explosives. When using FOMM, the installer will automatically detect which DLC are installed and select the
appropriate patches.


========================================================================================================================================
 2. Changelog
========================================================================================================================================

1.2:

[Old World Blues]
- Initial release


1.1:

[Dead Money] 
- Added digital zoom to Holo Rifle


1.0:

[Dead Money]
- Initial release

[Honest Hearts]
- Initial release


========================================================================================================================================
 3. Features
========================================================================================================================================

The DLC modules add support for individual DLC. Each is a separate file that adds armors and weapons to the correct lists to work with
the Project Nevada system.

------------------------------------------------------------
 a) Dead Money
------------------------------------------------------------

* Visor Overlays
	A custom visor overlay has been added to the Sierra Madre Security Helmets.

* Grenade Hotkey
	The grenades and throwable weapons have been added to the appropriate lists.
	As soon as you get to the Sierra Madre, you can use	the	new weapons with your standard hotkey.
	
* Stealth Field
	The Assassin suit has been given a stealth field.
	
* Weapon Zoom
	The Holo Rifle now uses digital zooming.

------------------------------------------------------------
 b) Honest Hearts
------------------------------------------------------------

* Visor Overlays
	A custom visor overlay has been added to Salt-Upon-Wounds' Helmet.
	The Deser Ranger Combat Helmet has been given the appropriate overlay.

* Grenade Hotkey
	The grenades and throwable weapons have been added to the appropriate lists.
	As soon as you get to the Zion, you can use the new	weapons with your standard hotkey.
	
------------------------------------------------------------
 c) Honest Hearts
------------------------------------------------------------

* Visor Overlays
	TODO

* Grenade Hotkey
	TODO

* Stealth Field
	TODO
	
* Cyberware Implants
	The M-5, C-13, Y-3, Y-7 and GRX implants have been converted to be usable with the PN Cyberware interface.
	All implants can additionally by upgraded one level. Here's a description of what each implant does now:
	
		C-13
			Level 1: +10% damage to Cazadores
			Level 2: +20% damage to Cazadores and a passive radio field that frenzies them over time
			
		M-5
			Level 1: +20% movement speed when crouched
			Level 2: +40% movement speed when crouched
		
		Y-3
			Level 1: Radiation from contaminated drinks is neutralized
			Level 2: Radiation from contaminated drinks is absorbed and converted into Action Points
		
		Y-7
			Level 1: Consuming food restores additional  5 HP and 2 AP
			Level 2: Consuming food restored additional 10 HP and 4 AP
			
		GRX
			The GRX implant is no longer a perk but buyable at the Sink Autodoc like the other implants.
			It's effects depend on whether Bullet Time is enabled or not.
			
			[Bullet Time enabled]
			Level 1: Bullet Time Action Point drain reduced by 25%
			Level 2: Bullet Time Action Point drain reduced by 50%
			
			[Bullet Time disabled]
			Level 1: Non-addictive Turbo is added to the inventory, lasts for 2 seconds,  5 uses per day
			Level 2: Non-addictive Turbo is added to the inventory, lasts for 4 seconds, 10 uses per day
	
	The implants are upgradable by bringing the un-installed implant item to a workbench.

* Hoarder Trait
	The Hoarder Trait has been adjusted to work with modified Carry Weight formulas.
	Instead of having the penality limit hardcoded at 130 lbs., it's now kicks in when below 75% maximum Carry Weight.
	Also, being close to (but still below) the weight limit will no longer prevent you from sprinting.


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

3.	In the New Vegas Launcher, click on Data Files and select the plugins you want.

4.	Done!


We really recommend using the Fallout Mod Manager to install any of these patches!
It will automatically copy the right files and warn you in case you miss any of the required mods.
So before you can get started, you have to choose whether you want to do the FOMM installation (recommended) or a manual installation.
The procedure is the same for all patches.


========================================================================================================================================
 5. Troubleshooting
========================================================================================================================================

Problem: My game crashes right after starting it!

Solution: This happens when you activated a DLC patch without owning the respective DLC. To fix it, find this patch and deactivate it
	by unchecking it either in FOMM or the New Vegas Launcher.


========================================================================================================================================
 6. Credits
========================================================================================================================================

Aether89, texture for Salt-Upon-Wound's visor overlay.
T3T, for custom grenade and throwables icons.
Zealotlee, for the Sierra Madre visor overlay.


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

You may upload these files to other sites, convert it to work with other games, modify anything or release bug fixes and
improvements, and use our assets without permission, but please give proper credit if you do so.

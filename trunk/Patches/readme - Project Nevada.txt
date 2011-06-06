########################################################################################################################################
	_____           _           _    
	|  __ \         (_)         | |   
	| |__) | __ ___  _  ___  ___| |_  
	|  ___/ '__/ _ \| |/ _ \/ __| __| 
 	| |   | | | (_) | |  __/ (__| |_  
	|_|   |_|  \___/| |\___|\___|\__|
	                /_/ 						
	 _   _ ________      __     _____          		     _____ _           ______      _        _              
	| \ | |  ____\ \    / /\   |  __ \   /\    			|_   _| |          | ___ \    | |      | |             
	|  \| | |__   \ \  / /  \  | |  | | /  \   	______    | | | |__   ___  | |_/ /__ _| |_  ___| |__   ___ ___ 
	| . ` |  __|   \ \/ / /\ \ | |  | |/ /\ \  |______|   | | | '_ \ / _ \ |  __// _` | __|/ __| '_ \ / _ | __|
	| |\  | |____   \  / ____ \| |__| / ____ \ 			  | | | | | |  __/ | |  | (_| | |_| (__| | | |  __|__ \
	|_| \_|______|   \/_/    \_\_____/_/    \_\			  \_/ |_| |_|\___| \_|   \__,_|\__|\___|_| |_|\___|___/

########################################################################################################################################

Team: snakster, Kai Hohiro, delamer, T3T, Zealotlee, Yukichigai, TheCastle, x-quake, Gopher, Mezmorki

Current Version: 1.0

Download: To be added when a page is created

########################################################################################################################################

Part I - General

	1. Introduction

	2. Changelog

	3. Installation

	4. Troubleshooting

	5. Credits & Acknowledgements
	
	6. Contact
	
	7. Permissions
	

Part II - Module Details

	1. DLC
		a) Dead Money
		b) Honest Hearts
	
	2. Other Mods
		a) WMX/WME

########################################################################################################################################
# PART I ###############################################################################################################################
########################################################################################################################################



========================================================================================================================================
 1. Introduction
========================================================================================================================================

Project Nevada is a mod aiming to make Fallout: New Vegas a more interesting - eventually more challenging - but surely more fun
experience for you. Created by the team responsible for the Fallout 3 Wanderers Edition (FWE), we're leaving the barren DC wasteland
behind and move on west to new, exciting regions.

Project Nevada is not an overhaul, instead it's organized as a set of themed modules. Each module can address different aspects of the
game and target different audiences, but they are also designed to work in conjunction. Our vision is to allow players picking the
modules they want and using them together with any mod they like, instead of forcing them to make the all-or-nothing choice.

Further general objectives and design concepts are:
* Easy installation and setup; no load order or complicated dependencies.
* Great customization through different modules and an in-game menu
* Rather keep things straightforward and enjoyable than overly complicated and tedious.
* Avoid changes that could conflict with other mods unless they are absolutely necessary.
* Blend features in as good as possible - players shouldn't feel reminded that they're using a mod.

For further reading, this document is organized in two parts. The first part contains general information, which besides this
introduction, includes an installation guide in Section 2 and a list of the most common problems in Section 3.

Part two contains detailed information about the Project Nevada modules. It may contain spoilers and is generally not required
to get the mod running.


========================================================================================================================================
 2. Changelog
========================================================================================================================================

------------------------------------------------------------
1.0:

[Core]
- Initial release

[Cyberware]
- Initial release


========================================================================================================================================
 3. Installation
========================================================================================================================================

We really recommend using the Fallout Mod Manager to install Project Nevada - The Patches!
It will automatically copy the right files and take care of any conflicts with already installed mods.
So before you can get started, you have to choose whether you want to do the FOMM installation (recommended) or a manual installation.

Remember: Project Nevad and the Core module are required in any case! If you don't like a specific feature, you can disable it in-game.

------------------------------------------------------------
 a) Installation with FOMM
------------------------------------------------------------

1.	Start FOMM and click on Package Manager.

2.	In the top-right button menu, click on Add FOMod and select the downloaded archive file.

3.	Project Nevada - The Patches will now appear in the list. Select it and click Activate.

4.	In the installer window, select the modules you want, then click Install.
	If you are prompted to overwrite anything, click Yes to All.

5.	Done!

OR

------------------------------------------------------------
 b) Manual Installation
------------------------------------------------------------

1.	Locate the Data/ folder in your Fallout New Vegas installation directory.
	Typically it's found at Program Files/Steam/SteamApps/common/fallout new vegas/Data/.

2.	Extract the contents of the downloaded archive file to your Data/ folder.
	If you are prompted to overwrite anything, click Yes to All.

4.	In the New Vegas Launcher, click on Data Files and select the plugins you want.

5.	Done!


========================================================================================================================================
 4. Troubleshooting
========================================================================================================================================

------------------------------------------------------------
Problem: My game crashes right after starting it!

Solution: Yes, that's pretty annoying! There are basically two things that can cause this:
	1)	A missing master file (some plugins depend on other plugins, and if they can't find them the game crashes)
		If related to Project Nevada, this happens if you didn't install the Core plugin (which is required by all other modules!)
		Fix it, by installing the Core module as well.
		
------------------------------------------------------------
Problem: After I load a save game, a message box tells me that Project Nevada wasn't properly installed.

Solution: Again, two things that can cause this:
	1)	Project Nevada wasn't properly installed :) If you did a manual install and forgot to follow step 3 in the guide above, this is
		what happens. To fix it, install Project Nevada properly as described in Section 3.
		
	2)	If this problem suddenly occurs when you were already running Project Nevada successfully, this means some other mod overwrote
		an interface file. With FOMM, this should be fixed by simply deactivating Project and then activating it again.
		If you don't use FOMM then this is where things will get complicated. First you have to find out which other mod causes the
		conflicts, and then you should go to
			http://www.newvegasnexus.com/downloads/file.php?id=39442
		and ask for help in the comments.
		
------------------------------------------------------------
Problem: After I installed Project Nevada, my game is lagging/stuttering more than usual.

Solution: Even though we tried to optimize our scripts as good as possible, they can still cause considerable strain especially if your
	computer barely meets the minimum system requirements for Fallout: New Vegas.
	You should try out the New Vegas Stutter Remover (http://www.newvegasnexus.com/downloads/file.php?id=34832), in most cases it will
	will significantly increase performance. If that doesn't help, try deactivating some of the features, for example the crosshair
	recoil.
	
------------------------------------------------------------
Problem: Since I installed Project Nevada, my game is very unstable and crashes all the time!

Solution: Personally, I've been playing with Project Nevada for over 20 hours without a single crash. Same goes for our other testers.
	So currently the mod is not known to cause any instabilities. The problem is most likely somewhere else.
	
------------------------------------------------------------
Problem: After I installed Project Nevada MANUALLY, another interface-related mod is no longer working.

Solution: Unfortunately, when doing a MANUAL install this can't be avoided. Either the last installed UI mod automatically overwrites
	files of all previous ones, or installation will become very complex for the user. We chose the former. If you can't fix the problem
	yourself by editing the XML files, the solution is simple - just use the FOMM installer, it should automatically resolve any
	conflicts.


========================================================================================================================================
 5. Credits & Acknowledgements
========================================================================================================================================

DLC:
Aether89, texture for Salt-Upon-Wound's visor overlay
Zealotlee, for the Sierra Madre visor overlay
T3T, for custom grenade and throwables icons

WMX/WME:
Antistar, for modded weapon models
yukichigai, for modded weapon models
StapleNinja, for an edited SVD Dragunov texture


We thank all of them for granting us permission to use their work in our mod.

Thanks to our external testers, who helped a great deal with improving the overall quality of this mod:
	gyshall, mikekearn, Ren Lotus, robber804, ToJKa (in alphabetical order)

And - last but not least - thanks to the NVSE team, because without their Script Extender creating this mod wouldn't have been possible.


========================================================================================================================================
 6. Contact
========================================================================================================================================

For direct contact, send a PM to schlangster at

	http://www.newvegasnexus.com/
		or
	http://forums.bethsoft.com/

If you need help, please leave a comment on our Nexus page instead of contacting me directly.

	
========================================================================================================================================
 7. Permissions
========================================================================================================================================	

Some assets in Project Nevada belong to other authors.
You will need to seek permission from these authors before you can use their assets.

You may upload Project Nevada to other sites, convert it to work with other games, modify anything or release bug fixes and
improvements, and use our assets without permission, but please give proper credit if you do so.

If you want to upload Project Nevada to a different site, please notify us before doing so.




########################################################################################################################################
# PART II ##############################################################################################################################
########################################################################################################################################



========================================================================================================================================
 1. DLC
========================================================================================================================================

The DLC modules add support for individual DLC. Each is a separate file that adds armors and weapons to the correct lists to work with
the Project Nevada system.

------------------------------------------------------------
 a) Dead Money
------------------------------------------------------------

* Visor Overlays
	A custom visor overlay has been added to the Sierra Madre Security Helmets.

* Grenade Hotkey
	The grenades and throwable weapons have been added to the appropriate lists. As soon as you get to the Sierra Madre, you can use the
	new weapons with your standard hotkey.
	
* Stealth
	The Assassin suit has been given a standard hotkey stealth field.

------------------------------------------------------------
 b) Honest Hearts
------------------------------------------------------------

* Visor Overlays
	A custom visor overlay has been added to Salt-Upon-Wounds' Helmet.
	The Deser Ranger Combat Helmet has been given the appropriate overlay.

* Grenade Hotkey
	The grenades and throwable weapons have been added to the appropriate lists. As soon as you get to the Zion, you can use the
	new weapons with your standard hotkey.
	
	
========================================================================================================================================
 2. WMX/WME
========================================================================================================================================

Support for WMX and WME is handled through plugins. These plugins add more weapon mods to many of the new weapons added in Project
Nevada. The Project Nevada weapons use a series of new and existing (WME or WMX) mods, so finding weapon mods will be easy. In fact,
several of the mods you have should work on some of your new weapons.

------------------------------------------------------------
a) WMX Weapons List
------------------------------------------------------------

.22 Revolver - PNxEWeap32Pistol
-*HD Cylinder						Increase Max Condition
-*Long Barrel						Increase Weapon Damage
-*Custom Action						Increase Rate of Fire

5mm Sub Machine Gun
-^Laser Sight						Uses 10mm laser sight (renamed in WME and WMX)

Alien Atomizer
-#Alien Blaster Exp. Mag. Accel.	Increase Projectile Speed
-#Extended Alien Power Cells		Increase Clip Capacity
-#Embedded Laser Sight				Decrease Spread

Alien Disintegrator
-#Alien Blaster Exp. Mag. Accel.	Increase Projectile Speed
-#Embedded Laser Sight				Decrease Spread

Alloy Steel Assault Rifle
-*5.56mm Drum Magazine				Increase Clip Capacity
-*Assault Rifle Scope				Increase Zoom
-*Assault Rifle Silencer			Silence

Alloy Steel Combat Shotgun
-*Combat Shotgun Choke				Decrease Spread
-*Combat Shotgun Saddle Drums		Increase Clip Capacity

Assault Rifle
-*5.56mm Drum Magazine				Increase Clip Capacity
-*Assault Rifle Scope				Increase Zoom
-*Assault Rifle Silencer			Silence

Captain's Sidearm
-#Extended Alien Power Cells		Increase Clip Capacity
-#Alien Blaster Exp. Mag. Accel.	Increase Projectile Speed

Chinese Assault Rifle
-*5.56mm Drum Magazine				Increase Clip Capacity
-#^5.56mm Recoil Comp				(used LMG recoil comp added by WMX, renamed by me)
-*Assault Rifle Scope				Increase Zoom

Chinese Pistol
-*Chinese Pistol Ext. Mags			Increase Clip Capacity
-^Laser Sight						Uses 10mm laser sight (renamed in WME and WMX)
-*Chinese Pistol Long Barrel		Increase Weapon Damage

Chinese Sniper Rifle
-^Sniper Rifle Suppressor			Silence
-#Sniper Rifle Ext. Mags			Increase Clip Capactiy

Combat Shotgun
-*Combat Shotgun Choke				Decrease Spread
-*Combat Shotgun Saddle Drums		Increase Clip Capacity

Double-Barrel Shotgun
-^12 Guage Shotgun Choke			Decrease Spread
-#Sawed-off Shotgun Imp. Parts		Increase Max Condition

Dragoon Assault Rifle
-*5.56mm Drum Magazine				Increase Clip Capacity
-#^5.56mm Recoil Comp				(used LMG recoil comp added by WMX, renamed by me)
-*Assault Rifle Scope				Increase Zoom

Dragoon Pistol
-*Chinese Pistol Ext. Mags			Increase Clip Capacity
-^Laser Sight						Uses 10mm laser sight (renamed in WME and WMX)
-*Chinese Pistol Long Barrel		Increase Weapon Damage

Infiltrator
-*5.56mm Drum Magazine				Increase Clip Capacity
-*Infiltrator Improved Rifling		Increase Weapon Damage
-^Laser Sight						Uses 10mm laser sight (renamed in WME and WMX)

Lever-Action Rifle
-#Trail Carbine Custom Action
-*Lever-Action Rifle Long Barrel
-*Lever-Action rifle Long Scope

Plasma Repeater
-*Plasma Repeater Ext. Mags			Increase Clip Capacity
-*Plasma Repeater Scope 			Increase Zoom

Replica Repeater
-#Trail Carbine Custom Action
-*Lever-Action Rifle Long Barrel
-*Lever-Action rifle Long Scope

Tesla Rifle
-*Tesla Rifle Feeder Cylinders		Increase Weapon Damage
-*Tesla Rifle Oscillation Stabilizer Decrease Spread
-#Plasma Rifle Dual Cell			Increase Clip Capacity

The People's Rifle
-^Sniper Rifle Suppressor			Silence
-#Sniper Rifle Ext. Mags			Increase Clip Capactiy

Key
* Mod new to PN - WMx
# WMX added or edited mod
^ Vanilla mod edited by WMx


------------------------------------------------------------
 b) WME Weapons List
------------------------------------------------------------

TO BE WRITTEN
########################################################################################################################################
	 _____           _           _    
	|  __ \         (_)         | |   
	| |__) | __ ___  _  ___  ___| |_  
	|  ___/ '__/ _ \| |/ _ \/ __| __| 
 	| |   | | | (_) | |  __/ (__| |_  
	|_|   |_|  \___/| |\___|\___|\__|
	                /_/ 						
	 _   _ ________      __     _____                     ______      _                ____        _   _                 
	| \ | |  ____\ \    / /\   |  __ \   /\              |  ____|    | |              / __ \      | | (_)                
	|  \| | |__   \ \  / /  \  | |  | | /  \     ______  | |__  __  _| |_ _ __ __ _  | |  | |_ __ | |_ _  ___  _ __  ___ 
	| . ` |  __|   \ \/ / /\ \ | |  | |/ /\ \   |______| |  __| \ \/ / __| '__/ _` | | |  | | '_ \| __| |/ _ \| '_ \/ __|
	| |\  | |____   \  / ____ \| |__| / ____ \           | |____ >  <| |_| | | (_| | | |__| | |_) | |_| | (_) | | | \__ \
	|_| \_|______|   \/_/    \_\_____/_/    \_\          |______/_/\_\\__|_|  \__,_|  \____/| .__/ \__|_|\___/|_| |_|___/
												                                            | |                          
												                                            |_|  

########################################################################################################################################

Author:			Gribbleshnibit8

Version:		1.1

Download:		http://newvegas.nexusmods.com/mods/47285

########################################################################################################################################

The following mods/utilities are required for Project Nevada:

* The Fallout: New Vegas Script Extender (NVSE)
	http://nvse.silverlock.org/

* The Fallout Mod Manager (FOMM) is HIGHLY recommended for properly installing and setting up Project Nevada.
	http://www.newvegasnexus.com/downloads/file.php?id=36901
	
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

	1. Core
		a) Gameplay Features
		b) Immersion Features
		c) Miscellaneous Features
		d) Default hotkeys
		e) Item changes
	
	2. Cyberware
		a) Implant list
		b) Implant locations
		c) Surgery services
		
	3. Equipment
		a) Guns
		b) Energy Weapons
		c) Melee Weapons
		d) Explosives
		e) Armor/Apparel
		
	4. Rebalance
		a) Character options
		b) Damage + Combat options
		c) Stealth + Movement options
		d) Miscellaneous options
		e) Loot rarity options
		f) Food changes
		g) Alternative repair system
		
		

########################################################################################################################################
# PART I ###############################################################################################################################
########################################################################################################################################



========================================================================================================================================
 1. Introduction
========================================================================================================================================

Project Nevada - Extra Options is a mod that adds access to some of the 'behind the scenes' variables in Project Nevada. These variables control things such as how much energy the Vision Modes consume and how quickly Action Points will regenerate while using implants.

All options have been balanced, no amazing super speed or never ending Bullet Time.

It also adds changes a few things, useful to modders, by allowing Eyeglass slot items to carry Vision Modes, with more features to come.


========================================================================================================================================
 2. Changelog
========================================================================================================================================

------------------------------------------------------------
1.2:

[Extra Options]
- Explosive Entry settings now function.
- Sorter now will check the GRA vendor cell on game load.
- New sorter defaults added. The system should now correctly label many more items before you see them.
- Presets implemented.
- Unfound Loot implemented.
- Removed changes to the player util script that broke some instances of vision modes on headgear.
- Charge! Perk now shows up in the level up screen.

[Cyberware]
- Inital release.
- New Challenges related to implants. Earn implant slot perks by finding implants.
- Custom texture on all implant boxes.
- Added HFP and EMP implants to both holdout lists.
- Change how much time passes after surgery.
- Change how much implant surgery costs.

[Rebalance]
- Initial release.
- T.A.G. skill bonus options.
- Combat XP configuration.
- Location discovery XP configuration.
- Speech challenge XP configuration.
- Hacking and lockpick XP configuration.
- Vendor and world respawn configuration.
- Full loot rarity options.
- Enable/disable fast travel.
- Barter options.

[All DLC]
- Initial release.
- Fully merged all DLC files. Requires all optional Project Nevada modules.
- Added Scorched Sierra Power Helmet.
- Added sorter containers to handle all DLC items.
- Fixed Remote Satchel Charge giving back regular Satchel Charge.
- Added recipe to convert remote mines back to regular mines.
- Fixed Implant GRX not working correctly if the player is not using Bullet Time but IS using Cyberware.
- Loot rarity in DLC locations.

------------------------------------------------------------
1.1:

[Extra Options]
- Explosive Entry: Range Default button correctly resets to 150 instead of 300.

------------------------------------------------------------
1.0:

[Extra Options]
- Initial release.


========================================================================================================================================
 3. Installation
========================================================================================================================================

We really recommend using the Fallout Mod Manager to install Project Nevada!
It will automatically copy the right files and take care of any conflicts with already installed mods.
So before you can get started, you have to choose whether you want to do the FOMM installation (recommended) or a manual installation.

Remember: The Core module is required in any case! If you don't like a specific feature, you can disable it in-game.

------------------------------------------------------------
 a) Installation with FOMM
------------------------------------------------------------

1.	Start FOMM and click on Package Manager.

2.	In the top-right button menu, click on Add FOMod and select the downloaded archive file.

3.	Project Nevada will now appear in the list. Select it and click Activate.

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

In case you are using any mod that modifies the interface:
3.	Locate the Data/optional/ folder. In there, copy the contents of following directory your Data/ folder,
	depending on which interface mod you are using:
		* Darn UI, if you're using DarNified UI.
		* MTUI, if you're using MTUI.
		* Remember, if you're using the default interface you can just skip this step.

4.	In the New Vegas Launcher, click on Data Files and select the plugins you want.

5.	Done!


========================================================================================================================================
 4. Troubleshooting
========================================================================================================================================

------------------------------------------------------------
Problem: I'm having issues when using Project Nevada and other interface mods.

Solution: Gopher made a series of videos tutorials, describing how to install Project Nevada together with several UI mods.
	They also cover installation of NVSE, usage of FOMM and ways of recovering from installation errors. So if you need more detailed
	installation instructions, check out those videos!
	
	Modding Fallout NV Part 1: User Interface	-> http://www.youtube.com/watch?v=EGzt6rF7MYA
	Modding Fallout NV Part 2: Project Nevada	-> http://www.youtube.com/watch?v=DdfJME1nhGA
	( ... on-going series!)

------------------------------------------------------------
Problem: My game crashes right after starting it!

Solution: Yes, that's pretty annoying! There are basically two things that can cause this:
	1)	A missing master file (some plugins depend on other plugins, and if they can't find them the game crashes)
		If related to Project Nevada, this happens if you didn't install the Core plugin (which is required by all other modules!)
		Fix it, by installing the Core module as well.
		
	2)	A missing interface file.
		This one is a little trickier. If an interface file is used somewhere that does not exist anymore, the game crashes.
		To fix it, delete the menus/ folder in your Data/ directory, then reinstall any interface-related mods
		(for example MTUI, DarnUI, but also Project Nevada since it uses those interface files as well).
		
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



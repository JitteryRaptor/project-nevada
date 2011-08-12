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

########################################################################################################################################

Team:			snakster, Kai Hohiro, delamer, T3T, Zealotlee, Yukichigai, TheCastle, x-quake, Gopher, Gribbleshnibit8, Mezmorki

Contributors:	Pelinor (Mod Configuration Menu)

Version:		2.3

Download:		http://www.newvegasnexus.com/downloads/file.php?id=40040

########################################################################################################################################

The following mods/utilities are required for Project Nevada:

* The Fallout: New Vegas Script Extender (NVSE)
	http://nvse.silverlock.org/

* The Fallout Mod Manager (FOMM) is HIGHLY recommended for properly installing and setting up Project Nevada.
	http://www.newvegasnexus.com/downloads/file.php?id=36901

	
Since version 2.1 Project Nevada comes with an integrated version of the Mod Configuration Menu (MCM) by Pelinor.
If you want other mods to use the MCM as well, you can install the standalone MCM version, which will always take precedence if active:

* The Mod Configuration Menu (MCM)
	http://www.newvegasnexus.com/downloads/file.php?id=42507
	
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
2.3:

[Core]
- Improved charging scripts and added a charging indicator to the crosshair
- Removed seperate records for chargeable AER14 and Q-35. They now use the vanilla records, which means they can modded as well
- Added optional quick-select hotkeys for Grenade Hotkey categories
- Upgraded bundled MCM to version Beta 11

[Cyberware]
- Added new 'EMP Generator' implant, which grants the ability to fire a targeted electromagnetic pulse
- Added new 'Hyperfrequency Emitter' implant, which can be used to cause an explosive combustion in a targeted area
- Added level 8 perk to give 2 more arm implant slots to the player
- Added level 8 perk to give 2 more leg implant slots to the player
- Fixed recipe descriptions for Razor Nail implants and other typos
- Increased AP regeneration while using implant-powered vision modes from 0% to 50%
- Added surgery dialogue option to Arcade Gannon (if he is recruited as a follower)

[Rebalance]
- Added option to change level cap
- Removed additional food variants so lists, recipes etc use the defaults again (for compatibility reasons)
- Added rads back to raw meat and pre-war food

[Equipment]
- Added 2mm EC ammunition, used by the Auto-Gauss, the Auto-Gauss Pistol and the Gauss Minigun
- Included new weapons in some form lists they were missing from, and various other fixes (thanks to xporc)
- Updated models and textures for Wattz 2000 (thanks to jonnyeah)


------------------------------------------------------------
2.2:

[Core]
- Added Chargeable Weapons feature that adds special fire modes to selected energy weapons
- Added charging mechanics to AER14 Prototype and Q-35 Matter Modulator
- Dynamic Crosshair: Included parts of Antistar's Ammo Spread Effect Fixer so the crosshair shows spread decrease for special ammo
- Explosive Entry: Added additional type checks for destroyed items in containers to avoid destroying important things
- Stealth Field: Fixed bug that allowed multiple Steath Boys to run at the same time
- Scanner: Fixed issues with reloading during scanning

[Cyberware]
- Fixed a bug that could leave the cybernetic surgery menu unresponsive in rare situations
- Added cybernetic surgery service to Doctor Henry in Jacobstown
- Relocated Wired Synapses implant
- Removed Energy Cell drain from implant-powered vision modes, instead AP regeneration is set to 0 while active

[Rebalance]
- Added options for auto aim to the configuration menu
- Added options to modify skill points gained on level up
- Fixed falling damage slider in the configuration menu
- Fixed several tooltips in the configuration menu
- Fixed headshot monitor effect not being stopped for companions in certain situations

[Equipment]
- Added Leather Backpack (Source: http://www.newvegasnexus.com/downloads/file.php?id=39611)
- Added Classic PPK12 Gauss Pistol (Source: http://www.newvegasnexus.com/downloads/file.php?id=42711)
- Added Homemade Rifle, Plasma Rifle and Assault Rifle (Source http://www.newvegasnexus.com/downloads/file.php?id=41099)
- Added unique Multiplas Rifle created by MadCat221 with custom charging mechanics
- Added unique Tri-Beam Laser Rifle created by MadCat221 with custom charging mechanics
- Reworked the charging mechanics for the Plasma Disruptor and made the script compatible with the latest NVSE versions
- Fixed issues with the Railway Rifle that could result in potential CTDs after firing multiple shots
- Fixed 2 mismatched FormIDs introduced by the 1.4 patch
- Fixed wrong attack animation for Wattz Laser Pistol


------------------------------------------------------------
2.1:

[Core]
- Removed old Control Panel and replaced it with an integrated version of MCM
- Removed old configuration menu and replaced it with an MCM-powered menu
- Added Inventory Sorter feature
- Fixed various typos
- Added missing vision effects to Lucky Shades
- Various optimizations by utilizing new NVSE functions
- Explosive Entry: Added trespassing alert when blowing up owned containers/doors
- Explosive Entry: Fixed bug that would make the HUD icon appear for all explosions
- Explosive Entry: Fixed bug where HUD icon would not disappear after reload
- Explosive Entry: Added some missing explosions to the detection lists
- Grenade Hotkey: Fixed an issue where the script would stop working in rare situations
- Stealth Field: Fixed bug where Stealth Boy wouldn't drain field stability when activated for the first time
- Visor Overlays: Decreased extra visor brightness by 50%

[Cyberware]
- Improved implant system so it's now possible for other mods to add their own implants

[Rebalance]
- Removed old configuration menu and replaced it with an MCM-powered menu
- Improved Alternative Repair System
- Fixed hitpoint formula descriptions by adding the missing 100 base HP
- Included Yuki's weapon repair kit fix that would otherwise get overriden
- Fixed issue where headshot monitor could accidently be added to the player
- Removed non-functional "Less Skill Points" option
- Removed more common ammo crafting components to avoid CTDs
- Removed rancid food from dead animal loot
- Removed unintended high radiation increase when wading in water

[Equipment]
- Added missing 3 Shooter to Shotgun Surgeon perk list
- Added missing Pipe Bomb to Demo Expert perk list
- Added 10mm and 10mm SMG to The Professional perk list
- Improved Plasma Disruptor charging mechanics
- Fixed Rail Cannon zooming bug
- Fixed missing meshes for modded Gauss Minigun
- Fixed 5mm SMG loot list count
- Fixed missing dry firing and equip sounds for .44 Pistol and High Roller
- Fixed list error that prevented BoS NPCs from spawning with some of the new weapons
- Fixed visbility condition for Nuka Grenade recipe, added extra safety conditions to all recipes
- Fixed faulty meshes for various weapons (thanks to Antistar)
- Fixed 3 Shooter weapon mod description
- Replaced .44 Pistol flash light mod by proper laser sight


------------------------------------------------------------
2.0:

[Core]
- Enhanced vision modes and Stealth field are no longer tied to Cyberware and can be enabled and disabled in the control panel
- Added Explosive Entry feature that allows the player to break locks with explosives
- Added sound effects for primary needs
- Sprint: Added freely configurable hotkey (no longer restricted to walk/run)
- Grenade Hotkey: Added item categories to support mines and placed explosives
- Grenade Hotkey: Added auto detection of new explosives (once they have been equipped at least once)
- Stealth Field: Added support for stealth girl perk
- Enhanced Vision: Added trap highlighting to EM vision
- Enhanced Vision: Tweaked grain and brightness for clearer sight in all vision modes
- Enhanced Vision: Added vision modes for Reinforced Combat armor (and Mk2 variant)
- Bullet Time: Added perk descriptions
- Scanner: Tweaked threat estimation (Deathclaws are no longer a low threat...)
- Visor Overlays: Changed underlying system to enhance extendability and simplify addition of custom overlay textures

[Cyberware]
- Added level 14 perk to give 2 more torso implant slots to the player
- Added level 14 perk to give 2 more head implant slots to the player
- Added new implant to enable slower bullet time
- Added a short quest that's started when the player picks up the first implant and completed once the player opens the surgery panel
- Added new head implant that grants slower bullet time
- Added restoration of original implant perks if Cyberware is disabled
- Fixed implant placement in Vault 22 so it still can be obtained after the respective quest

[Rebalance]
- Initial release

[Equipment]
- Initial release


------------------------------------------------------------
1.0:

[Core]
- Initial release

[Cyberware]
- Initial release


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


========================================================================================================================================
 5. Credits & Acknowledgements
========================================================================================================================================

Pelinor:	Included Mod Configuration Menu

Antistar:	Fixed weapon meshes
			Ammo spread effect lists
		  
MadCat221:	Q-41 Prototype (Unique MultiPlas), including backstory
			AER18 Prototype (Unique Tri-Beam Laser), including backstory
			Plasma rifle equip/unequip sounds from Plasma Rifles Awesomefied (http://www.newvegasnexus.com/downloads/file.php?id=35678)
			Valueable feedback and bug reports

pintocat:	Inventory sorting scheme

lespaul678:	Sprint exhaustion sounds (male)

Gopher:		Heat vision effects

Max Tael:	MTUI compatibility files

DarN:		DarNified UI compatibility files

Ugluxy:		Textures for the visor damage effects

Crawlius:	Weapon charging sound effects
			Unstable explosion sound effects

joefoxx082:	Fixed Attack3 and Attack4 IS (updated by jonnyeah) animations
			
LORD DARIUS and Jtrainz: Ironsight'ed Fallout 3 Weapons (http://www.newvegasnexus.com/downloads/file.php?id=36571)

???:		Charging warning sound effect from www.soundfx-free.com/wrapper/8.html


European Battle Rifle
	Source: Albrecht and Vashts FN FAL Rifle (http://www.newvegasnexus.com/downloads/file.php?id=37553), by Vashts1985 and LT Albrecht
	Original model: Pete
	Original texture: Pete
	
Liberator Rifle
	Source: Albrecht and Vashts FN FAL Rifle (http://www.newvegasnexus.com/downloads/file.php?id=37553), by Vashts1985 and LT Albrecht
	Original model: Pete
	Original texture: Pete
	
.44 Pistol
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002), by Linerunner and War1982
	Original source: Desert Eagle XIX (http://www.newvegasnexus.com/downloads/file.php?id=37035), by DreadWolf
	Original Desert Eagle model: Vashts1985
	Original Desert Eagle Textures (Silver and engraved): Twinkie Masta
	Original Desert Eagle Textures (black): el maestro de graffiti
	Tactical Light model: SureShot
	Tactical Light Texture: Pete
	Sound effects: DarkFireGaming
	
High Roller
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002), by Linerunner and War1982
	Original source: Desert Eagle XIX (http://www.newvegasnexus.com/downloads/file.php?id=37035), by DreadWolf
	Original Desert Eagle model: Vashts1985
	Original Desert Eagle Textures (Silver and engraved): Twinkie Masta
	Original Desert Eagle Textures (black): el maestro de graffiti
	Tactical Light model: SureShot
	Tactical Light Texture: Pete
	Sound effects: DarkFireGaming
	Retexture: Zealotlee
	
Auto-Gauss
	Source: Classic M72 Gauss Rifle (http://newvegasnexus.com/downloads/file.php?id=37703), by DaiShiSUN
	
Auto-Gauss Pistol
	Source: Classic PPK12 Gauss Pistol (http://newvegasnexus.com/downloads/file.php?id=42711), by DaiShiSUN
	
Cryo Revolver
	Source: M-2081 Pistol (http://newvegasnexus.com/downloads/file.php?id=40174), by Omegared99
	Explosion sound effect: mateomateo002 and Nubblecakes
	
Gauss Minigun
	Source: Classic MEC Gauss Minigun (http://newvegasnexus.com/downloads/file.php?id=36056), by DaiShiSUN
	
Tesla Rifle Prototype
	Source: Liberty Rifle (http://fallout3nexus.com/downloads/file.php?id=1901), by Kikaimegami
	Scope reticle: Pelinor
	
Flamer Pistol
	Source: Classic Flamer Pistol (http://www.newvegasnexus.com/downloads/file.php?id=35752), by DaiShiSUN
	
Wattz Laser Pistol
	Source: FOOK - New Vegas (http://www.newvegasnexus.com/downloads/file.php?id=34684)
	Original model: joefoxx082
	Original texture: joefoxx082
	Enhanced textures, animated glows and improvements: Jonnyeah

Wattz Laser Rifle
	Source: FOOK - New Vegas (http://www.newvegasnexus.com/downloads/file.php?id=34684)
	Original model: joefoxx082
	Original texture: joefoxx082
	Enhanced textures, animated glows and improvements: Jonnyeah

Plasma Disruptor
	Source: Plasma Weapons Redesign Rebalance (http://www.fallout3nexus.com/downloads/file.php?id=8983), by Chai
	Sound effects: Crawlius
	
Plasma Repeater
	Source: Plasma Weapons Redesign Rebalance (http://www.fallout3nexus.com/downloads/file.php?id=8983), by Chai
	
Crowbar
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002), by Linerunner and War1982
	Original source: Crowbar (http://www.fallout3nexus.com/downloads/file.php?id=1480), by Frostbitex460
	Original model/textures: Quad	
	
Homemade Assault Rifle, Homemade Plasma Rifle, Homemade Rifle
	Source: Plasma Weapons Redesign Rebalance (http://www.newvegasnexus.com/downloads/file.php?id=41099), by Eddur

Rising Sun
	Source: Laser Katana (http://www.newvegasnexus.com/downloads/file.php?id=41053), by Shogo
	
Molotov Cocktail
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002), by Linerunner and War1982

Dynamite Charge
	Source: Pipe Rifle And Other Junk Weapons (http://www.newvegasnexus.com/downloads/file.php?id=39438), djabend
	
Advanced Recon Armor
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683), by Gopher

Advanced Recon Helm
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683), by Gopher

Armored Duster
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683), by Gopher

Death Walker Duster
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683), by Gopher

Ranger Recon Armor
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683), by Gopher

Ranger Recon Helm
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683), by Gopher

T57-C Power Armor
	Source: Air Force Power Armor T-57c (http://www.newvegasnexus.com/downloads/file.php?id=37261), by AnOneTwo

Vault-Tec Power Armor
	Source: VaultTec Power Armor (http://www.newvegasnexus.com/downloads/file.php?id=41279), by AnOneTwo

Leather Backpack
	Source: Leather Backpack (http://www.newvegasnexus.com/downloads/file.php?id=39611), by d_ivanov


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
 1. Core
========================================================================================================================================

The Core module is the foundation of Project Nevada, and as such required by all other modules.

It adds the gameplay features found in popular first-person-shooter games that were missing in New Vegas. Some of those features are
improved versions of already well-known Fallout 3 mods, like the Grenade Hotkey, Bullet Time or Sprint. All of them are rewritten
from the ground up, with exciting new features like the support for several VATS perks in Bullet Time and support for throwing weapons
with the grenade hotkey. Others are brand new, like the Dynamic Crosshair that changes it size according to the current weapon spread.
Each of those features can be individually enabled or disabled in-game. They are fully script-based to play along well with other mods.

To allow customization, the Core module implements a Control Panel. Other mods may extend the Control Panel without conflict and make
use of the provided methods for streamlined hotkey assignment.

Since the Core module avoids conflicting changes, players are free run it alongside any other mods, including their favorite overhaul.

------------------------------------------------------------
 a) Gameplay Features
------------------------------------------------------------

* Dynamic Crosshair
	This feature causes the crosshair to expand and contract dynamically based on the player's current gun spread. The formula we used
	is described here: http://forums.bethsoft.com/index.php?/topic/1142921-in-depth-explanation-of-spreadaccuracy/
	A side feature is the introduction of recoil, which reduces accuracy when firing shots in rapid succession unless the player is in
	a stable position (crouching and not moving for example).

* Bullet Time
	A classic feature that doesn't need much introduction - press a hotkey to slow down time, at the cost of Action Points.
	The following perks are supported:
		Math Wrath: Reduced AP costs
		Grim Reaper's Sprint: Regain AP for BT kills
		Commando: Improved accuracy with two-handed weapons
		Gunslinger: Improved accuracy with one-handed weapons
		
* Sprint
	Yet another classic - as the name suggests, Sprint allows you to increase your speed until your action points are used up.
	When bouncing into an opponent you may knock him down if your Strength is overpowering his.
	The following perks improve tackling:
		Super Slam: Increased tackle force
		Unstoppable Force: Tackle doesn't interrupt sprint.

* Grenade Hotkey
	Press a hotkey to quickly equip and prepare an explosive, then release to throw it. Another hotkey is used to cycle throw the
	different throwables in the players inventory. Besides mentioned explosives, thrown weapons are supported as well.

* Variable Zoom for scoped weapons
	All scoped weapons get multiple zooming steps. This works for mod-added weapons as well. The zooming number and
	magnification of those additional zooming steps is based on range of the weapon, so it will not turn a pistol into a sniper rifle.
	Selected weapons have a digital zoom (Gauss, Scoped Laser Rifle).

* Slower Backpedaling
	When moving backwards, the player's speed is reduced based on his/her agility.
	
* Enhanced Stealth Field
	The stealth field of armors or Stealth Boys can now be toggled on and off by hotkey. To balance this, the field can only stay
	stable for a few seconds. The current stability is displayed in the HUD.

* Enhanced Vision Modes
	Power Armor helmets and other high-tech gear now enable enhanced vision modes like Night Vision, Heat Vision and EM Vision.
	If there's no Power Armor equipped as a power source, energy cells are required while these modes are active.
	
* Chargeable Weapons
	Selected unique weapons can be charged to enable powerful special attack modes.
	By default, these weapons are the AER14 Laser Rifle and the Q-35 Plasma Rifle, with the Equipment module adding even more of them.
		
------------------------------------------------------------
 b) Immersion Features
------------------------------------------------------------

* First-person Visor Overlays for helmets
	Helmets and other headgear now get immersive first-person overlays and vision effects. Based on the item condition, cracks and
	scratches will show up in the wearers vision.

* Health Visuals
	With decreasing health, the player's vision gets weak and blurry, creating an immersive feedback mechanism for you current health.
	
* Immersive Primary Needs
	As hunger, thirst or sleep depriviation increase, the player is notified by periodic sound effects. These effects kick in shortly
	before the first penalties occur, so the player is given a chance to eat, drink or sleep in time.

------------------------------------------------------------
 c) Miscellaneous Features
------------------------------------------------------------

* Explosive Entry
	This feature makes it possible to burst open locked containers and doors with explosives. It uses no special interface, just
	detonate something close enough to a lock and you may break it.
	
* Inventory Sorter
	To keep your inventory managable, even when carrying lots of items, the inventory sorter prefixes items based on categories.
	
* MCM-powered Configuration Menu
	The Mod Configuration Menu is accessible directly from the pause menu. In there, every Project Nevada Core feature can be
	enabled or disabled at runtime.

------------------------------------------------------------
 d) Default hotkeys
------------------------------------------------------------

* Bullet Time (C)
* Stealth Field (X)
* Sprint (Run/Walk)
* Throw Grenade (G)
* Select Grenade (H)
* Control Panel (Hold P)
* Zoom In (Wheel Up)
* Zoom Out (Wheel Down)

------------------------------------------------------------
 e) Item changes
------------------------------------------------------------

* Night vision
	Enclave PA Helmet
	Tesla Helmet
	Gannon Tesla Helmet
	Remnants Tesla Helmet
	T45d PA Helmet
	T51b PA Helmet
	Ranger Combat Helmet
	
* Heat vision
	Enclave PA Helmet
	Tesla Helmet
	Ranger Combat Helmet
	
* EM vision
	Gannon Tesla Helmet
	Remnants Tesla Helmet
	T51b PA Helmet

* Stealth field
	Chinese Stealth Armor

* Stealth Boy field is now controllable (Hotkey) and the status is displayed in the HUD	
	
	
========================================================================================================================================
 2. Cyberware
========================================================================================================================================

Even though humanity nuked itself back into the Stone Age, you don't have to fight with sticks and stones. Some of man's most advanced
technological creations have been preserved - and the Cyberware module gives you the chance to obtain them!

Practically this means new features are associated with cybernetic implants and high-tech equipment. Examples include enhanced vision
modes for power armor helmets and bionic legs allowing you to charge towards your enemies with super-human speed.

While for equipment existing items are used, the cybernetic implants come with a custom interface to attach and manage them. Unique
implants that grant powerful abilities are placed all over the wasteland in rewarding locations. Other, less powerful implants can be
obtained from selected vendors, though with the proper Science skill those can be upgraded up to 3 times.

The whole system is balanced by several mechanisms, like limiting the number of implants that can be attached at the same time, or
requiring energy supply for special equipment.

------------------------------------------------------------
a) Implant list
------------------------------------------------------------

[Head Implants]

* AR Scanner: Real-time target analysis
* Bionic Eyes: Enhanced vision modes
* Empathy Synthesizer: Charisma +1
* Logic Co-Processor: Intelligence +1
* Optics Enhancer: Perception +1
* Probability Calculator: Luck +1
* Voice Modulator: Speech +2(3,4,5), Barter +2(3,4,5) (upgradable)
* Wired Synapses: Bullet time slowndown increased by 20%

[Torso Implants]

* Adrenaline Booster: AP regeneration bonus for kills
* Hypertrophy Accelerator: Strength +1
* Monocyte Breeder: Health regeneration
* Nociception Regulator: Endurance +1
* Reflex Booster: Agility +1
* Stealth Nano-Bots: Controllable stealth field
* Sub-Dermal Armor: DT +4
* Synthetic Lungs: 25% lower Sprint AP drain, water breathing

[Arm Implants]

* Kinetic Accelerator: Attack and reload 25% faster during bullet time (effects are additive if used in both arms)
* Nanobionic Weave: Limb regeneration
* Hand Stabilizer: Lockpick +2(3,4,5), Repair +2(3,4,5) (upgradable)
* Motor Memorizer: Guns +2(3,4,5), Energy Weapons +2(3,4,5) (upgradable)
* Neural Datatool: Science +4(6,8,10) (Upgradable)
* Razor Nails: Unarmed critical chance and damage increased by 25% (40,55,70) (upgradable)
* EMP Generator: EM Burst, Capacity 5x, Recharge 1x per hour (effects are additive if used in both arms)
* Hyperfrequence Emitter: Effect: HF Burst, Capacity 5x, Recharge 1x per hour (effects are additive if used in both arms)

[Leg Implants]

* Kinetic Accelerator: Surroundings slowed down by 25% (50%) during sprint (Effects are additive if used in both legs)
* Nanobionic Weave: Limb regeneration
* Tread Damper: Sneak +4(6,8,10) (Upgradeable)
* Weight Absorber: Carry weight +10(20,30,40) (Upgradeable)

Upgradable items can be improved at a workbench. If they are already installed, you have to remove them first.

------------------------------------------------------------
 b) Implant locations (!!!SPOILER WARNING!!!)
------------------------------------------------------------

[World placed]

* AR Scanner
	Helios One Observation Level, on a desk in the room with the brain thing
* Bionic Eyes
	Hidden Valley, Abandoned bunker south (02), behind hard lock on one of the ammo boxes
* Adrenaline Booster
	Cerulean Robotics, on a table in the room with the robots
* Stealth Nano-Bots
	REPCONN Test Site Basement, on a desk in the room where you find the spacesuit
* Synthetic Lungs
	Vault 34 Armory, on a shelf in the room with the plasma crate
* Voice Modulator
	Doc Mitchell's House, on top of a metal box in the room where you wake up first
* Nanobionic Weave
	#1 Vault 19, caves, on the floor next to a shelf in the utility room
	#2 Vault 11, next to the computer in the overseer's room
	#3 Nellis workshop, on a table
	#4 Great Khan Supply Cave #3, on a metal box near the supply item
* Kinetic Accelerator
	#1 REPCONN Headquarters Top Floor, in the room with the destroyed wall on the floor
	#2 REPCONN Research Lab, on a tray in the top lab (where the followers are)
	#3 H&H Tools Factory, inside the opened safe in the office with the keycard
	#4 Vault 22, Keely's lab
* Wired Synapses
	#1 Jacobstown Lodge, Doctor Henry's lab

[For sale at Doctor Usanagi in New Vegas medical clinic]

* Empathy Synthesizer
* Logic Co-Processor
* Optics Enhancer
* Probability Calculator
* Hypertrophy Accelerator
* Monocyte Breeder
* Nociception Regulator
* Reflex Booster
* Sub-Dermal Armor

[For sale in vendor inventory]

* Hand Stabilizer
	Old Lady Gibson
	Julie Farkas
* Motor Memorizer
	Old Lady Gibson
	Julie Farkas
* Neural Datatool
	Old Lady Gibson
	Vendortron
* Razor Nails
	Old Lady Gibson
	Vendortron
* Tread Damper
	Vendortron
	Julie Farkas
* Weight Absorber
	Vendortron
	Julie Farkas

------------------------------------------------------------
 c) Surgery services (!!!SPOILER WARNING!!!)
------------------------------------------------------------

(Name, Location, Requires training?)
Usanagi, New Vegas Medical Clinic, No
Doc Mitchell, Goodsprings, Yes
Linda Schuler, Hidden Valley Bunker, No
Kemp, Camp McCarran, Yes
Julie Farkas, Old Mormon Fort, Yes
Doctor Henry, Jacobstown, No
Arcade Gannon, if he's been recruited as a follower

Training manual locations:
#1 Locked safe in Goodsprings school
#2 On the counter in Old Lady Gibson's garage (Novac)
#3 Besides the terminal in Thomas Hildens Office (Camp McCarran)


========================================================================================================================================
 3. Equipment
========================================================================================================================================

The Equipment module brings new weapons and armor to the Mojave Wasteland.
Source of these items are the many excellent creations produced by the modding community, as well as those created by our own team.

We aim to include only weapons and armor of high quality that fit well within the New Vegas environment and the Fallout universe in
general. To ensure a seamless integration, the new items are carefully balanced and placed at appropriate locations, including vendors
and loot lists.

------------------------------------------------------------
a) Guns
------------------------------------------------------------

[Restored FO3 weapons]
* .22 Revolver
* 10mm Alloy Steel Pistol
* Alloy Steel Assault Rifle
* Alloy Steel Combat Shotgun
* Assault Rifle
* Chinese Assault Rifle
* Chinese Pistol
* Combat Shotgun
* Dart Gun
* Double-Barrel Shotgun
* Dragoon Assault Rifle
* Dragoon Pistol
* Infiltrator
* Lever-Action Rifle
* Railway Rifle
* Replica Repeater

[Custom creations]
* Chinese Sniper Rifle
* 5mm Submachine Gun
* Three Shooter
* The People's Rifle

[Based on community creations]
* European Battle Rifle
* Liberator Rifle
* .44 Pistol
* High Roller
* Homemade Rifle
* Homemade Assault Rifle

------------------------------------------------------------
 b) Energy Weapons
------------------------------------------------------------

[Restored FO3 weapons]
* Alien Atomizer
* Alien Disintegrator
* Captain's Sidearm
* Microwave Emitter

[Custom creations]
* Rail Cannon
* Q-41 Prototype

[Based on community creations]
* Auto-Gauss
* Auto-Gauss Pistol
* Cryo Revolver
* Gauss Minigun
* Tesla Rifle Prototype
* Flamer Pistol
* Wattz Laser Pistol
* Wattz Laser Rifle
* Plasma Disruptor
* Plasma Repeater
* Homemade Plasma Rifle
	
------------------------------------------------------------
 c) Melee Weapons
------------------------------------------------------------

[Unused items]
* Flag Pole

[Restored FO3 weapons]
* Chinese Officer's Sword
* Deathclaw Gauntlet
* Dragoon Sword
* Shock Baton
* Shishkebab

[Based on community creations]
* Crowbar
* Rising Sun

------------------------------------------------------------
 d) Explosives
------------------------------------------------------------

[Restored FO3 items]
* Nuka-Grenade

[Custom creations]
* Remote Frag Mine
* Remote Plasma Mine
* Remote Pulse Mine
* Remote Pipe Bomb
* Cryo Grenade
* Cryo Mine

[Based on community creations]
* Molotov Cocktail
* Dynamite Charge

------------------------------------------------------------
 e) Armor/Apparel
------------------------------------------------------------

[Unused items]
* Surgical Mask
* Armored Vault 21 Jumpsuit

[Restored FO3 items]
* A Suit Named Slickback (Eulogy Jones Suit)
* A Hat Named Slickback (Eulogy Jones Hat)
* Army Jumpsuit
* Desert Recon Armor
* Eyebot helmet
* Outcast Armor
* Medic Power Armor Mk II

[Based on community creations]
* Advanced Recon Armor
* Advanced Recon Helm
* Armored Duster
* Death Walker Duster
* Leather Backpack
* Ranger Recon Armor
* Ranger Recon Helm
* T57-C Power Armor
* Vault-Tec Power Armor
	
	
========================================================================================================================================
 4. Rebalance
========================================================================================================================================

This module aims to bring back the challenge and balance known from Fallout3 Wanderers Edition and includes many tweaks to the FNV
gameplay and difficulty. Combat will be quicker and deadlier and survival much harder. These changes are aimed to be very subtle and
non-intrusive, making the game more challenging without inconveniencing the player.

As usual, the Control Panel allows players to customize most settings according to their personal preferences.

------------------------------------------------------------
 a) Character options
------------------------------------------------------------

* Leveling Speed
	Description:
		Allows to reduce the leveling speed.
	Defaults:
		100% [PN, Vanilla]

* Carry Weight
	Description:
		Allows to change how total Carry Weight is calculated.
	Defaults:
		 25 + 25*STR [PN]
		150 + 10*STR [Vanilla]
		
* Action Points
	Description:
		Allows to change how total Action points are calculated.
	Defaults:
		45 + 6*AGI [PN]
		65 + 3*AGI [Vanilla]

* Perk Selection:
	Description:
		Allows to set the level interval for perk selection.
	Defaults:
		Every two Levels [PN, Vanilla]
		
* Skill Point Modifier:
	Description:
		Allows to adjust the skill points received on level up.
	Defaults:
		0 [PN, Vanilla]
		
* Maximum Level:
	Description:
		Allows to increase the level cap.
	Defaults:
		50 [PN]
		30 [Vanilla] (depending on installed DLCs)

* Throwing Range Multiplier:
	Description:
		Allows you to make the throwing range dependent on your strength.
	Defaults:
		1.0           [Vanilla]
		0.5 + 0.1*STR [PN]

------------------------------------------------------------
 b) Damage + Combat options
------------------------------------------------------------

* Hitpoints
	Description:
		Allows to change how hitpoints for the player and other actors are calculated.
	Defaults:
		Player HP: 100 + 20 * END + 5 * LVL   ,   NPC HP: Base HP + 5 * END + 5 * LVL [Vanilla]
		Player HP: 100 + 10 * END             ,   NPC HP: Base HP + 7 * END			  [PN]

* DT Minimum Damage
	Description:
		Allows to modify the amount of minimum damage received with each shot, even it it was absorbed by DT.
	Defaults:
		20% [Vanilla]
		25% [PN]
		
* Helmet Requirement for Head DT
	Description:
		By default, armor DT protects the full body, even if the head is unprotected.
		If this option is enabled, DT will be bypassed for any headshot to an actor not wearing any head protection with DT > 0.
	Defaults:
		Yes [PN]
		No  [Vanilla]
		
* Radiation Rate
	Description:
		Allows to modify the radiation increase rate.
	Defaults:
		100% [PN]
		150% [Vanilla]

* Safe Falling Distance
	Description:
		Allows to change at which falling height actors start to take damage.
	Defaults:
		400
		600 [Vanilla]
		
* Damage Skill Influence
	Description:
		Allows to reduce the influence of weapon skill on damage. For 20%, someone with skill 0 will still do 80% base damage.
	Defaults:
		20% [PN]
		50% [Vanilla]
		
* Explosion Knockdowns and Sounds
	Description:
		Enables explosion knockdown based on explosion strength and S.P.E.C.I.A.L attributes.
		This also includes an explosion ring effect.
	Defaults:
		Yes [PN]
		 No [Vanilla]
		 
* Limb Damage
	Description:
		Allows to increase the amount of health damage that's transferred to limb damage.
	Defaults:
		75% [PN]
		50% [Vanilla]

* Auto Aim
	Description:
		Allows to tweak parameters for auto aim.
	Defaults:
		Distance 5000, Max Angle 0.1, Screen Area 0.1 [PN]
		Distance 1800, Max Angle 3,   Screen Area 20  [Vanilla]

------------------------------------------------------------
 c) Stealth + Movement options
------------------------------------------------------------

* Sneak Difficulty
	Description:
		Allows to select different sneak profiles. Harder sneaking makes sneaking more difficult, while still keeping the
		original spirit so you can hide in plain sight with a high sneak skill.
		The Experimental profile will make sneaking significantly harder, aiming for a realistic detection.
	Defaults:
		Normal       [Vanilla]
		Harder       [PN]
		
* Experimental Detection AI
	Description:
		Allows to enable scripted search behaviour. Actors will stay alerted much longer, also alerting nearby actors.
		While alerted, they have significantly enhanced long range detection. If they spot the player of a large distance,
		they will move towards him to investigate, making any nearby allies join them.
	Defaults:
		 No [PN, Vanilla]
		 
* Running Speed Multiplier
	Description:
		Allows to reduce the general running speed.
	Options:
		3.65 [PN]
		4.00 [Vanilla]
		
* Holstered Speed Mutliplier
	Description:
		Allows to increase movement speed with a holstered weapon.
	Defaults:
		100% [Vanilla]
		115% [PN]
		
* Crippled Legs Speed
	Description:
		Allows to reduce movement speed with crippled legs.
	Defaults:
		One leg 70% , Two legs 40% [PN]
		One leg 85% , Two legs 75% [Vanilla]
		
------------------------------------------------------------
 d) Loot rarity options
------------------------------------------------------------

* Ammo Spawn Chance
	Description:
		Allows to reduce the chance for ammo to spawn in various locations. Special ammo is not affected.
	Defaults:
		25% [PN]
		75% [Vanilla]

* Food Spawn Chances
	Description:
		Allows to reduce the chance for food (includes drinks as well) to spawn in various locations.
	Defaults:
		37%,  37%, 27%, 17% [PN]
		100%, 75%, 50%, 25% [Vanilla]
		
------------------------------------------------------------
 e) Miscellaneous options
------------------------------------------------------------

* Food Healing
	Description:
		Allows to disable food healing.
	Defaults:
		Yes [Vanilla]
		No  [PN]
		
* Alternative Repair System
	Description:
		Enable an alternative repair system, which is explained in full detail in a seperate section.
	Defaults:
		Yes
		 No [PN, Vanilla]
		 
* Primary Needs Increase Interval and Tweaked Timescale
	Description:
		Allows to increase the hunger, thirst and sleep increase rates.
	Defaults:
		Hunger 25, Thirst 10, Sleep 5,  Timescale 30 [Vanillla]
		Hunger 20, Thirst 10, Sleep 20, Timescale 20 [PN]
		
* Survival Skill and Food Influence Primary Needs Rates
	Description:
		Allows the surivial skill and food quality to influence the hunger, sleep and thirst rates.
		The survival skill reduces the increase speed by up to 50%.
		Eating bad food will make hunger increase faster for a while.
	Defaults:
		Yes [PN]
		 No [Vanilla]

* Show Karma Messages
	Description:
		Allows to hide karma messages.
	Defaults:
		Yes [Vanilla, PN]

* Show Sneak Indicator
	Description:
		Allows to hide the sneak indicator.
	Defaults:
		Yes [Vanilla, PN]

* Death Physics Force
	Description:
		Allows to reduce death physics so they are more realistic.
	Defaults:
		 50% [PN]
		100% [Vanilla]

* Gore Chance
	Description:
		Allows to reduce gore effects so they are less over-the-top.
	Defaults:
		Dismember 30%, Explode 45% [PN]
		Dismember 50%, Explode 75% [Vanilla]

------------------------------------------------------------
 f) Food changes
------------------------------------------------------------

Food is generally classified as Terrible, Bad and Good.
With decreasing quality, the food is less nutritious. If the respective option is enabled, eating bad or terrible food
will temporarily increase the hunger rate. More details can be found here:
https://spreadsheets.google.com/spreadsheet/ccc?key=0AoiEH8ar3jtxdGlzdnVDY3lGUEV5RWhNdXhzRHJBT0E&hl=en_US

------------------------------------------------------------
 g) Alternative repair system
------------------------------------------------------------

The default repair system relies heavily on weapon repair kits, which bypass the repair interface.
It's very easy to repair common weapons to 100%, even with a very low repair skill.

The alternative repair system tries to address those issues. Its two cornerstones are dynamic repair lists, and the
introduction of repair tools. Let's start with those:
- To repair anything two things are required: An item to repair with (like before), and Repair Tools.
- Repair tools are created at a workbench. One set of Wrench, Hammer, Wonderglue and Duct Tape yields 10 charges.
- Crafting of Weapon Repair Kits is disabled, existing Weapon Repair Kits are replaced with at a 1:5 ratio.

This makes repairing harder, as it restricts the number or possible repairs even for very common weapons. Additionally,
there are the dynamic repair lists. Repair lists are no longer fixed to a few items, but are expanded based on the
player's repair skill.

If your Repair Skill is below the required skill for an item, you can only repair it with itself.
Otherwise the list is expanded with items of similar type.

For weapons, the required repair skill is equal to the required weapon skill.
For armor, the required skill depends on the DT value of the item.

The skill exact skill requirements for armor are:
* 0 Repair for Clothing (DT 0)
* 25 Repair for Light Armor (DT < 10)
* 50 Repair for Medium Armor (DT < 20)
* 75 Repair for Heavy Armor (DT >= 20)
* 100 Repair for Power Armor

Repairing works like before, by selecting an item in the Pipboy inventory and pressing R). If no Repair Tools are available,
R) is always greyed out. Otherwise, the current number of Repair Tools will be shown in the top right corner of the repair
dialog (formerly that was where the repair skill was displayed).

The original Jurgy Rigging perk is modified to add additional scrap items to weapon repair lists once you meet the
repair skill requirements.

It's possible to disable the system at runtime in the Control Panel.
########################################################################################################################################
README - Project Nevada
########################################################################################################################################

Team: snakster, Kai Hohiro, delamer, T3T, x-quake, TheCastle, Mezmorki

Current Version: 1.0

------------------------------------------------------------
Part I - General

	1. Introduction

	2. Installation

	3. Troubleshooting

	4. Credits
	
	5. Contact
	
	6. Permissions
	

Part II - Module Details

	1. Core
		a) Features
		b) Hotkeys
	
	2. Cyberware
		a) Item changes
		b) Implant list
		c) Implant locations
		d) Surgery services
		
------------------------------------------------------------



# PART I ###############################################################################################################################



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
 2. Installation
========================================================================================================================================

We really recommend using the Fallout Mod Manager to install Project Nevada!
It will automatically copy the right files and take care of any conflicts with already installed mods.

Before you can get started, you have two make two choices:
1. FOMM installation (recommended) or manual installation
2. FULL PACKAGE (recommended) or just selected modules

* If you're using FOMM, just download the FULL PACKAGE. It has a nice installer that lets you select the modules you want.
* If you want to use all modules and install them manually, grab the FULL PACKAGE as well.
* If you want to do a manual installation for selected modules only, download the separate files.

When downloading selected modules only, remember: The Core module is required in any case! If you don't like a specific feature, you can
disable it in-game.

Once you downloaded the right file(s), you can proceed with the installation.

------------------------------------------------------------
 a) Installation with FOMM
------------------------------------------------------------

1. Start FOMM and click on Package Manager.

In case you downloaded separate modules, repeat these steps for each of them:
2. In the top-right button menu, click on Add FOmod and select the downloaded archive file.
3. The module will now appear in the list. Select it and click Activate.
4. In case you're using the FULL PACKAGE, select the modules you want, then click Install.
5. If you are prompted to overwrite anything, click Yes to All.

5. Done!

OR

------------------------------------------------------------
 b) Manual Installation
------------------------------------------------------------

1. Locate the Data/ folder in your Fallout New Vegas installation directory.
(Typically it's found at Program Files/Steam/SteamApps/common/fallout new vegas/Data/)

In case you downloaded separate modules, repeat this step for each of them:
2. Extract the contents of downloaded archive file to your Data/ folder.

3. Locate the Data/optional/ folder. In there, open the following directory, depending on which interface mod you are using:
* Default UI, if you're not using any interface mod.
* Darn UI, if you're using DarNified UI.
* MTUI, if you're using MTUI.

4. Copy the contents of the directory you just opened to your Data/ folder.

5. In the New Vegas Launcher, click on Data Files and select the plugins you want.

6. Done!


========================================================================================================================================
 3. Troubleshooting
========================================================================================================================================

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
If your problem wasn't covered here, go to http://www.newvegasnexus.com/downloads/file.php?id=39442 and describe your issues in the
"Comments" section. Surely someone will be able to provide assistance.


========================================================================================================================================
 4. Credits
========================================================================================================================================

Ugluxy - Textures for the visor damage effects
lespaul678 - Sprint exhaustion sounds (male)
Gopher - Heat vision effects
Max Tael - MTUI compatibility files
DarN - DarNified UI compatibility files


========================================================================================================================================
 5. Contact
========================================================================================================================================

For contact, send a PM to schlangster at

	http://www.newvegasnexus.com/
		or
	http://forums.bethsoft.com/

	
========================================================================================================================================
 6. Permissions
========================================================================================================================================	

Some assets in Project Nevada belong to other authors.
You will need to seek permission from these authors before you can use their assets.

You may upload Project Nevada to other sites, convert it work with other games, modify anything or release bug fixes and improvements,
and use our assets without permission, but please give proper credit if you do so.



# PART II ##############################################################################################################################



========================================================================================================================================
 1. Core
========================================================================================================================================

The Core module is the foundation of Project Nevada, and as such required by all other modules.

It adds the gameplay features found in popular first-person-shooter games that were yet missing in New Vegas. Some of those features
are improved versions of already well-known Fallout 3 mods, like the Grenade Hotkey, Bullet Time or Sprint. All of them are rewritten
from the ground up, with exciting new features like the support for several VATS perks in Bullet Time and support for throwing weapons
with the grenade hotkey. Others are brand new, like the Dynamic Crosshair that changes it size according to the current weapon spread.
Each of those features can be individually enabled or disabled in-game. They are fully script-based to play along well with other mods.

To allow customization, the Core module implements a Control Panel. Other mods may extend the Control Panel without conflict and make
use of the provided methods for streamlined hotkey assignment.

Since the Core module avoids conflicting changes, players are free run it alongside any other mods, including their favorite overhaul.

------------------------------------------------------------
 a) Features
------------------------------------------------------------

The following features

* Dynamic Crosshair
	This feature causes the crosshair to expand and contract dynamically based on the player's current gun spread. The formula we used
	is described here: http://forums.bethsoft.com/index.php?/topic/1142921-in-depth-explanation-of-spreadaccuracy/
	A side feature is the introduction of recoil, which reduces accuracy when firing shots in rapid succession unless the player is in
	a stable position (crouching and not moving for example).

* Bullet Time
	A classic feature that doesn't need much introduction - press a hotkey to slow down time, at the cost of Action Points.
	The following perks are supported:
		Math Wrath: Reduced AP costs
		Grim Reaper Sprint: Regain AP for BT kills
		Commando: Improved accuracy with two-handed weapons
		Gunslinger: Improved accuracy with one-handed weapons
	
* Sprint
	Yet another classic - as the name suggests, Sprint allows you to increase your speed until your action points are used up.
	When bouncing into an oppononent you may knock him down if you're Strength is overpowering his.
	The following perks improve tackling:
		Super Slam: Increased tackle force
		Unstoppable Force: Tackle doesn't interrupt sprint.

* Grenade Hotkey
	Press a hotkey to quickly equip and prepare an explosive, then release it to throw it. Another hotkey is used to cycle throw the
	different throwables in the players inventory. Besides mentioned explosives, thrown weapons are supported as well.

* Variable Zoom for scoped weapons
	All scoped weapons get multiple zooming steps. This works for mod-added weapons as well. The zooming number and
	magnification of those additional zooming steps is based on range of the weapon, so it will not turn a pistol into a sniper rifle.
	Selected weapons have a digital zoom (Gauss, Scoped Laser Rifle).

* Slower Backpedaling
	When moving backwards, the player's speed is reduced based on his/her agility.

* First-person Visor Overlays for helmets

* Immersive Health Visuals

* Control Panel
	The control panel is accessible from the pause menu.
	The button is in the lower right corner and only visible when coming directly from the game instead of another menu!
	It's technically possible for other mods to add entries to the top-level menu.

------------------------------------------------------------
 b) Hotkeys
------------------------------------------------------------

* Bullet Time (C)
* Stealth Field (X)
* Sprint (Run/Walk)
* Throw Grenade (G)
* Select Grenade (H)
* Control Panel (Hold P)
* Zoom In (MWheel Up)
* Zoom Out (MWheel Down)	
	
	
========================================================================================================================================
 2. Cyberware
========================================================================================================================================

Even though humanity nuked itself back into the Stone Age, you don't have to fight with sticks and stones. Some of mans most advanced
technological creations have been preserved - and the Cyberware module gives you the chance to obtain them!

Practically this means new features are associated with cybernetic implants and high-tech equipment. Examples include enhanced vision
modes for power armor helmets and bionic legs allowing you to charge towards your enemies with super-human speed.

While for equipment existing items are used, the cybernetic implants come with a custom interface to attach and manage them. Unique
implants that grant powerful abilities are placed all over the wasteland in rewarding locations. Other, less powerful implants can be
obtained from selected vendors, though with the proper Science skill those can be upgraded up to 3 times.

The whole system is balanced by several mechanisms, like limiting the number of implants that can be attached at the same time, or
requiring energy supply for special equipment.

------------------------------------------------------------
 a) Item changes
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

* Stealth Boy field is now controllable (Hotkey) and status is displayed in the HUD

------------------------------------------------------------
 b) Implant list
------------------------------------------------------------

[Head Implants]

* AR Scanner: Real-time target analysis
* Bionic Eyes: Enhanced vision modes
* Empathy Synthesizer: Charisma +1
* Logic Co-Processor: Intelligence +1
* Optics Enhancer: Perception +1
* Probability Calculator: Luck +1
* Voice Modulator: Speech +2(3,4,5), Barter +2(3,4,5) (upgradable)

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

[Leg Implants]

* Kinetic Accelerator: Surroundings slowed down by 25% (50%) during sprint (Effects are additive if used in both legs)
* Nanobionic Weave: Limb regeneration
* Tread Damper: Sneak +4(6,8,10)
* Weight Absorber: Carry weight +10(20,30,40)

------------------------------------------------------------
 c) Implant locations (!!!SPOILER WARNING!!!)
------------------------------------------------------------

(!!!SPOILER WARNING!!!)

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
	Doc Mitchells House, on top of a metal box in the room where you wake up first
* Nanobionic Weave
	#1 Vault 19, caves, on the floor next to a shelf in the utility room
	#2 Vault 11, next to the computer in the overseer's room
	#3 Nellis workshop, on a table
	#4 Great Khan Supply Cave #3, on a metal box near the supply item
* Kinetic Accelerator
	#1 REPCONN Headquarters Top Floor, in the room with the destroyed wall on the floor
	#2 REPCONN Research Lab, on a tray in the top lab (where the followers are)
	#3 H&H Tools Factory, inside the opened safe in the office with the keycard
	#4 Vault 22, pest control in the highest room near the door

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
 d) Surgery services (!!!SPOILER WARNING!!!)
------------------------------------------------------------

(Name, Location, Requires training?)
Usanagi, New Vegas Medical Clinic, No
Doc Mitchell, Goodsprings, Yes
Linda Schuler, Hidden Valley Bunker, No
Kemp, Camp McCarran, Yes
Julie Farkas, Old Mormon Fort, Yes

Training manual locations:
#1 Locked safe in Goodsprings school
#2 On the counter in Old Lady Gibson's garage (Novac)
#3 Besides the terminal in Thomas Hildens Office (Camp McCarran)



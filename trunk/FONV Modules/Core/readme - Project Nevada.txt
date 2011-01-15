========================================================================================================================================
README - Project Nevada
========================================================================================================================================

Team: snakster, Kai Hohiro, delamer, T3T, x-quake, TheCastle, Mezmorki

Current Version: 1.0

------------------------------------------------------------
1. Introduction

2. Credits

3. Installation

4. Troubleshooting

5. Core Features

6. Cyberware Features
	a) Item changes
	b) Implant list
	c) Implant locations
	d) Surgery services
------------------------------------------------------------

========================================================================================================================================
 1. Introduction
========================================================================================================================================

Besides some general information, this document contains further details on the changes done by the different modules

Section 3 contains the generic installation guide (it's the same for all modules and download packages).

The most common problems (and their solutions) are listed in Section 4.

Section 6 describes the Cyberware changes and additions. Read it, you're having trouble finding a certain implant, or if you are just
curious. However, DON'T read it, if you want to search for the implants yourself. Most of them are placed so that you stumble upon them
naturally when playing the game.

========================================================================================================================================
 2. Credits
========================================================================================================================================

Ugluxy - Textures for the visor damage effects
lespaul678 - Sprint exhaustion sounds (male)
Gopher - Heat vision effects
Max Tael - MTUI compatibility patches
DarN - DarNified UI compatibility patches

========================================================================================================================================
 3. Installation
========================================================================================================================================

We really recommend using the Fallout Mod Manager to install Project Nevada!
It will automatically copy the right files and take care of any conflicts with already installed mods.

Before you can get started, you have two make two choices:
1. FOMM installation (recommended) or manual installation
2. FULL PACKAGE (recommened) or just selected modules

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
 4. Troubleshooting
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
Problem: After I load a savegame, a message box tells me that Project Nevada wasn't properly installed.

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
 5. Core Features
========================================================================================================================================

------------------------------------------------------------
 a) Gameplay
------------------------------------------------------------

[Gameplay]

* Dynamic Crosshair
* Sprint
* Grenade Hotkey 
* Variable Zoom for scoped weapons 
* Slower Backpedaling 
* First-person Visor Overlays for helmets
* Immersive Health Visuals

[Infrastructure]

* Extensible Control Panel 
* Streamlined Hotkey Management

========================================================================================================================================
 6. Cyberware Features
========================================================================================================================================

------------------------------------------------------------
 a) Item changes
------------------------------------------------------------

[Vision modes]

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
	
[Stealth Field]

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
* Voice Modulator: Speech +2(3,4,5), Barter +2(3,4,5)

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

* Kinetic Accelerator: Attack and reload 25% (50%) faster during bullet time
* Nanobionic Weave: Limb regeneration
* Hand Stabilizer: Lockpick +2(3,4,5), Repair +2(3,4,5)
* Motor Memorizer: Guns +2(3,4,5), Energy Weapons +2(3,4,5)
* Neural Datatool: Science +4(6,8,10)
* Razor Nails: Unarmed critical chance and damage increased by 25% (40,55,70)

[Leg Implants]

* Kinetic Accelerator: Surroundings slowed down by 25% (50%) during sprint
* Nanobionic Weave: Limb regeneration
* Tread Damper: Sneak +4(6,8,10)
* Weight Absorber: Carry weight +10(20,30,40)

------------------------------------------------------------
 c) Implant locations
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
 d) Surgery services
------------------------------------------------------------

Name			Location				Requires training?
 
Usanagi			New Vegas Medical Clinic		No
Doc Mitchell		Goodsprings				Yes
Linda Schuler		Hidden Valley Bunker			No
Kemp			Camp McCarran				Yes
Julie Farkas		Old Mormon Fort				Yes

Training manual locations:
#1 Locked safe in Goodsprings school
#2 On the counter in Old Lady Gibson's garage (Novac)
#3 Besides the terminal in Thomas Hildens Office (Camp McCarran)

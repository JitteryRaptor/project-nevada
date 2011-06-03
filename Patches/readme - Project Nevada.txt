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
	#1 Lake Mead, on the ground in a flooded cave

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
* Saturday Night Special

[Custom creations]
* Chinese Sniper Rifle
* 5mm Submachine Gun
* Three Shooter
* The People's Rifle

[Based on community creations]
* European Battle Rifle
	Original authors: Vashts1985 and LT Albrecht
	Source: Albrecht and Vashts FN FAL Rifle (http://www.newvegasnexus.com/downloads/file.php?id=37553)
* Liberator Rifle
	Original authors: Vashts1985 and LT Albrecht
	Source: Albrecht and Vashts FN FAL Rifle (http://www.newvegasnexus.com/downloads/file.php?id=37553)
* .44 Pistol
	Original authors: Linerunner and War1982
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)	
* High Roller
	Original authors: Linerunner and War1982
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)

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

[Based on community creations]
* Auto-Gauss
	Original author: DaiShiSUN
	Source: Classic M72 Gauss Rifle (http://newvegasnexus.com/downloads/file.php?id=37703)
* Cryo Revolver
	Original author: Omegared99
	Source: M-2081 Pistol (http://newvegasnexus.com/downloads/file.php?id=40174)
* Gauss Minigun
	Original author: DaiShiSUN
	Source: Classic MEC Gauss Minigun (http://newvegasnexus.com/downloads/file.php?id=36056)
* Tesla Rifle Prototype
	Original author: Kikaimegami
	Source: Liberty Rifle (http://fallout3nexus.com/downloads/file.php?id=1901)
* Flamer Pistol
	Original authors: Linerunner and War1982	
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)	
* Wattz Laser Pistol
	Original authors: Linerunner and War1982
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)	
* Wattz Laser Rifle
	Original authors: Linerunner and War1982
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)	
* Plasma Disruptor
	Original author: Chai
	Source: Plasma Weapons Redesign Rebalance (http://www.fallout3nexus.com/downloads/file.php?id=8983)	
* Plasma Repeater
	Original author: Chai
	Source: Plasma Weapons Redesign Rebalance (http://www.fallout3nexus.com/downloads/file.php?id=8983)
	
------------------------------------------------------------
 c) Melee Weapons
------------------------------------------------------------

[Unused items]
* Flag Pole

[Restored FO3 weapons]
* Auto Axe
* Chinese Officer's Sword
* Deathclaw Gauntlet
* Dragoon Sword
* Shock Baton
* Shishkebab

[Based on community creations]
* Crowbar
	Original authors: Linerunner and War1982
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)
* Rising Sun
	Original author: Shogo
	Source: Laser Katana (http://www.newvegasnexus.com/downloads/file.php?id=41053)

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
	Original authors: Linerunner and War1982
	Source: Classic Fallout Weapons - New Vegas (http://newvegasnexus.com/downloads/file.php?id=37002)
* Dynamite Charge
	Original author: djabend
	Source: Pipe Rifle And Other Junk Weapons (http://www.newvegasnexus.com/downloads/file.php?id=39438)

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
	Original author: Gopher
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683)
* Advanced Recon Helm
	Original author: Gopher
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683)
* Armored Duster
	Original author: Gopher
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683)
* Death Walker Duster
	Original author: Gopher
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683)
* Ranger Recon Armor
	Original author: Gopher
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683)
* Ranger Recon Helm
	Original author: Gopher
	Source: Advanced Recon Stealth Armor (http://www.newvegasnexus.com/downloads/file.php?id=34683)
* T57-C Power Armor
	Original author: AnOneTwo
	Source: Air Force Power Armor T-57c (http://www.newvegasnexus.com/downloads/file.php?id=37261)
* Vault-Tec Power Armor
	Original author: AnOneTwo
	Source: VaultTec Power Armor (http://www.newvegasnexus.com/downloads/file.php?id=41279)
	
	
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
		Allows to set the leveling speed to roughly ~50% by modifying the XP rewards for killed enemies.
	Options:
		<50%
		100% [PN, Vanilla]
	
* Skill Points per Level
	Description:
		Allows to reduce the amount of skill points gained per level.
	Options:
		 6 + INT
		11 + INT [PN, Vanilla]

* Carry Weight
	Description:
		Allows to use an alternative carry weight formula that's mainly based on STR.
	Options:
		 25 + 25*STR [PN]
		150 + 10*STR [Vanilla]
		
* Action Points
	Description:
		Allows to use an alternative action point formula that's mainly based on AGI.
	Options:
		45 + 6*AGI [PN]
		65 + 3*AGI [Vanilla]

* Perk Selection:
	Description:
		Allows to pick one perk at each level.
	Options:
		Every two Levels [PN, Vanilla]
		Every Level

* Throwing Range Multiplier:
	Description:
		Allows you to make the throwing range dependent on your strength.
	Options:
		1.0           [Vanilla]
		0.5 + 0.1*STR [PN]

------------------------------------------------------------
 b) Damage + Combat options
------------------------------------------------------------

* Hitpoints
	Description:
		Allows to reduce hitpoints of all actors and creatures to increase the relative damage and make combat much deadlier.
	Options:
		Player HP: 20 * END + 5 * LVL   ,   NPC HP: 5 * END + 5 * LVL [Vanilla]
		Player HP: 10 * END             ,   NPC HP: 7 * END
		Player HP:  7 * END             ,   NPC HP: 7 * END

* DT Bleedthrough
	Description:
		Allows to modify the amount of minimum damage received with each shot, even it it was absorbed by DT.
	Options:
		 1%
		10%
		20% [Vanilla]
		25% [PN]
		50%
		
* Radiation Rate
	Description:
		Allows to modify the amount of minimum damage received with each shot, even it it was absorbed by DT.
	Options:
		100% [PN]
		150% [Vanilla]

* Safe Falling Distance
	Description:
		Allows to change at which falling height actors start to take damage.
	Options:
		400
		600 [Vanilla]
		
* Damage Skill Influence
	Description:
		Allows to reduce the influence of weapon skill on damage. For 20%, someone with skill 0 will still do 80% base damage.
	Options:
		20% [PN]
		50% [Vanilla]
		
* Explosion Knockdowns
	Description:
		Enables explosion knockdown based on explosion strength and S.P.E.C.I.A.L attributes.
		This also includes an explosion ring effect.
	Options:
		Yes [PN]
		 No [Vanilla]
		 
* Limb Damage
	Description:
		Allows to increase the amount of health damage that's transferred to limb damage.
	Options:
		75% [PN]
		50% [Vanilla]
		
* DT for Headshots
	Description:
		By default, armor DT protects the full body, even if the head is unprotected.
		If DT for headshots is requires wearing a helmet, any headshot to an actor not wearing any head protection with DT > 0
		will do full damage, bypassing the body DT.
	Options:
		Only with Helmet [PN]
		Always           [Vanilla]

------------------------------------------------------------
 c) Stealth + Movement options
------------------------------------------------------------

* Sneak Difficulty
	Description:
		Allows to select different sneak profiles. Harder sneaking makes sneaking more difficult, while still keeping the
		original spirit so you can hide in plain sight with a high sneak skill.
		The Experimental profile will make sneaking significantly harder, aiming for a realistic detection.
	Options:
		Normal       [Vanilla]
		Harder       [PN]
		Experimental
		
* Experimental Detection AI
	Description:
		Allows to enable scripted search behaviour. Actors will stay alerted much longer, also alerting nearby actors.
		While alerted, they have significantly enhanced long range detection. If they spot the player of a large distance,
		they will move towards him to investigate, making any nearby allies join them.
	Options:
		Yes
		 No [PN, Vanilla]
		 
* Running Speed Multiplier
	Description:
		Allows to reduce the general running speed.
	Options:
		3.65 [PN]
		4.00 [Vanilla]
		
* Holstered Speed
		Allows to increase movement speed with a holstered weapon.
	Description:
	Options:
		100% [Vanilla]
		115% [PN]
		
* Crippled Legs Speed
	Description:
		Allows to reduce movement speed with crippled legs.
	Options:
		One leg 70% , Two legs 40% [PN]
		One leg 85% , Two legs 75% [Vanilla]
		
------------------------------------------------------------
 d) Miscellaneous options
------------------------------------------------------------

* Food Healing
	Description:
		Allows to disable food healing.
	Options:
		Yes [Vanilla]
		No  [PN]
		
* Alternative Repair System
	Description:
		Enable an alternative repair system, which is explained in full detail in a seperate section.
	Options:
		Yes
		 No [PN, Vanilla]
		 
* Primary Needs Increase per Minute
	Description:
		Allows to increase the hunger, thirst and sleep increase rates.
	Options:
		Hunger 2.4, Thirst 6, Sleep 1.2 [Vanillla]
		Hunger 3  , Thirst 6, Sleep 3   [PN]
		
* Survival Skill and Food Influence Primary Needs Rates
	Description:
		Allows the surivial skill and food quality to influence the hunger, sleep and thirst rates.
		The survival skill reduces the increase speed by up to 50%.
		Eating bad food will make hunger increase faster for a while.
	Options:
		Yes [PN]
		 No [Vanilla]

* Show Karma Messages
	Description:
		Allows to hide karma messages.
	Options:
		Yes [Vanilla]
		 No [PN]

* Show Sneak Indicator
		Allows to hide the sneak indicator.
	Description:
	Options:
		Yes [Vanilla]
		 No [PN]

* Death Physics Force
	Description:
		Allows to reduce death physics so they are more realistic.
	Options:
		 50% [PN]
		100% [Vanilla]

* Gore Chance
	Description:
		Allows to reduce gore effects so they are less over-the-top.
	Options:
		Dismember 30%, Explode 45%
		Dismember 50%, Explode 75% [Vanilla]
		
------------------------------------------------------------
 e) Item rarity changes
------------------------------------------------------------

* Rarer Stimpaks

* Rarer high quality food

* Ammo is more common at vendors

* Weapon are mods more common at vendors

* Higher quality foods are more common at vendors

* Craftable bullet components are more common at vendors

------------------------------------------------------------
 f) Food changes
------------------------------------------------------------

For every existing food item, there are now three variations, classified as Terrible, Bad and Good.
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
- Crafting of Weapon Repair Kits is disabled, existing Weapon Repair Kits are replaced with at a 1:10 ratio.

This makes repairing harder, as it restricts the number or possible repairs even for very common weapons. Additionally,
there are the dynamic repair lists. Repair lists are no longer fixed to a few items, but are expanded based on the
player's repair skill.

For weapons:
Skill  0 - 49: Original repair list, usually only contains the weapon itself.
Skill 50 - 74: All weapons of the same type (similiar to Jury Rigging), i.e. all two-handed automatic rifles or all pistols.
Skill 75 - 99: All weapons of the same skill class, i.e. all Guns or all Energy Weapons.
Skill     100: All weapons of the same skill class plus class-specific junk items, like Scrap Metal.

Armors don't use multiple skill ranges, but always allow repairs with armors of the same armor type (light, medium, heavy).

Repairing works like before, by selecting an item in the Pipboy inventory and pressing R). If no Repair Tools are available,
R) is always greyed out. Otherwise, the current number of Repair Tools will be shown in the top right corner of the repair
dialog (formerly that was where the repair skill was displayed).

The original Jurgy Rigging perk is modified to give a 50% chance that no Repair Tool charge is used up on a repair.

It's possible to disable the system at runtime in the Control Panel.
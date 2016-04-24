
```
[center][img]http://www.newvegasnexus.com/downloads/images/39442-1-1307573754.png[/img][/center]

[center][b]Maintainers:[/b] Gribbleshnibit8 and snakster
[b]Contributors:[/b] Antistar, Aether89, T3T, Yukichigai, Zealotlee[/center]

[line]
[center]
[heading][b][color=#AA0000]*********************** IMPORTANT! ****************************[/color][/b][/heading]

[color=#FF8C00]*[/color] For all patches, the latest version of [url=http://www.newvegasnexus.com/downloads/file.php?id=40040]Project Nevada[/url] is [b]REQUIRED[/b].

[color=#FF8C00]*[/color] The [url=http://www.newvegasnexus.com/downloads/file.php?id=36901]Fallout Mod Manager (FOMM)[/url] is [b]HIGHLY RECOMMENDED[/b] for properly installing these patches.

If you have any problems or questions, please take a look at the [color=#FF8C00]Troubleshooting[/color] and [color=#FF8C00]FAQ[/color] sections at the bottom of this description page first.

[/center]
[line]
[img]http://www.newvegasnexus.com/downloads/images/39442-1-1307581518.png[/img]
[heading][b]Project Nevada - DLC Support[/b], Version: [color=#FF8C00]1.0[/color][/heading]
[b]REQUIREMENTS:[/b]
[b][url=http://store.steampowered.com/app/72730/]Dead Money[/url][/b] or [b][url=http://store.steampowered.com/app/72740/]Honest Hearts[/url][/b]

These patches enable support of all Project Nevada features for DLC-added items. This includes new Visor Overlays for helmets and custom Grenade Hotkey icons for explosives.
When using FOMM, the installer will automatically detect which DLC are installed and select the appropriate patches.

[line]
[img]http://www.newvegasnexus.com/downloads/images/39442-1-1307635472.png[/img]
[heading][b]Project Nevada - WMX Support[/b], Version: [color=#FF8C00]1.0[/color][/heading]
[b]REQUIREMENTS:[/b]
[b][url=http://www.newvegasnexus.com/downloads/file.php?id=39651]Weapon Mods Expanded - WMX[/url][/b], by Antistar
[b][url=http://www.newvegasnexus.com/downloads/file.php?id=40040]Project Nevada Equipment Module[/url][/b]

This patch adds the weapon mods that come with WMX to many of the new weapons in the Project Nevada Equipment module.
In cases where new mods had to be created, they match the style of existing WMX mods, many of them provided by Antistar himself.

[line]
[img]http://www.newvegasnexus.com/downloads/images/39442-5-1296232410.png[/img]

[b]We really recommend using the Fallout Mod Manager to install any of these patches![/b]
It will automatically copy the right files and warn you in case you miss any of the required mods.
So before you can get started, you have to choose whether you want to do the [color=#FF8C00]FOMM installation[/color] (recommended) or a [color=#FF8C00]manual installation[/color].
The procedure is the same for all patches.

Remember: Any compatiblity patch requires you to install the original mod first. For example, to use the WMX Support patches you'll have to install WMX first.

[heading][color=#FF8C00]>[/color] Automated Installation with FOMM[/heading]
[b]1.[/b] Start FOMM and click on [color=#FF8C00]Package Manager[/color].

[b]2.[/b] In the top-right button menu, click on [color=#FF8C00]Add FOMod[/color] and select the downloaded archive file.

[b]3.[/b] The patch will now appear in the list. [color=#FF8C00]Select[/color] it and click [color=#FF8C00]Activate[/color]. 

[b]4.[/b] If you are prompted to [color=#FF8C00]overwrite[/color] anything, click [color=#FF8C00]Yes to All[/color].

[b]5.[/b] Done!

  [b][size=4]OR[/size][/b]

[heading][color=#FF8C00]>[/color] Manual Installation[/heading]
[b]1.[/b] Locate the [color=#FF8C00]Data/[/color] folder in your Fallout New Vegas [color=#FF8C00]installation directory[/color]. Typically it's found at [color=#FF8C00]Program Files/Steam/SteamApps/common/fallout new vegas/Data/[/color].

[b]2.[/b] Extract the contents of the downloaded archive file to your [color=#FF8C00]Data/[/color] folder.

[b]3.[/b] In the New Vegas Launcher, click on [color=#FF8C00]Data Files[/color] and select the plugins you want.

[b]4.[/b] Done!

[heading][color=#FF8C00]>[/color] Load Order[/heading]
Make sure that all patches are loaded [b]AFTER[/b] their requirements. Otherwise your game will not start.

[line]
[img]http://www.newvegasnexus.com/downloads/images/39442-4-1296232545.png[/img]

[color=#FF8C00]*[/color] [b]Problem[/b]: My game crashes right after starting it!

Yes, that's pretty annoying! There are basically two things that can cause this:

[b]1.[/b] A missing requirement (some plugins depend on other plugins, and if they can't find them the game crashes).
To fix this, make sure that for every patch you're using, you have the listed requirements installed as well.
Also don't forgot to adjust your load order as described in the next point.
		
[b]2.[/b] Your load order is wrong.
If a patch, for example, depends on "WeaponModsExpanded.esp", it has to be loaded after this plugin.
You can fix your load order in FOMM by dragging plugins in the mod list. Make sure all patches you're using are placed after their requirements.


[line]
[img]http://www.newvegasnexus.com/downloads/images/39442-1-1296906879.png[/img]

[color=#FF8C00]*[/color] [b]Question[/b]: I'm a modder myself and I'm interested in using Project Nevada's features for custom mods. Is there some kind of documentation?

There's an extensive [url=https://docs.google.com/document/d/1FPIuZGoh5acg433cywGo1vi1dNFTJPXG6rNRgzCUoyc/edit?hl=en&authkey=CNicvuIF]Modder's Guide[/url] that documents all Project Nevada features (even those that are not visible at first glance).
This includes information on how to
- add Visor Overlays or Enhanced Vision Modes to custom armor,
- expand the Control Panel with new entries,
- use the hotkey assignment system and conflict detection for your own hotkeys,
- and much more!


[color=#FF8C00]*[/color] [b]Question[/b]: I'd like you to make a compatiblity patch for my favourite mod. Do you take requests?

We will gladly listen to any request, but we cannot promise to fulfill it, even if it's just a tiny one.
One of the reasons we wrote the Modder's Guide mentioned in the previous answer was so that people could go ahead and create their own patches, while we focus on further developing our mod.
Still, if you ask for a patch in the comments chances are that someone else might listen and help you out.


[color=#FF8C00]*[/color] [b]Question[/b]: I created a compatiblity patch. Will you put it on this page?

As mentioned, we encourage people to create compatiblity patches, and this page was created to serve as a hub for them.
So if your patch is working and stable, we can put it up here, or at the very least add a link to the supported mod.
```
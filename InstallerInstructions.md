Just in case anyone else ever has to create an installer package from SVN:

1. Go to the FONV Modules folder and export
> - All module folders you want AND
> - the installer folder AND
> - the PrepareInstaller.exe
to a temporary location.

2. Clear the exported modules of anything you dont want (fomod folder for example - but NOT for the installer of course)

3. Execute the PrepareInstaller.exe, it will generate lists for each package (ModuleFiles.txt).

4. Move these lists to the Installer/fomod folder.

5. Move the contents of all module folders to the Installer/ folder.
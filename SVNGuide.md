# Setup #

## 1. Install SVN Client ##

Get TortoiseSVN from http://tortoisesvn.net/downloads and install it.
It will add new entries to the context menu of your Windows Explorer.

## 2. Checkout repository ##

Firstly, create an empty folder somewhere and name it appropriately, i.e. **Project Nevada**.
Then right-click on this newly created folder and select **SVN Checkout**.
In the **URL of repository** field, insert _https://project-nevada.googlecode.com/svn/trunk/_ and click **OK**. Once that's completed, you can close the dialog, and your Project Nevada folder now contains the latest working copy of all files in the repository.

From now on, if you want to update the repository, you can just right-click on the folder and select **SVN Update**.

## 3. Make changes to the repository ##

Whenever you make changes to your local copy of the repository, i.e. by changing files or adding new ones, you can commit those changes to the real repository so others can see them too once they execute an update.
To do so, right-click on the folder and select **SVN Commit**. You then can insert a comment, describing what changes you made and probably why, and don't forget to check all files you want to add in the list below!
Next, it will ask you for your Google code account user name and your password, which you can both check out at https://code.google.com/hosting/settings.

# Usage #

## Copying files to your Data/ folder ##

If you want to copy plain files from the SVN repository, you dont have to consider anything special. If you, however, want to copy folders to your Fallout NV Data/ folder, you best use the SVN export feature, because every SVN folder also contains hidden versioning data you don't want to copy over (else, the folders in your Data/ directory will get those green SVN icons etc).

So to export something, just select what you want to copy in the windows explorer, and drag it with your right mouse button into your Data/ folder. In the opening context menu, select **SVN Export all items here**. Thats it.

## Clearing folders from versioning data ##

If you didn't use the method described above, and now something in your data folder has the SVN icons, you can fix it with the following method:
First, open _two_ explorer windows, and drag the folder onto itself with the right mouse button from the one explorer window to the other. In the opening context menu, select **SVN Export all items here**. You need to open two explorer windows because you cant drag a folder onto itself in a single window.
After this, SVN will ask you to confirm whether you really want to unversion the selected folder, which means that you did it right.
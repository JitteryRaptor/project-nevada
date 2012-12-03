:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
::RDIR -- Relative Directory listing
::Type RDIR /? for usage info
::Written by TheOutcaste 08/18/2008 for TechSupportGuy forum
::http://forums.techguy.org
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
@Echo Off
If [%1]==[/?] GoTo Usage
If [%1]==[-?] GoTo Usage
Setlocal EnableDelayedExpansion
If [%1]==[] goto Main
set _tmp=%1
If /I %_tmp:~0,3%==%CD:~0,3% GoTo Error
If /I %_tmp:~0,3%==..\ GoTo Error
:Main
Set _t0=1
If ["%CD%"]==["%CD:~0,3%"] Set _t0=0
For /F "tokens=*" %%A In ('Dir "%*" /b /on /s') Do (
   Set _t1=%%A
   Set _t2=!_t1:%CD%=!
   Echo !_t2:~%_t0%! >> get_files.txt
)
Endlocal
goto:EOF
:Error
Echo.
Echo.Error - Drive letter or parent folder was specified.
Echo.        You must specify only subfolders of the current folder
Echo.
:Usage
Echo.USAGE:
Echo.Generates a Directory listing in bare format relative to the current Folder
Echo.
Echo.RDIR [subfolder]
Echo.
Echo.  subfolder   Name of the subfolder of the current folder that you wish
Echo.              to list. If not specified, lists the current folder and it's
Echo.              subfolders
this program is written by ATribeCalledQuest-CeQue AKA Heffe or @Heffeeee on twitter

*****YOU HAVE TO RUN YOUTUBE-DL.EXE ONCE BEFORE USING THE .BAT*****
for this to work without editing the .bat you must preserve the file structure.
anything downloaded will be put in the music folder (or wherever youtube-dl.exe is, this cant be changed).
batcreator.cs can be used to create new .bat files that are configured for different directories, simply follow the on screen instructions.
if you want to move the bat file, right click it to create a shortcut and move that.

**more advanced stuff**
if you want to change the directory where the youtube-dl.exe is stored manually (NOT RECOMMENDED), you can edit the .bat file in notepad or notepad++.
here is an example that stores the youtube-dl.exe in the d drive instead of the c drive and in a folder called music instead of a folder called ytdl

REM **START**
@echo OFF
d:
cd D:\music
:loop
set /p url=Paste the url of the video you want to download: 
youtube-dl -f 140 %url%
goto loop
REM **END**

you can edit the directories to be anything you want but make sure the drive on the second line of code matches the drive on the third line of code.
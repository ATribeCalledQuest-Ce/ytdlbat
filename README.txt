this program is written by ATribeCalledQuest-CeQue AKA Heffe or @Heffeeee on twitter
youtube-dl is written by these fine people https://rg3.github.io/youtube-dl/about.html and has been released into the public domain. https://github.com/rg3/youtube-dl

*****YOU HAVE TO RUN YOUTUBE-DL.EXE ONCE BEFORE USING THE .BAT OR .EXE*****
for this to work without editing the .bat you must preserve the file structure.
anything downloaded will be put in the media folder (or wherever youtube-dl.exe is, this cant be changed).

If you want to download from somewhere else, create a shortcut of either the bat if you want to go through terminal or make a shortcut of the .exe if you want to use a GUI



**BELOW IS OUTDATED**

**more advanced stuff**
if you want to change the directory where the youtube-dl.exe is stored manually (NOT RECOMMENDED), you can edit the .bat file in notepad or notepad++.
here is an example that stores the youtube-dl.exe in the d drive instead of the c drive and in a folder called music instead of a folder called ytdl. this example downloads audio, if you wanted to download video, use the other file as a template.

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
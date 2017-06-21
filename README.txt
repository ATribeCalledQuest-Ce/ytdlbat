this program is written by ATribeCalledQuest-Ce AKA Heffe or @Heffeeee on twitter

for this to work without editing the .bat you must make a folder in the root of your c drive called "ytdl" (without the quotes) and place the youtube-dl windows exe from here: https://rg3.github.io/youtube-dl/download.html inside that folder.
anything downloaded through ytdl will apear in that folder (this cant be changed).
batcreator.cs can be used to create new .bat files that are configured for different directories, simply follow the on screen instructions.
you can move the .bat file wherever you want.

**more advanced stuff**
if you want to change the directory where the youtube-dl.exe is stored manually, you can edit the .bat file in notepad or notepad++.
here is an example that stores the youtube-dl.exe in the d drive instead of the c drive and in a folder called music instead of a folder called ytdl

#**START**
@echo OFF
d:
cd D:\music
:loop
set /p url=Paste the url of the video you want to download: 
youtube-dl -f 140 %url%
goto loop
#**END**

you can edit the directories to be anything you want but make sure the drive on the second line of code matches the drive on the third line of code.
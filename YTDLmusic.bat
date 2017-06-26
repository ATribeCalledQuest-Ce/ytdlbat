@echo OFF
REM Instructions for how to manually change the directory which the program will asume youtube-dl is in are provided both here in comments and in the README but it is recommended that you use batcreator.cs instead.
REM change "c:" to whatever drive you want the folder to be in if you want it to be in your f drive change c: to f:
REM c:
REM change C:\ytdl to the directory in the drive stated above if you want to store youtube-dl in f:\ytdl instead of c:\ytdl, change it to f:\ytdl.
cd media
:loop
set /p url=Paste the url of the video you want to download: 
youtube-dl -f 140 %url%
goto loop

@echo OFF
c:
cd C:\ytdl
:loop
set /p url=Paste the url of the video you want to download: 
youtube-dl -f 140 %url%
goto loop

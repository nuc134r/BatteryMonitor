@ECHO OFF

cd %~dp0/BatteryMonitor/bin/Release

copy BatteryMonitor.exe "%APPDATA%\Microsoft\Windows\Start Menu\Programs\Startup"

echo Successfully added to Startup folder

@PAUSE
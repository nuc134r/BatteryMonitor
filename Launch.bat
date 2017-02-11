@ECHO OFF

cd %~dp0/BatteryMonitor/bin/Release

Taskkill /F /IM BatteryMonitor.exe

start BatteryMonitor.exe

echo Successfully started BatteryMonitor

@PAUSE
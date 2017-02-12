cd %~dp0

Taskkill /F /IM BatteryMonitor.exe

msbuild /p:Configuration=Release

@PAUSE

@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe GameMode %CurDir%\datasheet\GameMode.xlsm %CurDir%\res%

copy %CurDir%\res\GameMode.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

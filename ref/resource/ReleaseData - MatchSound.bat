@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe MatchSound %CurDir%\datasheet\MatchSound.xlsm %CurDir%\res%

copy %CurDir%\res\MatchSound.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

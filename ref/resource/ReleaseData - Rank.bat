@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe Rank %CurDir%\datasheet\Rank.xlsm %CurDir%\res%

copy %CurDir%\res\Rank.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

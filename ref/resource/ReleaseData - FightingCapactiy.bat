@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe FightingCapacity %CurDir%\datasheet\FightingCapacity.xlsm %CurDir%\res%

copy %CurDir%\res\ExpectedScoreDiff.xml %CurDir%\..\client\Assets\Resources\Config\Func
copy %CurDir%\res\AttrEnhance.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

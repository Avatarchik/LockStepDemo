@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe Qualifying %CurDir%\datasheet\Qualifying.xlsm %CurDir%\res%

copy %CurDir%\res\QualifyingNew.xml %CurDir%\..\client\Assets\Resources\Config\Func
copy %CurDir%\res\QualifyingNewSeason.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

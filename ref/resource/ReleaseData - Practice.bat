@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe Practice %CurDir%\datasheet\Practice.xlsm %CurDir%\res%

copy %CurDir%\res\Practice.xml %CurDir%\..\client\Assets\Resources\Config\Func
copy %CurDir%\res\PracticeStep.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��



%ToolPath%DataMaker.exe Common %CurDir%\datasheet\Common.xlsm %CurDir%\res%

copy %CurDir%\res\Common.xml %CurDir%\..\client\Assets\Resources\Config\Func

@echo/

pause

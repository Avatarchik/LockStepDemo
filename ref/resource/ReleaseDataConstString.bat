@echo off
set CurDir=%cd%
set ToolPath=%CurDir%\tool\

@echo/

@echo ������Ϸ��������xml��


%ToolPath%DataMakerNew.exe lua ConstString %CurDir%\datasheet\ConstString.xlsm %CurDir%\res%


@echo/

pause

@echo off
::�ж�����·���ǲ����ļ���

for %%i in (%cd%\*.proto) do protogen.exe -i:%%i -o:%%~ni.cs

pause 
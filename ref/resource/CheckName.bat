@echo off
echo ��ʼ��顣��
echo.&call echo ��ȷ�����ֿ��ı����������ı��ı����ʽΪANSI
echo.&call echo �������������ı����˹��̿�����Ҫ�����ӡ���

for /f tokens^=1^ delims^=^" %%i in ('findstr /v "{ }" NameBase1.txt') do (
	for /f tokens^=1^ delims^=^" %%j in ('findstr /v "{ }" NameBase3.txt') do (
		for /f tokens^=1^ delims^=^" %%k in ('findstr /v "{ }" NameBase2.txt') do (
			echo %%i%%j%%k>>tempNameLib.txt
		)
	)
)

echo.&call echo ���ڼ�������֣��˹��̿�����Ҫ�����ӡ���
for /f tokens^=1^ delims^=^" %%i in (maskWord.txt) do (
	findstr /n "%%i" tempNameLib.txt>>invalidName.txt
)

del tempNameLib.txt

echo.&call echo ����������ȷ��invalidName.txt�ı��е���Ϣ��

pause
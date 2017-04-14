SET msbuild="C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

%msbuild% "CalculatorAutomatedTests.msbuild" /t:CICompileAndVerify /p:Configuration="Debug" /p:MSTestExePath="null" /p:SolutionName="" /p:ProjectDirectory=""

pause
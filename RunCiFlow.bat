SET msbuild="C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe"

%msbuild% "CalculatorCIAutomation.msbuild" /t:CICompileAndVerify /p:Configuration="Debug" /p:MSTestExePath="C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe" /p:ProjectDirectory="C:\Users\KowalskiP\Source\Repos\CITests\CITester"
pause
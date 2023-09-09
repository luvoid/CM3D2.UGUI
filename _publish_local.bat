for /f "usebackq delims=|" %%f in (`dir /S /b CM3D2.UGUI\bin\Release\LuVoid.*.nupkg`) do (
	nuget add %%f -Source %USERPROFILE%/.nuget/packages -Expand
)

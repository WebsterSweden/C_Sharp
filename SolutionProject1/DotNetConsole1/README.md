# dotnet new console
<pre>dotnet new console Project before run

DotNetConsole1
|   DotNetConsole1.csproj
|   Program.cs
|
\---obj
        DotNetConsole1.csproj.nuget.dgspec.json
        DotNetConsole1.csproj.nuget.g.props
        DotNetConsole1.csproj.nuget.g.targets
        project.assets.json
        project.nuget.cache

dotnet new console Project after run

DotNetConsole1
|   DotNetConsole1.csproj
|   Program.cs
|
+---bin
|   \---Debug
|       \---netcoreapp3.1
|               DotNetConsole1.deps.json
|               DotNetConsole1.dll
|               DotNetConsole1.exe
|               DotNetConsole1.pdb
|               DotNetConsole1.runtimeconfig.dev.json
|               DotNetConsole1.runtimeconfig.json
|
\---obj
    |   DotNetConsole1.csproj.nuget.dgspec.json
    |   DotNetConsole1.csproj.nuget.g.props
    |   DotNetConsole1.csproj.nuget.g.targets
    |   project.assets.json
    |   project.nuget.cache
    |
    \---Debug
        \---netcoreapp3.1
                .NETCoreApp,Version=v3.1.AssemblyAttributes.cs
                DotNetConsole1.AssemblyInfo.cs
                DotNetConsole1.AssemblyInfoInputs.cache
                DotNetConsole1.assets.cache
                DotNetConsole1.csproj.CoreCompileInputs.cache
                DotNetConsole1.csproj.FileListAbsolute.txt
                DotNetConsole1.csprojAssemblyReference.cache
                DotNetConsole1.dll
                DotNetConsole1.exe
                DotNetConsole1.genruntimeconfig.cache
                DotNetConsole1.pdb</pre>

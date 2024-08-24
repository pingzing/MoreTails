# MoreTails

Might turn into a Kitsune Tails modding API?

For now, it's just a proof-of-concept program that can be used to hook into Kitsune Tails, and do Stuff in response.

## Building

### Requirements
- .NET Framework v4.8 SDK
- A copy of Kitsune Tails

### Process

1) Modify the .csproj file's KitsuneTails reference node so that it points to your KitsuneTails.exe. It should look something like the below:

```xml
<Reference Include="KitsuneTails">
      <HintPath>C:\YourPath\ToKitsuneTails\Here\KitsuneTails.exe</HintPath>
</Reference>
```

2) Make your changes.
3) Build the project.
4) Copy `MoreTails.exe`, `MoreTails.exe.config`, `MoreTails.exe.manifest`, and `MoreTails.pdb` 
   from the output directory (which is, by default, `./bin/Release` or `./bin/Debug`), and place them next to your `KitsuneTails.exe` file.
6) Note that the output directory will contain a bunch of DLLs and the .exe itself from Kitsune Tails. These can be safely ignored/deleted.
7) This process sucks. TODO: Find a better one.
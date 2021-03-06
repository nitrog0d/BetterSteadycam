﻿using MelonLoader;
using System.Reflection;
using System.Runtime.InteropServices;
using BetterSteadycam;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(ModBuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct(ModBuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + ModBuildInfo.Author)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("9379bcea-10d3-44ff-b423-c3f197f2fa4b")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion(ModBuildInfo.Version)]
[assembly: AssemblyFileVersion(ModBuildInfo.Version)]
[assembly: MelonInfo(typeof(BetterSteadycamMod), ModBuildInfo.Name, ModBuildInfo.Version, ModBuildInfo.Author, ModBuildInfo.DownloadLink)]
[assembly: MelonGame(ModBuildInfo.GameDeveloper, ModBuildInfo.Game)]
[assembly: MelonOptionalDependencies("UIExpansionKit")]
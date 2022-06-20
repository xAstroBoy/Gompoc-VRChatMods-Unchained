using System;
using System.Reflection;
using MelonLoader;
using StandaloneThirdPerson;


[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonInfo(typeof(StandaloneThirdPerson.Main), ModConstants.NAME, ModConstants.VERSION, ModConstants.AUTHOR, ModConstants.DOWNLOAD_LINK)]
[assembly:AssemblyVersion(ModConstants.VERSION)]
[assembly:AssemblyFileVersion(ModConstants.VERSION)]
[assembly:AssemblyTitle(ModConstants.NAME)]
[assembly:AssemblyDescription(ModConstants.NAME)]
[assembly:AssemblyCopyright("Created by " + ModConstants.AUTHOR)]

namespace StandaloneThirdPerson;
public static class ModConstants
{
    public const string VERSION = "1.3.4";
    public const string NAME = "StandaloneThirdPerson";
    public const string AUTHOR = "gompo, ljoonal";
    public const string DOWNLOAD_LINK = "https://github.com/gompoc/VRChatMods/releases/";
}
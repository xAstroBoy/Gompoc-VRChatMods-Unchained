using System;
using System.Reflection;
using MelonLoader;
using WorldPredownload;


[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonInfo(typeof(WorldPredownload.WorldPredownload), ModConstants.NAME, ModConstants.VERSION, ModConstants.AUTHOR, ModConstants.DOWNLOAD_LINK)]
[assembly:AssemblyVersion(ModConstants.VERSION)]
[assembly:AssemblyFileVersion(ModConstants.VERSION)]
[assembly:AssemblyTitle(ModConstants.NAME)]
[assembly:AssemblyDescription(ModConstants.NAME)]
[assembly:AssemblyCopyright("Created by " + ModConstants.AUTHOR)]

namespace WorldPredownload;
public static class ModConstants
{
    public const string VERSION = "1.7.0";
    public const string NAME = "WorldPredownload";
    public const string AUTHOR = "gompo, yobson";
    public const string DOWNLOAD_LINK = "https://github.com/gompoc/VRChatMods/releases/";
}
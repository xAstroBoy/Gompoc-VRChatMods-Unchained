using System.Reflection;
using ActionMenuApi;
using MelonLoader;


[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonInfo(typeof(ActionMenuApi.ActionMenuApi), ModConstants.NAME, ModConstants.VERSION, ModConstants.AUTHOR, ModConstants.DOWNLOAD_LINK)]
[assembly:AssemblyVersion(ModConstants.VERSION)]
[assembly:AssemblyFileVersion(ModConstants.VERSION)]
[assembly:AssemblyTitle(ModConstants.NAME)]
[assembly:AssemblyDescription(ModConstants.NAME)]
[assembly:AssemblyCopyright("Created by " + ModConstants.AUTHOR)]

namespace ActionMenuApi;
public static class ModConstants
{
    public const string VERSION = "1.0.0";
    public const string NAME = "ActionMenuApi";
    public const string AUTHOR = "gompo";
    public const string DOWNLOAD_LINK = "https://github.com/gompoc/VRChatMods/releases/";
}
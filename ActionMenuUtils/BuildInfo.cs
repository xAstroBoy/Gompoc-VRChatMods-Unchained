using System.Reflection;
using ActionMenuUtils;
using MelonLoader;



[assembly: MelonGame("VRChat", "VRChat")]
[assembly: MelonInfo(typeof(ActionMenuUtils.Main), ModConstants.NAME, ModConstants.VERSION, ModConstants.AUTHOR, ModConstants.DOWNLOAD_LINK)]
[assembly:AssemblyVersion(ModConstants.VERSION)]
[assembly:AssemblyFileVersion(ModConstants.VERSION)]
[assembly:AssemblyTitle(ModConstants.NAME)]
[assembly:AssemblyDescription(ModConstants.NAME)]
[assembly:AssemblyCopyright("Created by " + ModConstants.AUTHOR)]

namespace ActionMenuUtils;
public static class ModConstants
{
    public const string VERSION = "2.0.4";
    public const string NAME = "ActionMenuUtils";
    public const string AUTHOR = "gompo";
    public const string DOWNLOAD_LINK = "https://github.com/gompoc/VRChatMods/releases/";
}
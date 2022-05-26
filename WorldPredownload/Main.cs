using Harmony;
using MelonLoader;
using UIExpansionKit.API;
using WorldPredownload.UI;

[assembly: MelonInfo(typeof(WorldPredownload.WorldPredownload), "WorldPredownload", "1.6.6", "gompo", "https://github.com/gompoc/VRChatMods/releases/")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace WorldPredownload
{
    internal partial class WorldPredownload : MelonMod
    {
        public new static HarmonyLib.Harmony HarmonyInstance => new HarmonyLib.Harmony("Gompoc");

        public override void OnApplicationStart()
        {
            ModSettings.RegisterSettings();
            ModSettings.LoadSettings();
            SocialMenuSetup.Patch();
            WorldInfoSetup.Patch();
            //NotificationMoreActions.Patch();
            ExpansionKitApi.OnUiManagerInit += UiManagerInit;
        }

        private void UiManagerInit()
        {
            if (string.IsNullOrEmpty(ID)) return;
            InviteButton.Setup();
            FriendButton.Setup();
            WorldButton.Setup();
            //WorldDownloadStatus.Setup();
            HudIcon.Setup();
        }

        public override void OnPreferencesLoaded()
        {
            ModSettings.LoadSettings();
        }

        public override void OnPreferencesSaved()
        {
            ModSettings.LoadSettings();
        }
    }
}
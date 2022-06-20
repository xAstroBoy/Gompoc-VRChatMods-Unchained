### ActionMenuApi v1.0.0
- TODO

### Update Checker v1.0.1
- Updated to api/v1 (Credit to DubyaDude)

### StandaloneThirdPerson v1.3.4
- Fixed random null ref

### WorldPredownload v1.7.0
- Compatibility fix for update and add ability to download worlds via portals (credit to yobson)

### WorldPredownload v1.6.6
- Compatibility fix for build 1151

### WorldPredownload v1.6.5
- *Actually downloads worlds properly now*

### WorldPredownload v1.6.4
- Fix compatibility with latest update

### ActionMenuUtils v2.0.4
- *Actually* fix compatibility with latest update

### ActionMenuUtils v2.0.3
- Fixed compatibility for ui update

### ActionMenuApi v0.3.5
- Fixed compatibility for ui update

### StandaloneThirdPerson v1.3.3
- Fixed compatibility for ui update

### ActionMenuUtils v2.0.2
- Change text on uix button to fit it better

### ActionMenuUtils v2.0.1
- Fixed exception being thrown when selecting an avatar

### ActionMenuUtils v2.0.0
- Mod now depends on ActionMenuApi & UIExpansionKit, this just makes maintaining it easier for me when/if something breaks
- New setting added that you can enable so you can now select which avatar you want to reset into. You can select avatar by going to the AvatarMenu and clicking the UIExpansionKit button on the left

### StandaloneThirdPerson v1.3.0
- Fixed issue with mod not showing when not launching through steam (--no-vr)
- Added secondary keybinds for third person toggle and freeform toggle, you can leave these as `None` or set them to `LeftControl` for example
- Added a setting to enable/disable freeform

### StandaloneThirdPerson v1.2.1
- Added a few more null checks to help track down annoying bug
- Keybind value case no longer matters (`T` and `t` are now the same and both are valid)

### WorldPredownload v1.6.2
- Patch out possible memory leak

### WorldPredownload v1.6.1
- Small bug fix

### WorldPredownload v1.6.0
- Temporarily disable invite predownloading
- Fixed downloading issues (Thanks [Natsumi](https://github.com/Natsumi-sama/) for your help :) )

### UpdateChecker v1.0.0
- Initial release

### StandaloneThirdPerson v1.2.0
- Added a freeform camera (You can thank [ljoonal](https://github.com/ljoonal/) for that)

### ActionMenuUtils v1.3.11
- Recompile to fix issues

### StandaloneThirdPerson v1.1.0
- Added keybinds to move the rear camera over your avatars shoulders

### StandaloneThirdPerson v1.0.1
- Quick patch for vr

### StandaloneThirdPerson v1.0.0
- Initial Release

### WorldPredownload v1.5.3
- Recompile for u2019 update
- Improved speed of cache fetching on world join 

### ActionMenuUtils v1.3.10
- Resubmit

### WorldPredownload v1.5.2
- Added retry logic for null asset url
- If UI gets stuck now (for some magical reason) a world rejoin should fix it

### WorldPredownload v1.5.1
- Minor bug fix for null asset url 

### WorldPredownload v1.5.0
- Fixed 1108 compatibility. A good chunk of the mod was rewritten to support this build
this introduces possibly more bugs/problems from my end as the mod now handles 
  all of the downloading process including the post file processing. If there 
  are any issues let me know.

### ActionMenuUtils v1.3.9
- Fixed compatibility problems with Build 1106

### WorldPredownload v1.4.7
- Fixed friend Predownload button placement

### WorldPredownload v1.4.6
- Build 1101 compatibility fix

### WorldPredownload v1.4.5
- Switched to UIX 0.3.0+ UIManagerInit Event (ML v0.3.1 compatibility update)

### DownloadFix v1.0.3
- Switched to UIX 0.3.0+ UIManagerInit Event (ML v0.3.1 compatibility update)

### ActionMenuUtils v1.3.8
- Fixed incorrect textures on pedals when using ActionMenuApi

### WorldPredownload v1.4.4
- Build 1093 compatibility fix
- Fixed issue with cache checking

### WorldPredownload v1.4.3
- Build 1089 compatibility fix

### WorldPredownload v1.4.2

- Fixed Invite Button Ui Tooltip Text
- Removed Components (VRChat cloned one of them 100 times 👀). This should make the mod just that little bit more optimized.
- Fixed Dismiss Popup XRef failing
- Added a new setting to hide "Not Downloading" text when not downloading
- Cache will only be fetched once now (on start up) (again, it makes the mod just that little bit more optimized) It'll add other worlds you download while playing through the use of magic.
- Future-proofed some stuff (for ML v0.3.1)
- Fixed "Go to world page" button on popup throwing an exception

### WorldPredownload v1.3.6 

- Added back invite predownloading 👌

### WorldPredownload v1.3.5

- Mod now has a hud icon you can enable or disable using uix or edit the melon prefs file

### WorldPredownload v1.3.4

- Mod will no longer "eat" your join/friend requests
- Mod should hopefully update text more consistently
- Slightly better performance here and there
- Yeeted the override settings because it was hurting my head 

### WorldPredownload v1.3.2.1 

- Popup will no longer show when you have a worldInfo page or userinfo open in the menu as you can see download status there 
- Mod will now check to see if the world has been downloaded previously except on invite notification menu 

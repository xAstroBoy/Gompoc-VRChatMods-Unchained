﻿using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using VRC.Core;
using WorldPredownload.Cache;
using WorldPredownload.Helpers;
using WorldPredownload.UI;
using OnDownloadProgress = AssetBundleDownloadManager.MulticastDelegateNInternalSealedVoUnUnique;
// ReSharper disable NotNullMemberIsNotInitialized

namespace WorldPredownload.DownloadManager
{
    public static partial class WorldDownloadManager
    {
        public static DownloadInfo DownloadInfo;

        private static WebClient webClient;

        private static string file;
        public static bool Downloading { get; set; }

        public static void CancelDownload()
        {
            if (Downloading)
            {
                if (ModSettings.showHudMessages) Utilities.QueueHudMessage("Download Cancelled");
                webClient.CancelAsync();
                webClient.Dispose();
            }
        }

        private static void ClearDownload()
        {
            //DownloadInfo = null; Ignore this lel
        }

        private static void DisplayWorldPopup()
        {
            if (GameObject.Find("UserInterface/MenuContent/Screens/WorldInfo").active)
            {
                ClearDownload();
                return;
            }

            Utilities.ShowOptionPopup(
                Constants.SUCCESS_TITLE,
                Constants.SUCCESS_MSG,
                Constants.SUCCESS_LEFT_BTN_TEXT,
                new Action(delegate
                {
                    Utilities.HideCurrentPopup();
                    Utilities.OpenWorldInfoPage();
                    DownloadInfo.PageWorldInfo!.Method_Public_Void_ApiWorld_ApiWorldInstance_Boolean_Boolean_Boolean_APIUser_0(DownloadInfo.ApiWorld, DownloadInfo.PageWorldInfo.field_Public_ApiWorldInstance_0);
                    ClearDownload();
                }),
                Constants.SUCCESS_RIGHT_BTN_TEXT,
                new Action(delegate
                {
                    Utilities.HideCurrentPopup();
                    ClearDownload();
                })
            );
        }

        private static void DisplayInvitePopup()
        {
            Utilities.ShowDismissPopup(
                Constants.SUCCESS_TITLE,
                Constants.SUCCESS_MSG,
                Constants.SUCCESS_RIGHT_BTN_TEXT,
                new Action(delegate
                {
                    Utilities.HideCurrentPopup();
                    ClearDownload();
                })
            );
        }

        private static void DisplayFriendPopup()
        {
            if (GameObject.Find("UserInterface/MenuContent/Screens/UserInfo").active)
            {
                ClearDownload();
                return;
            }

            Utilities.ShowOptionPopup(
                Constants.SUCCESS_TITLE,
                Constants.SUCCESS_MSG,
                Constants.SUCCESS_LEFT_BTN_TEXT_F,
                new Action(delegate
                {
                    _ = DownloadInfo.APIUser ?? throw new NullReferenceException("Friend User Info Null Uh Oh");
                    Utilities.HideCurrentPopup();
                    Utilities.OpenUserInfoPage();
                    DownloadInfo.PageUserInfo.LoadUser(DownloadInfo.APIUser);
                    ClearDownload();
                }),
                Constants.SUCCESS_RIGHT_BTN_TEXT,
                new Action(delegate
                {
                    Utilities.HideCurrentPopup();
                    ClearDownload();
                })
            );
        }

        private static void DisplayPortalPopup()
        {
            Utilities.ShowOptionPopup(
                Constants.SUCCESS_TITLE,
                Constants.SUCCESS_MSG,
                Constants.SUCCESS_LEFT_BTN_TEXT_P,
                new Action(delegate
                {
                    Utilities.HideCurrentPopup();
                    Utilities.GoToWorld(DownloadInfo.ApiWorld, DownloadInfo.InstanceIDTags, false);
                    ClearDownload();
                }),
                Constants.SUCCESS_RIGHT_BTN_TEXT,
                new Action(delegate
                {
                    Utilities.HideCurrentPopup();
                    ClearDownload();
                })
            );
        }

        private static void DownloadWorld(ApiWorld apiWorld)
        {
            if (!Downloading)
            {
                if (ModSettings.showStatusOnHud) HudIcon.Enable();
                if (ModSettings.showStatusOnQM) WorldDownloadStatus.Enable();
                if (ModSettings.showHudMessages) Utilities.QueueHudMessage("Starting Download");
                Downloading = true;
                Download(apiWorld, OnProgress, OnComplete);
            }
            else
            {
                InviteButton.Button.SetText(Constants.BUTTON_IDLE_TEXT);
                WorldButton.Button.SetText(Constants.BUTTON_IDLE_TEXT);
                FriendButton.Button.SetText(Constants.BUTTON_IDLE_TEXT);
            }
        }

        public static void ProcessDownload(DownloadInfo downloadInfo)
        {
            if (string.IsNullOrEmpty(downloadInfo.ApiWorld.assetUrl))
            {
                MelonLogger.Warning("World asset link missing! Did VRChat fail to load the world info?, trying to refetch world...");
                API.Fetch<ApiWorld>(downloadInfo.ApiWorld.id,new Action<ApiContainer>(container =>
                {
                    ApiWorld apiWorld = container.Model.Cast<ApiWorld>();
                    if (string.IsNullOrEmpty(apiWorld.assetUrl))
                    {
                        MelonLogger.Error("Well... the apiworld asset url was still missing after refetching sooo uhhh, skipping download");
                        return;
                    }
                    downloadInfo.ApiWorld.assetUrl = apiWorld.assetUrl;
                    ProcessDownload(downloadInfo);
                }));
                return;
            }
            DownloadInfo = downloadInfo;
            if (downloadInfo.DownloadType == DownloadType.Invite && !Downloading)
                MelonCoroutines.Start(InviteButton.InviteButtonTimer(15));
            DownloadWorld(downloadInfo.ApiWorld);
        }

        [SuppressMessage("ReSharper", "HeuristicUnreachableCode")]
        private static void Download(ApiWorld apiWorld, DownloadProgressChangedEventHandler progress, AsyncCompletedEventHandler compete)
        {
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            webClient?.Dispose();
            webClient = new WebClient();
            #if DEBUG
            MelonLogger.Msg($"Using UserAgent: {ModSettings.downloadUserAgent}");
            #endif
            webClient.Headers.Add(HttpRequestHeader.UserAgent, ModSettings.downloadUserAgent);
            webClient.DownloadProgressChanged += progress;
            webClient.DownloadFileCompleted += compete;

            var cachePath = CacheManager.GetCache().path;
            var assetHash = CacheManager.ComputeAssetHash(apiWorld.assetUrl);
            var dir = Path.Combine(cachePath, assetHash);
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            var assetVersionDir = Path.Combine(dir, "000000000000000000000000" + CacheManager.ComputeVersionString(apiWorld.assetUrl));
            if (!Directory.Exists(assetVersionDir)) Directory.CreateDirectory(assetVersionDir);

            var fileName = Path.Combine(assetVersionDir, "__data");
            #if DEBUG
            MelonLogger.Msg($"Calculated Directory: {assetVersionDir}");
            #endif
            MelonLogger.Msg($"Starting world download for: {apiWorld.name}");
            file = fileName;

            #if DEBUG
            MelonLogger.Msg($"AssetUrl: {apiWorld.assetUrl}");
            #endif

            webClient.DownloadFileAsync(new Uri(apiWorld.assetUrl), fileName);
        }
    }
}

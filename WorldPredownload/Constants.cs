﻿using UnityEngine;

namespace WorldPredownload
{
    public static class Constants
    {
        public const string INVITE_BUTTON_NAME = "PredownloadInviteButton";

        public const string INVITE_BUTTON_TOOLTIP =
            "Lets you Predownload the world you were invited too (Note: invite's aren't checked to see if the world you've been invite to has already been downloaded)";

        public const string FRIEND_BUTTON_NAME = "PredownloadFriendButton";
        public const string WORLD_BUTTON_NAME = "PredownloadWorldButton";
        public const string STATUS_NAME = "DownloadStatusText";

        public const string STATUS_IDLE_TEXT = "Not Downloading";

        //public const string BUTTON_INVITE_OVERWRITE_TEXT = "Accept";
        public const string BUTTON_IDLE_TEXT = "Predownload";

        //public const string BUTTON_IDLE_OVERRIDE_TEXT = "Predownload";
        public const string BUTTON_BUSY_TEXT = "Cancel other download";

        public const string BUTTON_ALREADY_DOWNLOADED_TEXT = "Downloaded";

        //public const string BUTTON_ALREADY_DOWNLOADED_OVERRIDE_TEXT = "Downloaded";
        public const string ERROR_TITLE = "World Predownload Failed";
        public const string ERROR_MSG = "There was an error predownloading the world";
        public const string ERROR_BTN_TEXT = "Dismiss";
        public const string SUCCESS_TITLE = "World Download Complete";

        public const string SUCCESS_MSG =
            "Your world has finished downloading, you can now go to the world if you wish so";

        public const string SUCCESS_LEFT_BTN_TEXT = "Go to World Page";
        public const string SUCCESS_RIGHT_BTN_TEXT = "Dismiss";
        public const string SUCCESS_LEFT_BTN_TEXT_F = "Go to Friend Page";
        public const string SUCCESS_LEFT_BTN_TEXT_P = "Join portal instance";
        public const float FRIEND_PANEL_YPOS = -350f;
        public const float FRIEND_PANEL_YSCALE = 1.1f;
        public const float SOCIAL_PANEL_YPOS = 384f;

        public static readonly Vector2 InviteButtonPos = new(630f, -208f);

        public static readonly Vector2 WorldButtonPos = new(230f, -10f);

        //public static readonly Vector2 WORLD_BUTTON_OVERRIDE_POS = new Vector2(-293f, 8f);
        public static readonly Vector2 FriendButtonPos = new(-915f, 458f);
        public static readonly Vector2 DwldStatusPos = new(900f, -225f);
    }
}

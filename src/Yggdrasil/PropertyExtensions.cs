﻿using Yggdrasil.Models;

namespace Yggdrasil
{
    public static class PropertyExtensions
    {
        public static bool IsPreferredLanguageProperty(this Property property)
            => property.Name == "preferredLanguage";

        public static bool IsTwitchAccessTokenProperty(this Property property)
            => property.Name == "twitch_access_token";
    }
}
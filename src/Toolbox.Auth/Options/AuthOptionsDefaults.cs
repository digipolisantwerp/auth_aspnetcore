﻿namespace Toolbox.Auth.Options
{
    public static class AuthOptionsDefaults
    {
        public const string JwtUserIdClaimType = "sub";
        public const string OptionsFileName = "authconfig.json";
        public const string TokenCallbackRoute = "auth/token";
        public const string TokenRefreshRoute = "auth/token/refresh";
        public const string PermissionsRoute = "auth/user/permissions";
    }
}

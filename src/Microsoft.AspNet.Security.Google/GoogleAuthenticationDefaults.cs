// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNet.Security.Google
{
    public static class GoogleAuthenticationDefaults
    {
        public const string AuthenticationType = "Google";

        public const string AuthorizationEndpoint = "https://accounts.google.com/o/oauth2/auth";

        public const string TokenEndpoint = "https://accounts.google.com/o/oauth2/token";

        public const string UserInformationEndpoint = "https://www.googleapis.com/plus/v1/people/me";
    }
}

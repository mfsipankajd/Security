// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.AspNet.Security
{
    // Must contain a claim with the specified name, and at least one of the required values
    // If AllowedValues is null or empty, that means any claim is valid
    public class ClaimRequirement : IAuthorizationRequirement
    {
        public string ClaimType { get; set; }
        public IEnumerable<string> AllowedValues { get; set; }
    }
}

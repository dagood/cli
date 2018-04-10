﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if !DOTNET_BUILD_FROM_SOURCE
using Microsoft.AspNetCore.DeveloperCertificates.XPlat;
#endif

using Microsoft.DotNet.Configurer;

namespace Microsoft.DotNet.Cli
{
    public class AspNetCoreCertificateGenerator : IAspNetCoreCertificateGenerator
    {
        public void GenerateAspNetCoreDevelopmentCertificate()
        {
#if !DOTNET_BUILD_FROM_SOURCE
            CertificateGenerator.GenerateAspNetHttpsCertificate();
#endif
        }
    }
}

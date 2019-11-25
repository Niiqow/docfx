// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Microsoft.Docs.Build
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    internal class GlobalMetadata
    {
        // For v2 backward compatibility
        public HashSet<string> ContributorsToExclude { get; set; } = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        // For v2 backward compatibility
        [JsonProperty("_op_documentIdPathDepotMapping")]
        public Dictionary<PathString, DocumentIdConfig> DocumentIdDepotMapping { get; set; }

        [JsonExtensionData]
        public JObject ExtensionData { get; set; } = new JObject();
    }
}

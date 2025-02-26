// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class SupportedStacksList
    {
        internal static SupportedStacksList DeserializeSupportedStacksList(JsonElement element)
        {
            Optional<IReadOnlyList<SupportedStackResourceData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SupportedStackResourceData> array = new List<SupportedStackResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SupportedStackResourceData.DeserializeSupportedStackResourceData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SupportedStacksList(Optional.ToList(value), nextLink.Value);
        }
    }
}

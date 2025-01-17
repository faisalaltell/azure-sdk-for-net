// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class UpdatePrerequisite : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UpdateType))
            {
                writer.WritePropertyName("updateType"u8);
                writer.WriteStringValue(UpdateType);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            writer.WriteEndObject();
        }

        internal static UpdatePrerequisite DeserializeUpdatePrerequisite(JsonElement element)
        {
            Optional<string> updateType = default;
            Optional<string> version = default;
            Optional<string> packageName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("updateType"u8))
                {
                    updateType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageName"u8))
                {
                    packageName = property.Value.GetString();
                    continue;
                }
            }
            return new UpdatePrerequisite(updateType.Value, version.Value, packageName.Value);
        }
    }
}

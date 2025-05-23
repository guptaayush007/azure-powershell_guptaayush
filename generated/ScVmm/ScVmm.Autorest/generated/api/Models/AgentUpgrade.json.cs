// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Extensions;

    /// <summary>The info w.r.t Agent Upgrade.</summary>
    public partial class AgentUpgrade
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject into a new instance of <see cref="AgentUpgrade" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AgentUpgrade(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_desiredVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("desiredVersion"), out var __jsonDesiredVersion) ? (string)__jsonDesiredVersion : (string)_desiredVersion;}
            {_correlationId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("correlationId"), out var __jsonCorrelationId) ? (string)__jsonCorrelationId : (string)_correlationId;}
            {_enableAutomaticUpgrade = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonBoolean>("enableAutomaticUpgrade"), out var __jsonEnableAutomaticUpgrade) ? (bool?)__jsonEnableAutomaticUpgrade : _enableAutomaticUpgrade;}
            {_lastAttemptDesiredVersion = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("lastAttemptDesiredVersion"), out var __jsonLastAttemptDesiredVersion) ? (string)__jsonLastAttemptDesiredVersion : (string)_lastAttemptDesiredVersion;}
            {_lastAttemptTimestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("lastAttemptTimestamp"), out var __jsonLastAttemptTimestamp) ? (string)__jsonLastAttemptTimestamp : (string)_lastAttemptTimestamp;}
            {_lastAttemptStatus = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("lastAttemptStatus"), out var __jsonLastAttemptStatus) ? (string)__jsonLastAttemptStatus : (string)_lastAttemptStatus;}
            {_lastAttemptMessage = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString>("lastAttemptMessage"), out var __jsonLastAttemptMessage) ? (string)__jsonLastAttemptMessage : (string)_lastAttemptMessage;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentUpgrade.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentUpgrade.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Models.IAgentUpgrade FromJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject json ? new AgentUpgrade(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AgentUpgrade" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AgentUpgrade" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._desiredVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._desiredVersion.ToString()) : null, "desiredVersion" ,container.Add );
            AddIf( null != (((object)this._correlationId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._correlationId.ToString()) : null, "correlationId" ,container.Add );
            AddIf( null != this._enableAutomaticUpgrade ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonBoolean((bool)this._enableAutomaticUpgrade) : null, "enableAutomaticUpgrade" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastAttemptDesiredVersion)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._lastAttemptDesiredVersion.ToString()) : null, "lastAttemptDesiredVersion" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastAttemptTimestamp)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._lastAttemptTimestamp.ToString()) : null, "lastAttemptTimestamp" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastAttemptStatus)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._lastAttemptStatus.ToString()) : null, "lastAttemptStatus" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._lastAttemptMessage)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.ScVmm.Runtime.Json.JsonString(this._lastAttemptMessage.ToString()) : null, "lastAttemptMessage" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}
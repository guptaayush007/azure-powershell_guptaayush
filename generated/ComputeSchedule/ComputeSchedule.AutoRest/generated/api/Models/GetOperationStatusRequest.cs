// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Extensions;

    /// <summary>This is the request to get operation status using operationids</summary>
    public partial class GetOperationStatusRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationStatusRequest,
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Models.IGetOperationStatusRequestInternal
    {

        /// <summary>Backing field for <see cref="Correlationid" /> property.</summary>
        private string _correlationid;

        /// <summary>CorrelationId item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public string Correlationid { get => this._correlationid; set => this._correlationid = value; }

        /// <summary>Backing field for <see cref="OperationId" /> property.</summary>
        private System.Collections.Generic.List<string> _operationId;

        /// <summary>The list of operation ids to get the status of</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Origin(Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> OperationId { get => this._operationId; set => this._operationId = value; }

        /// <summary>Creates an new <see cref="GetOperationStatusRequest" /> instance.</summary>
        public GetOperationStatusRequest()
        {

        }
    }
    /// This is the request to get operation status using operationids
    public partial interface IGetOperationStatusRequest :
        Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.IJsonSerializable
    {
        /// <summary>CorrelationId item</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"CorrelationId item",
        SerializedName = @"correlationid",
        PossibleTypes = new [] { typeof(string) })]
        string Correlationid { get; set; }
        /// <summary>The list of operation ids to get the status of</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ComputeSchedule.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of operation ids to get the status of",
        SerializedName = @"operationIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> OperationId { get; set; }

    }
    /// This is the request to get operation status using operationids
    internal partial interface IGetOperationStatusRequestInternal

    {
        /// <summary>CorrelationId item</summary>
        string Correlationid { get; set; }
        /// <summary>The list of operation ids to get the status of</summary>
        System.Collections.Generic.List<string> OperationId { get; set; }

    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Extensions;

    /// <summary>Security Profile specifies attributes for cluster security features.</summary>
    public partial class SecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfile,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileInternal
    {

        /// <summary>Internal Acessors for WorkloadIdentity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileWorkloadIdentity Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileInternal.WorkloadIdentity { get => (this._workloadIdentity = this._workloadIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.SecurityProfileWorkloadIdentity()); set { {_workloadIdentity = value;} } }

        /// <summary>Backing field for <see cref="WorkloadIdentity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileWorkloadIdentity _workloadIdentity;

        /// <summary>The workload identity feature webhook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileWorkloadIdentity WorkloadIdentity { get => (this._workloadIdentity = this._workloadIdentity ?? new Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.SecurityProfileWorkloadIdentity()); set => this._workloadIdentity = value; }

        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.PropertyOrigin.Inlined)]
        public bool? WorkloadIdentityEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileWorkloadIdentityInternal)WorkloadIdentity).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileWorkloadIdentityInternal)WorkloadIdentity).Enabled = value ?? default(bool); }

        /// <summary>Creates an new <see cref="SecurityProfile" /> instance.</summary>
        public SecurityProfile()
        {

        }
    }
    /// Security Profile specifies attributes for cluster security features.
    public partial interface ISecurityProfile :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.IJsonSerializable
    {
        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether to enable or disable the workload identity Webhook",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? WorkloadIdentityEnabled { get; set; }

    }
    /// Security Profile specifies attributes for cluster security features.
    internal partial interface ISecurityProfileInternal

    {
        /// <summary>The workload identity feature webhook.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedKubernetes.Models.Api20240715Preview.ISecurityProfileWorkloadIdentity WorkloadIdentity { get; set; }
        /// <summary>Whether to enable or disable the workload identity Webhook</summary>
        bool? WorkloadIdentityEnabled { get; set; }

    }
}
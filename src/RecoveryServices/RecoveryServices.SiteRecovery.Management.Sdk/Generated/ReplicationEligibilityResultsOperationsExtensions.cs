// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ReplicationEligibilityResultsOperations
    /// </summary>
    public static partial class ReplicationEligibilityResultsOperationsExtensions
    {
        /// <summary>
        /// Validates whether a given VM can be protected or not in which case returns
        /// list of errors.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='virtualMachineName'>
        /// Virtual Machine name.
        /// </param>
        public static ReplicationEligibilityResultsCollection List(this IReplicationEligibilityResultsOperations operations, string resourceGroupName, string virtualMachineName)
        {
                return ((IReplicationEligibilityResultsOperations)operations).ListAsync(resourceGroupName, virtualMachineName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Validates whether a given VM can be protected or not in which case returns
        /// list of errors.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='virtualMachineName'>
        /// Virtual Machine name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ReplicationEligibilityResultsCollection> ListAsync(this IReplicationEligibilityResultsOperations operations, string resourceGroupName, string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, virtualMachineName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Validates whether a given VM can be protected or not in which case returns
        /// list of errors.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='virtualMachineName'>
        /// Virtual Machine name.
        /// </param>
        public static ReplicationEligibilityResults Get(this IReplicationEligibilityResultsOperations operations, string resourceGroupName, string virtualMachineName)
        {
                return ((IReplicationEligibilityResultsOperations)operations).GetAsync(resourceGroupName, virtualMachineName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Validates whether a given VM can be protected or not in which case returns
        /// list of errors.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='virtualMachineName'>
        /// Virtual Machine name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ReplicationEligibilityResults> GetAsync(this IReplicationEligibilityResultsOperations operations, string resourceGroupName, string virtualMachineName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, virtualMachineName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for TargetComputeSizesOperations
    /// </summary>
    public static partial class TargetComputeSizesOperationsExtensions
    {
        /// <summary>
        /// Lists the available target compute sizes for a replication protected item.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// protection container name.
        /// </param>
        /// <param name='replicatedProtectedItemName'>
        /// Replication protected item name.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<TargetComputeSize> ListByReplicationProtectedItems(this ITargetComputeSizesOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicatedProtectedItemName)
        {
                return ((ITargetComputeSizesOperations)operations).ListByReplicationProtectedItemsAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, replicatedProtectedItemName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the available target compute sizes for a replication protected item.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group where the recovery services vault is
        /// present.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the recovery services vault.
        /// </param>
        /// <param name='fabricName'>
        /// Fabric name.
        /// </param>
        /// <param name='protectionContainerName'>
        /// protection container name.
        /// </param>
        /// <param name='replicatedProtectedItemName'>
        /// Replication protected item name.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<TargetComputeSize>> ListByReplicationProtectedItemsAsync(this ITargetComputeSizesOperations operations, string resourceGroupName, string resourceName, string fabricName, string protectionContainerName, string replicatedProtectedItemName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByReplicationProtectedItemsWithHttpMessagesAsync(resourceGroupName, resourceName, fabricName, protectionContainerName, replicatedProtectedItemName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Lists the available target compute sizes for a replication protected item.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<TargetComputeSize> ListByReplicationProtectedItemsNext(this ITargetComputeSizesOperations operations, string nextPageLink)
        {
                return ((ITargetComputeSizesOperations)operations).ListByReplicationProtectedItemsNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Lists the available target compute sizes for a replication protected item.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<TargetComputeSize>> ListByReplicationProtectedItemsNextAsync(this ITargetComputeSizesOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListByReplicationProtectedItemsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}

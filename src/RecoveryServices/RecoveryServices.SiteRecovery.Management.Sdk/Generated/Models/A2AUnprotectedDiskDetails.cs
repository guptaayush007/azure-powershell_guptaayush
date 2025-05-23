// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2A unprotected disk details.
    /// </summary>
    public partial class A2AUnprotectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2AUnprotectedDiskDetails class.
        /// </summary>
        public A2AUnprotectedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AUnprotectedDiskDetails class.
        /// </summary>

        /// <param name="diskLunId">The source lun Id for the data disk.
        /// </param>

        /// <param name="diskAutoProtectionStatus">A value indicating whether the disk auto protection is enabled.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>
        public A2AUnprotectedDiskDetails(int? diskLunId = default(int?), string diskAutoProtectionStatus = default(string))

        {
            this.DiskLunId = diskLunId;
            this.DiskAutoProtectionStatus = diskAutoProtectionStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the source lun Id for the data disk.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskLunId")]
        public int? DiskLunId {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the disk auto protection is
        /// enabled. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskAutoProtectionStatus")]
        public string DiskAutoProtectionStatus {get; set; }
    }
}
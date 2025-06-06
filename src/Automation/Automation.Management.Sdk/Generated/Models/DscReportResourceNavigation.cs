// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Navigation for DSC Report Resource.
    /// </summary>
    public partial class DscReportResourceNavigation
    {
        /// <summary>
        /// Initializes a new instance of the DscReportResourceNavigation class.
        /// </summary>
        public DscReportResourceNavigation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscReportResourceNavigation class.
        /// </summary>

        /// <param name="resourceId">Gets or sets the ID of the resource to navigate to.
        /// </param>
        public DscReportResourceNavigation(string resourceId = default(string))

        {
            this.ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the ID of the resource to navigate to.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId {get; set; }
    }
}
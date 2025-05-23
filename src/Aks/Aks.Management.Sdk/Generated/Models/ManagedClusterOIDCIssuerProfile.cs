// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// The OIDC issuer profile of the Managed Cluster.
    /// </summary>
    public partial class ManagedClusterOidcIssuerProfile
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterOidcIssuerProfile class.
        /// </summary>
        public ManagedClusterOidcIssuerProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterOidcIssuerProfile class.
        /// </summary>

        /// <param name="issuerUrl">The OIDC issuer url of the Managed Cluster.
        /// </param>

        /// <param name="enabled">Whether the OIDC issuer is enabled.
        /// </param>
        public ManagedClusterOidcIssuerProfile(string issuerUrl = default(string), bool? enabled = default(bool?))

        {
            this.IssuerUrl = issuerUrl;
            this.Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the OIDC issuer url of the Managed Cluster.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "issuerURL")]
        public string IssuerUrl {get; private set; }

        /// <summary>
        /// Gets or sets whether the OIDC issuer is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled {get; set; }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Route Filter Resource.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class PatchRouteFilter : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the PatchRouteFilter class.
        /// </summary>
        public PatchRouteFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PatchRouteFilter class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">The name of the resource that is unique within a resource group. This name
        /// can be used to access the resource.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="type">Resource type.
        /// </param>

        /// <param name="tags">Resource tags.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the route filter resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="rules">Collection of RouteFilterRules contained within a route filter.
        /// </param>

        /// <param name="peerings">A collection of references to express route circuit peerings.
        /// </param>

        /// <param name="ipv6Peerings">A collection of references to express route circuit ipv6 peerings.
        /// </param>
        public PatchRouteFilter(string id = default(string), string name = default(string), string etag = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), string provisioningState = default(string), System.Collections.Generic.IList<RouteFilterRule> rules = default(System.Collections.Generic.IList<RouteFilterRule>), System.Collections.Generic.IList<ExpressRouteCircuitPeering> peerings = default(System.Collections.Generic.IList<ExpressRouteCircuitPeering>), System.Collections.Generic.IList<ExpressRouteCircuitPeering> ipv6Peerings = default(System.Collections.Generic.IList<ExpressRouteCircuitPeering>))

        : base(id)
        {
            this.Name = name;
            this.Etag = etag;
            this.Type = type;
            this.Tags = tags;
            this.ProvisioningState = provisioningState;
            this.Rules = rules;
            this.Peerings = peerings;
            this.Ipv6Peerings = ipv6Peerings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the name of the resource that is unique within a resource group. This
        /// name can be used to access the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; private set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public System.Collections.Generic.IDictionary<string, string> Tags {get; set; }

        /// <summary>
        /// Gets the provisioning state of the route filter resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets collection of RouteFilterRules contained within a route
        /// filter.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.rules")]
        public System.Collections.Generic.IList<RouteFilterRule> Rules {get; set; }

        /// <summary>
        /// Gets a collection of references to express route circuit peerings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.peerings")]
        public System.Collections.Generic.IList<ExpressRouteCircuitPeering> Peerings {get; private set; }

        /// <summary>
        /// Gets a collection of references to express route circuit ipv6 peerings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.ipv6Peerings")]
        public System.Collections.Generic.IList<ExpressRouteCircuitPeering> Ipv6Peerings {get; private set; }
    }
}
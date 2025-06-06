// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Ssh.Helpers.Compute.Models
{
    using System.Linq;

    public partial class TerminateNotificationProfile
    {
        /// <summary>
        /// Initializes a new instance of the TerminateNotificationProfile class.
        /// </summary>
        public TerminateNotificationProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TerminateNotificationProfile class.
        /// </summary>

        /// <param name="notBeforeTimeout">Configurable length of time a Virtual Machine being deleted will have to
        /// potentially approve the Terminate Scheduled Event before the event is auto
        /// approved (timed out). The configuration must be specified in ISO 8601
        /// format, the default value is 5 minutes (PT5M)
        /// </param>

        /// <param name="enable">Specifies whether the Terminate Scheduled event is enabled or disabled.
        /// </param>
        public TerminateNotificationProfile(string notBeforeTimeout = default(string), bool? enable = default(bool?))

        {
            this.NotBeforeTimeout = notBeforeTimeout;
            this.Enable = enable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets configurable length of time a Virtual Machine being deleted
        /// will have to potentially approve the Terminate Scheduled Event before the
        /// event is auto approved (timed out). The configuration must be specified in
        /// ISO 8601 format, the default value is 5 minutes (PT5M)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "notBeforeTimeout")]
        public string NotBeforeTimeout {get; set; }

        /// <summary>
        /// Gets or sets specifies whether the Terminate Scheduled event is enabled or
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enable")]
        public bool? Enable {get; set; }
    }
}
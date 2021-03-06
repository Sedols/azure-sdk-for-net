// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details of the encryption associated with the workspace
    /// </summary>
    public partial class EncryptionDetails
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionDetails class.
        /// </summary>
        public EncryptionDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionDetails class.
        /// </summary>
        /// <param name="doubleEncryptionEnabled">Double Encryption
        /// enabled</param>
        /// <param name="cmk">Customer Managed Key Details</param>
        public EncryptionDetails(bool? doubleEncryptionEnabled = default(bool?), CustomerManagedKeyDetails cmk = default(CustomerManagedKeyDetails))
        {
            DoubleEncryptionEnabled = doubleEncryptionEnabled;
            Cmk = cmk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets double Encryption enabled
        /// </summary>
        [JsonProperty(PropertyName = "doubleEncryptionEnabled")]
        public bool? DoubleEncryptionEnabled { get; private set; }

        /// <summary>
        /// Gets or sets customer Managed Key Details
        /// </summary>
        [JsonProperty(PropertyName = "cmk")]
        public CustomerManagedKeyDetails Cmk { get; set; }

    }
}

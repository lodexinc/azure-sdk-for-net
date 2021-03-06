// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account partner filter for odata query.
    /// </summary>
    public partial class IntegrationAccountPartnerFilter
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountPartnerFilter
        /// class.
        /// </summary>
        public IntegrationAccountPartnerFilter() { }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountPartnerFilter
        /// class.
        /// </summary>
        /// <param name="partnerType">The partner type of integration account
        /// partner. Possible values include: 'NotSpecified', 'B2B'</param>
        public IntegrationAccountPartnerFilter(PartnerType partnerType)
        {
            PartnerType = partnerType;
        }

        /// <summary>
        /// Gets or sets the partner type of integration account partner.
        /// Possible values include: 'NotSpecified', 'B2B'
        /// </summary>
        [JsonProperty(PropertyName = "partnerType")]
        public PartnerType PartnerType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}


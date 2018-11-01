namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Metadata for USA addresses only. USPS deliverable and historical information.
    /// </summary>
    [DataContract]
    public class AddressEnrichV0DPV
    {
        /// <summary>
        /// For USA addresses only. USPS DPV mark to determine deliverability.
        /// </summary>
        /// <value>For USA addresses only. USPS DPV mark to determine deliverability.</value>
        [DataMember(Name="dpv_indicator", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "dpv_indicator")]
        public string DpvIndicator { get; set; }

        /// <summary>
        /// For USA addresses only. USPS mark if obsolete form of address was found.
        /// </summary>
        /// <value>For USA addresses only. USPS mark if obsolete form of address was found.</value>
        [DataMember(Name="lacs_indicator", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "lacs_indicator")]
        public string LacsIndicator { get; set; }
    }
}

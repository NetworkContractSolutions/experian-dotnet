namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// The dataset and specific attributes to be returned.
    /// </summary>
    [DataContract]
    public class PhoneEnrichV0AttributesResult
    {
        /// <summary>
        /// Enrichment data to be returned, based on the Australian Person dataset.
        /// </summary>
        /// <value>Enrichment data to be returned, based on the Australian Person dataset.</value>
        [DataMember(Name="AUS_CV_Person", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "AUS_CV_Person")]
        public PhoneEnrichV0DatasetAusCVPerson AUSCVPerson { get; set; }

        /// <summary>
        /// Enrichment data to be returned, based on the Reverse Append dataset.
        /// </summary>
        /// <value>Enrichment data to be returned, based on the Reverse Append dataset.</value>
        [DataMember(Name="Reverse_Append", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "Reverse_Append")]
        public PhoneEnrichV0DatasetReverse ReverseAppend { get; set; }
    }
}

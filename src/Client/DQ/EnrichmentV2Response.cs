namespace Experian.Api.Client.DQ
{
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// An enrichment v2 response.
    /// </summary>
    [DataContract]
    public class EnrichmentV2Response
    {
        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "referenceId")]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "transactionId")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "error")]
        public ProblemDetails Error { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name="result", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "result")]
        public EnrichmentV2Result Result { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        [JsonProperty(PropertyName = "metadata")]
        public EnrichmentV2Metadata Metadata { get; set; }
    }
}

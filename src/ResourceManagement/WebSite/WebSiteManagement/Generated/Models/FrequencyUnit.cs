// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for FrequencyUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FrequencyUnit
    {
        [EnumMember(Value = "Day")]
        Day,
        [EnumMember(Value = "Hour")]
        Hour
    }
}

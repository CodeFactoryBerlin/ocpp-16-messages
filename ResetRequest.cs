using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cfb.OCPPServer.Messages_OCPP16
{


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class ResetRequest
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ResetRequestType Type { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum ResetRequestType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Hard")]
        Hard = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Soft")]
        Soft = 1,

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cfb.OCPPServer.Messages_OCPP16
{


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UnlockConnectorResponse
    {
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UnlockConnectorResponseStatus Status { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public enum UnlockConnectorResponseStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Unlocked")]
        Unlocked = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UnlockFailed")]
        UnlockFailed = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"NotSupported")]
        NotSupported = 2
    }
}
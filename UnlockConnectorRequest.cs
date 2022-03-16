using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cfb.OCPPServer.Messages_OCPP16
{


    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.3.1.0 (Newtonsoft.Json v9.0.0.0)")]
    public partial class UnlockConnectorRequest
    {
        [Newtonsoft.Json.JsonProperty("connectorId", Required = Newtonsoft.Json.Required.Always)]
        public int ConnectorId { get; set; }
    }
}
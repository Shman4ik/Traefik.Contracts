using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Info
	{
		[JsonPropertyName("notAfter")]
		public bool notAfter { get; set; }
		
		[JsonPropertyName("notBefore")]
		public bool notBefore { get; set; }
		
		[JsonPropertyName("sans")]
		public bool sans { get; set; }
		
		[JsonPropertyName("subject")]
		public Subject subject { get; set; }
		
		[JsonPropertyName("issuer")]
		public Issuer issuer { get; set; }
		
		[JsonPropertyName("serialNumber")]
		public bool serialNumber { get; set; }
	}

}

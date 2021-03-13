using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class Info
	{
		[JsonPropertyName("notAfter")]
		public bool NotAfter { get; set; }

		[JsonPropertyName("notBefore")]
		public bool NotBefore { get; set; }

		[JsonPropertyName("sans")]
		public bool Sans { get; set; }

		[JsonPropertyName("subject")]
		public Subject Subject { get; set; }

		[JsonPropertyName("issuer")]
		public Issuer Issuer { get; set; }

		[JsonPropertyName("serialNumber")]
		public bool SerialNumber { get; set; }
	}
}
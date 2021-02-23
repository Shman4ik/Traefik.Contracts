using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Store
	{
		[JsonPropertyName("defaultCertificate")]
		public DefaultCertificate DefaultCertificate { get; set; }
	}
}
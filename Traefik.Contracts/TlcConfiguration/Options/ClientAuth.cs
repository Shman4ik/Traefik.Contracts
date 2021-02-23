using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class ClientAuth
	{
		[JsonPropertyName("caFiles")]
		public string[] CaFiles { get; set; }

		[JsonPropertyName("clientAuthType")]
		public string ClientAuthType { get; set; }
	}
}
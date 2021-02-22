using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class ClientAuth
	{
		[JsonPropertyName("caFiles")]
		public string[] caFiles { get; set; }
		[JsonPropertyName("clientAuthType")]
		public string clientAuthType { get; set; }
	}
}
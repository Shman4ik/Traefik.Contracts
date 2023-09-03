using Newtonsoft.Json;

namespace Traefik.Contracts.TlcConfiguration
{
	public class ClientAuth
	{
		[JsonProperty("caFiles")]
		public string[] CaFiles { get; set; }

		[JsonProperty("clientAuthType")]
		public string ClientAuthType { get; set; }
	}
}
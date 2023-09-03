using Newtonsoft.Json;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Certificate
	{
		[JsonProperty("certFile")]
		public string CertFile { get; set; }

		[JsonProperty("keyFile")]
		public string KeyFile { get; set; }

		[JsonProperty("stores")]
		public string[] Stores { get; set; }
	}
}
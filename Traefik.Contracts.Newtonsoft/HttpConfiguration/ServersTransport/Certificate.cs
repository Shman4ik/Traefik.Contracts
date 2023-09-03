using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Certificate
	{
		[JsonProperty("certFile")]
		public string CertFile { get; set; }

		[JsonProperty("keyFile")]
		public string KeyFile { get; set; }
	}
}
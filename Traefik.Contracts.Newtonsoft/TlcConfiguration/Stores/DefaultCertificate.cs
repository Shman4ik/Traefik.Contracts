using Newtonsoft.Json;

namespace Traefik.Contracts.TlcConfiguration
{
	public class DefaultCertificate
	{
		[JsonProperty("certFile")]
		public string CertFile { get; set; }

		[JsonProperty("keyFile")]
		public string KeyFile { get; set; }
	}
}
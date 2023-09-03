using Newtonsoft.Json;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Store
	{
		[JsonProperty("defaultCertificate")]
		public DefaultCertificate DefaultCertificate { get; set; }
	}
}
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Certificate
	{
		[JsonPropertyName("certFile")]
		public string CertFile { get; set; }

		[JsonPropertyName("keyFile")]
		public string KeyFile { get; set; }
	}

}

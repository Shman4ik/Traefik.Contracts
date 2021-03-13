using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class RedirectScheme
	{
		[JsonPropertyName("scheme")]
		public string Scheme { get; set; }

		[JsonPropertyName("port")]
		public string Port { get; set; }

		[JsonPropertyName("permanent")]
		public bool Permanent { get; set; }
	}
}
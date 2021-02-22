using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RedirectScheme
	{
		[JsonPropertyName("scheme")]
		public string scheme { get; set; }
		[JsonPropertyName("port")]
		public string port { get; set; }
		[JsonPropertyName("permanent")]
		public bool permanent { get; set; }
	}

}

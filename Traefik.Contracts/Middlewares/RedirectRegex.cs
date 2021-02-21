using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RedirectRegex
	{
		[JsonPropertyName("regex")]
		public string regex { get; set; }
		[JsonPropertyName("replacement")]
		public string replacement { get; set; }
		[JsonPropertyName("permanent")]
		public bool permanent { get; set; }
	}
}

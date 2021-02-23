using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class RedirectRegex
	{
		[JsonPropertyName("regex")]
		public string Regex { get; set; }

		[JsonPropertyName("replacement")]
		public string Replacement { get; set; }

		[JsonPropertyName("permanent")]
		public bool Permanent { get; set; }
	}
}
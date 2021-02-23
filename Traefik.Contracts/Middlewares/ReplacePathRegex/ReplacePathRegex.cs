using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ReplacePathRegex
	{
		[JsonPropertyName("regex")]
		public string Regex { get; set; }

		[JsonPropertyName("replacement")]
		public string Replacement { get; set; }
	}
}
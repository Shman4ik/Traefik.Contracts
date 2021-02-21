using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ReplacePathRegex
	{
		[JsonPropertyName("regex")]
		public string regex { get; set; }
		
		[JsonPropertyName("replacement")]
		public string replacement { get; set; }
	}
}

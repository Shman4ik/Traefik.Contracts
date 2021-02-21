using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class StripPrefix
	{
		[JsonPropertyName("prefixes")]
		public string[] prefixes { get; set; }
		
		[JsonPropertyName("forceSlash")]
		public bool forceSlash { get; set; }
	}

}

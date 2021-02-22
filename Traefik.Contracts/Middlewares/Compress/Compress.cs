using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Compress
	{
		[JsonPropertyName("excludedContentTypes")]
		public string[] ExcludedContentTypes { get; set; }
	}

}

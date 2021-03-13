using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class StripPrefix
	{
		[JsonPropertyName("prefixes")]
		public string[] Prefixes { get; set; }

		[JsonPropertyName("forceSlash")]
		public bool ForceSlash { get; set; }
	}
}
using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ContentType
	{
		[JsonPropertyName("autoDetect")]
		public bool AutoDetect { get; set; }
	}
}
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Server
	{
		[JsonPropertyName("url")]
		public string Url { get; set; }
	}
}

using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class ReplacePath
	{
		[JsonPropertyName("path")]
		public string Path { get; set; }
	}
}
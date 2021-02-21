using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class ReplacePath
	{
		[JsonPropertyName("path")]
		public string path { get; set; }
	}

}

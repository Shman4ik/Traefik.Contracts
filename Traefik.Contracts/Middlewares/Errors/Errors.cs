using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Errors
	{
		[JsonPropertyName("status")]
		public string[] Status { get; set; }

		[JsonPropertyName("service")]
		public string Service { get; set; }

		[JsonPropertyName("query")]
		public string Query { get; set; }
	}
}
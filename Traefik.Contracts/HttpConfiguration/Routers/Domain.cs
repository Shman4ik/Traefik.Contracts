using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Domain
	{
		[JsonPropertyName("main")]
		public string Main { get; set; }

		[JsonPropertyName("sans")]
		public string[] Sans { get; set; }
	}
}
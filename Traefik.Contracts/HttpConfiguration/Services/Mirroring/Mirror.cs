using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Mirror
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("percent")]
		public int Percent { get; set; }
	}
}
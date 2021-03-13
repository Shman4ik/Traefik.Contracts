using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	public class StripPrefixRegex
	{
		[JsonPropertyName("regex")]
		public string[] Regex { get; set; }
	}
}
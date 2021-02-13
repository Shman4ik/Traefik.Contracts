using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Responseforwarding
	{
		[JsonPropertyName("flushInterval")]
		public string FlushInterval { get; set; }
	}
}

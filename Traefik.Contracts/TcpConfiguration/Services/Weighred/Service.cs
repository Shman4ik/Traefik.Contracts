using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Service
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("weight")]
		public int Weight { get; set; }
	}
}
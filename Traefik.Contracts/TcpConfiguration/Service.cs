using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Service
	{
		[JsonPropertyName("name")]
		public string name { get; set; }
		[JsonPropertyName("weight")]
		public int weight { get; set; }
	}
}
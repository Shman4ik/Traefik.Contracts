using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class Weighted
	{
		[JsonPropertyName("services")]
		public Service[] Services { get; set; }
	}
}
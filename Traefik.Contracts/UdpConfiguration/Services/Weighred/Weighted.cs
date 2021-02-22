using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class Weighted
	{
		[JsonPropertyName("services")]
		public Service[] services { get; set; }
	}
}
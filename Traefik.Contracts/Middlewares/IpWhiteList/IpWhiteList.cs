using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class IpWhiteList
	{
		[JsonPropertyName("sourceRange")]
		public string[] sourceRange { get; set; }
		[JsonPropertyName("ipStrategy")]
		public IpStrategy ipStrategy { get; set; }
	}

}

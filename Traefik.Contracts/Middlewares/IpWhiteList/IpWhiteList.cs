using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class IpWhiteList
	{
		[JsonPropertyName("sourceRange")]
		public string[] SourceRange { get; set; }

		[JsonPropertyName("ipStrategy")]
		public IpStrategy IpStrategy { get; set; }
	}
}
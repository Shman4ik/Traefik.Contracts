using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Sticky
	{
		[JsonPropertyName("cookie")]
		public Cookie Cookie { get; set; }
	}

}

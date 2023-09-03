using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Sticky
	{
		[JsonProperty("cookie")]
		public Cookie Cookie { get; set; }
	}
}
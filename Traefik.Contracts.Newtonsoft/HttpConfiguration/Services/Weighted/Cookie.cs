using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Cookie
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("secure")]
		public bool Secure { get; set; }

		[JsonProperty("httpOnly")]
		public bool HttpOnly { get; set; }

		[JsonProperty("sameSite")]
		public string SameSite { get; set; }
	}
}
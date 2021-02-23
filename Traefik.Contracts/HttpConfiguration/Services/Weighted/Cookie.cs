using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Cookie
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("secure")]
		public bool Secure { get; set; }

		[JsonPropertyName("httpOnly")]
		public bool HttpOnly { get; set; }

		[JsonPropertyName("sameSite")]
		public string SameSite { get; set; }
	}
}
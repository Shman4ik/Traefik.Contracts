using System.Text.Json.Serialization;

namespace Traefik.Contracts
{
	public class BasicAuth
	{
		[JsonPropertyName("users")]
		public string[] Users { get; set; }

		[JsonPropertyName("usersFile")]
		public string UsersFile { get; set; }

		[JsonPropertyName("realm")]
		public string Realm { get; set; }

		[JsonPropertyName("removeHeader")]
		public bool RemoveHeader { get; set; }

		[JsonPropertyName("headerField")]
		public string HeaderField { get; set; }
	}

}

using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Options
	{
		[JsonPropertyName("minVersion")]
		public string minVersion { get; set; }
		
		[JsonPropertyName("maxVersion")]
		public string maxVersion { get; set; }

		[JsonPropertyName("cipherSuites")]
		public string[] cipherSuites { get; set; }

		[JsonPropertyName("curvePreferences")]
		public string[] curvePreferences { get; set; }

		[JsonPropertyName("clientAuth")]
		public ClientAuth clientAuth { get; set; }

		[JsonPropertyName("sniStrict")]
		public bool sniStrict { get; set; }

		[JsonPropertyName("preferServerCipherSuites")]
		public bool preferServerCipherSuites { get; set; }
	}
}
using System.Text.Json.Serialization;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Options
	{
		[JsonPropertyName("minVersion")]
		public string MinVersion { get; set; }

		[JsonPropertyName("maxVersion")]
		public string MaxVersion { get; set; }

		[JsonPropertyName("cipherSuites")]
		public string[] CipherSuites { get; set; }

		[JsonPropertyName("curvePreferences")]
		public string[] CurvePreferences { get; set; }

		[JsonPropertyName("clientAuth")]
		public ClientAuth ClientAuth { get; set; }

		[JsonPropertyName("sniStrict")]
		public bool SniStrict { get; set; }

		[JsonPropertyName("preferServerCipherSuites")]
		public bool PreferServerCipherSuites { get; set; }
	}
}
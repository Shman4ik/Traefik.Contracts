using Newtonsoft.Json;

namespace Traefik.Contracts.TlcConfiguration
{
	public class Options
	{
		[JsonProperty("minVersion")]
		public string MinVersion { get; set; }

		[JsonProperty("maxVersion")]
		public string MaxVersion { get; set; }

		[JsonProperty("cipherSuites")]
		public string[] CipherSuites { get; set; }

		[JsonProperty("curvePreferences")]
		public string[] CurvePreferences { get; set; }

		[JsonProperty("clientAuth")]
		public ClientAuth ClientAuth { get; set; }

		[JsonProperty("sniStrict")]
		public bool SniStrict { get; set; }

		[JsonProperty("preferServerCipherSuites")]
		public bool PreferServerCipherSuites { get; set; }
	}
}
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The info option selects the specific client certificate details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.
	/// The value of the header is an escaped concatenation of all the selected certificate details.
	/// </summary>
	public class Info
	{
		/// <summary>
		/// Set the info.notAfter option to true to add the Not After information from the Validity part.
		/// </summary>
		[JsonPropertyName("notAfter")]
		public bool NotAfter { get; set; }

		/// <summary>
		/// Set the info.notBefore option to true to add the Not Before information from the Validity part.
		/// </summary>
		[JsonPropertyName("notBefore")]
		public bool NotBefore { get; set; }

		/// <summary>
		/// Set the info.sans option to true to add the Subject Alternative Name information from the Subject Alternative Name part.
		/// </summary>
		[JsonPropertyName("sans")]
		public bool Sans { get; set; }

		/// <summary>
		/// The info.subject selects the specific client certificate subject details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.
		/// </summary>
		[JsonPropertyName("subject")]
		public Subject Subject { get; set; }

		/// <summary>
		/// The info.issuer selects the specific client certificate issuer details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.
		/// </summary>
		[JsonPropertyName("issuer")]
		public Issuer Issuer { get; set; }

		/// TODO
		[JsonPropertyName("serialNumber")]
		public bool SerialNumber { get; set; }
	}
}
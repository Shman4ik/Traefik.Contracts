using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// PassTLSClientCert adds the selected data from the passed client TLS certificate to a header.
	/// </summary>
	public class PassTLSClientCert
	{
		/// <summary>
		/// The pem option sets the X-Forwarded-Tls-Client-Cert header with the escaped certificate.
		/// In the example, it is the part between -----BEGIN CERTIFICATE----- and -----END CERTIFICATE----- delimiters:
		/// </summary>
		[JsonProperty("pem")]
		public bool Pem { get; set; }

		/// <summary>
		/// The info option selects the specific client certificate details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.
		/// The value of the header is an escaped concatenation of all the selected certificate details.
		/// </summary>
		[JsonProperty("info")]
		public Info Info { get; set; }
	}
}
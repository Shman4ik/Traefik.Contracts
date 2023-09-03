using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// PassTLSClientCert adds the selected data from the passed client TLS certificate to a header.
	/// </summary>
	public class PassTLSClientCertMiddleware : BaseMiddleware
	{
		/// <summary>
		/// PassTLSClientCert adds the selected data from the passed client TLS certificate to a header.
		/// </summary>
		[JsonProperty("passTLSClientCert")]
		public PassTLSClientCert PassTLSClientCert { get; set; }
	}
}
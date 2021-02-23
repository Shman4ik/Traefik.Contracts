using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class PassTLSClientCertMiddleware : BaseMiddleware
	{
		[JsonPropertyName("passTLSClientCert")]
		public PassTLSClientCert PassTLSClientCert { get; set; }
	}

}

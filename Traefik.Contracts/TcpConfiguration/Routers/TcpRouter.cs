namespace Traefik.Contracts.TcpConfiguration
{
	public class TcpRouter
	{
		public string[] entryPoints { get; set; }
		public string service { get; set; }
		public string rule { get; set; }
		public Tls tls { get; set; }
	}
}
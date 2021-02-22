namespace Traefik.Contracts.TcpConfiguration
{
	public class Tls
	{
		public bool passthrough { get; set; }
		public string options { get; set; }
		public string certResolver { get; set; }
		public Domain[] domains { get; set; }
	}
}
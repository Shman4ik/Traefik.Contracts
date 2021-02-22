namespace Traefik.Contracts.TcpConfiguration
{
	public class WeightedTcpService : BaseTcpService
	{
		public Weighted weighted { get; set; }
	}
}
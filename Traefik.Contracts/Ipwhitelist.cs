namespace Traefik.Contracts
{
	public class Ipwhitelist
	{
		public string[] sourceRange { get; set; }
		public Ipstrategy ipStrategy { get; set; }
	}

}

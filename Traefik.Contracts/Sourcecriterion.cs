namespace Traefik.Contracts
{
	public class Sourcecriterion
	{
		public Ipstrategy1 ipStrategy { get; set; }
		public string requestHeaderName { get; set; }
		public bool requestHost { get; set; }
	}

}

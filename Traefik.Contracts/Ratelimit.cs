namespace Traefik.Contracts
{
	public class Ratelimit
	{
		public int average { get; set; }
		public int period { get; set; }
		public int burst { get; set; }
		public Sourcecriterion1 sourceCriterion { get; set; }
	}

}

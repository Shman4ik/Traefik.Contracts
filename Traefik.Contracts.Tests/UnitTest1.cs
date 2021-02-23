using System.IO;
using System.Text.Json;
using NUnit.Framework;
using Traefik.Contracts.HttpConfiguration;
using YamlDotNet.Serialization;

namespace Traefik.Contracts.Tests
{
	public class Tests
	{
		[Test]
		public void Test1()
		{
			var exampleConfig = File.OpenText("exampleHttpOnly.json").ReadToEnd();
			var test = JsonSerializer.Deserialize<DynamicConfiguration>(exampleConfig);
			//var deserializer = new Deserializer();
			//var yamlObject = deserializer.Deserialize<DynamicConfiguration>(exapmleConfig);
			test.ToString();
			Assert.Pass();
		}

		[Test]
		public void Test2()
		{
			var exapmleConfig = File.OpenText("exampleHttpOnly.json").ReadToEnd();
			var config = new DynamicConfiguration();
			config.Http.Services.Add("Test", new LoadBalancerHttpService() { LoadBalancer = new LoadBalancer() { PassHostHeader = true } });
			var result = JsonSerializer.Serialize(config);
			result.ToString();

		}
	}
}
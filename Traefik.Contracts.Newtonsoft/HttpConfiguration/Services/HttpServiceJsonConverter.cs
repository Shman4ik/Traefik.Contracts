using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;


namespace Traefik.Contracts.HttpConfiguration
{
	public class HttpServiceJsonConverter : JsonConverter<BaseHttpService>
	{
		public override BaseHttpService ReadJson(JsonReader reader, Type objectType, BaseHttpService existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			//while (reader.Read())
			{
				//if (reader.TokenType == JsonToken.EndObject) throw new JsonException();

				//if (reader.TokenType != JsonToken.PropertyName) throw new JsonException();

				//var propertyName = reader.Value;
				JObject jo = JObject.Load(reader);
				var temp = jo.First.ToObject<LoadBalancer>(serializer);				
				return new LoadBalancerHttpService { LoadBalancer = temp };
				switch (jo["FooBarBuzz"].Value<string>())
				{
					case "loadBalancer":
						{
							//var temp = jo.ToObject<LoadBalancer>(serializer);
							//var loadBalancer = serializer.Deserialize<LoadBalancer>(reader);
							//reader.Read();
							return null;// new LoadBalancerHttpService { LoadBalancer = temp };
						}
					case "mirroring":
						{
							var mirroring = serializer.Deserialize<Mirroring>(reader);
							reader.Read();
							return new MirroringHttpService { Mirroring = mirroring };
						}
					case "weighted":
						{
							var weighted = serializer.Deserialize<Weighted>(reader);
							reader.Read();
							return new WeightedHttpService { Weighted = weighted };
						}
				}
			}

			throw new JsonException();
		}

		public override void WriteJson(JsonWriter writer, BaseHttpService value, JsonSerializer serializer)
		{
			switch (value)
			{
				case LoadBalancerHttpService loadBalancerHttpService:
					serializer.Serialize(writer, loadBalancerHttpService);
					return;
				case MirroringHttpService mirroringHttpService:
					serializer.Serialize(writer, mirroringHttpService);
					return;
				case WeightedHttpService weightedHttpService:
					serializer.Serialize(writer, weightedHttpService);
					return;
			}

			throw new JsonException($"Type {value.GetType()} unsupported to serialize.");
		}
	}
}
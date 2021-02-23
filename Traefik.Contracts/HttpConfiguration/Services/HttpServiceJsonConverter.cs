using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class HttpServiceJsonConverter : JsonConverter<BaseHttpService>
	{
		public override BaseHttpService Read(ref Utf8JsonReader reader, Type typeToConvert,
			JsonSerializerOptions options)
		{
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject) throw new JsonException();

				if (reader.TokenType != JsonTokenType.PropertyName) throw new JsonException();

				var propertyName = reader.GetString();
				switch (propertyName)
				{
					case "loadBalancer":
					{
						var loadBalancer = JsonSerializer.Deserialize<LoadBalancer>(ref reader, options);
						reader.Read();
						return new LoadBalancerHttpService {LoadBalancer = loadBalancer};
					}
					case "mirroring":
					{
						var mirroring = JsonSerializer.Deserialize<Mirroring>(ref reader, options);
						reader.Read();
						return new MirroringHttpService {Mirroring = mirroring};
					}
					case "weighted":
					{
						var weighted = JsonSerializer.Deserialize<Weighted>(ref reader, options);
						reader.Read();
						return new WeightedHttpService {Weighted = weighted};
					}
				}
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, BaseHttpService value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case LoadBalancerHttpService loadBalancerHttpService:
					JsonSerializer.Serialize(writer, loadBalancerHttpService, options);
					return;
				case MirroringHttpService mirroringHttpService:
					JsonSerializer.Serialize(writer, mirroringHttpService, options);
					return;
				case WeightedHttpService weightedHttpService:
					JsonSerializer.Serialize(writer, weightedHttpService, options);
					return;
			}

			throw new JsonException($"Type {value.GetType()} unsupported to serialize.");
		}
	}
}
// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class GeoCentroidAggregationConverter : JsonConverter<GeoCentroidAggregation>
	{
		public override GeoCentroidAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "geo_centroid")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new GeoCentroidAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("count"))
					{
						var value = JsonSerializer.Deserialize<long?>(ref reader, options);
						if (value is not null)
						{
							agg.Count = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("location"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.GeoLocation?>(ref reader, options);
						if (value is not null)
						{
							agg.Location = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("field"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Field?>(ref reader, options);
						if (value is not null)
						{
							agg.Field = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("script"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.ScriptBase?>(ref reader, options);
						if (value is not null)
						{
							agg.Script = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, GeoCentroidAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("geo_centroid");
			writer.WriteStartObject();
			if (value.Count.HasValue)
			{
				writer.WritePropertyName("count");
				writer.WriteNumberValue(value.Count.Value);
			}

			if (value.Location is not null)
			{
				writer.WritePropertyName("location");
				JsonSerializer.Serialize(writer, value.Location, options);
			}

			if (value.Field is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, value.Field, options);
			}

			if (value.Script is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, value.Script, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(GeoCentroidAggregationConverter))]
	public partial class GeoCentroidAggregation : Aggregations.MetricAggregationBase
	{
		public GeoCentroidAggregation(string name, Field field) : base(name) => Field = field;
		public GeoCentroidAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("count")]
		public long? Count { get; set; }

		[JsonInclude]
		[JsonPropertyName("location")]
		public Elastic.Clients.Elasticsearch.GeoLocation? Location { get; set; }
	}

	public sealed partial class GeoCentroidAggregationDescriptor<TDocument> : DescriptorBase<GeoCentroidAggregationDescriptor<TDocument>>
	{
		public GeoCentroidAggregationDescriptor()
		{
		}

		internal GeoCentroidAggregationDescriptor(Action<GeoCentroidAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal long? CountValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.GeoLocation? LocationValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field? FieldValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptBase? ScriptValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; private set; }

		internal Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; private set; }

		public GeoCentroidAggregationDescriptor<TDocument> Count(long? count) => Assign(count, (a, v) => a.CountValue = v);
		public GeoCentroidAggregationDescriptor<TDocument> Location(Elastic.Clients.Elasticsearch.GeoLocation? location) => Assign(location, (a, v) => a.LocationValue = v);
		public GeoCentroidAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field) => Assign(field, (a, v) => a.FieldValue = v);
		public GeoCentroidAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public GeoCentroidAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptBase? script)
		{
			ScriptDescriptor = null;
			ScriptDescriptorAction = null;
			return Assign(script, (a, v) => a.ScriptValue = v);
		}

		public GeoCentroidAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ScriptDescriptor = v);
		}

		public GeoCentroidAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
		{
			ScriptValue = null;
			ScriptDescriptorAction = null;
			return Assign(configure, (a, v) => a.ScriptDescriptorAction = v);
		}

		public GeoCentroidAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("geo_centroid");
			writer.WriteStartObject();
			if (CountValue.HasValue)
			{
				writer.WritePropertyName("count");
				writer.WriteNumberValue(CountValue.Value);
			}

			if (LocationValue is not null)
			{
				writer.WritePropertyName("location");
				JsonSerializer.Serialize(writer, LocationValue, options);
			}

			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (ScriptDescriptor is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptDescriptor, options);
			}
			else if (ScriptDescriptorAction is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
			}
			else if (ScriptValue is not null)
			{
				writer.WritePropertyName("script");
				JsonSerializer.Serialize(writer, ScriptValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
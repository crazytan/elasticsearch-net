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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl;
[JsonConverter(typeof(IntervalsConverter))]
public sealed partial class Intervals
{
	internal Intervals(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }

	internal string VariantName { get; }

	public static Intervals AllOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf intervalsAllOf) => new Intervals("all_of", intervalsAllOf);
	public static Intervals AnyOf(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf intervalsAnyOf) => new Intervals("any_of", intervalsAnyOf);
	public static Intervals Fuzzy(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy intervalsFuzzy) => new Intervals("fuzzy", intervalsFuzzy);
	public static Intervals Match(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch intervalsMatch) => new Intervals("match", intervalsMatch);
	public static Intervals Prefix(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix intervalsPrefix) => new Intervals("prefix", intervalsPrefix);
	public static Intervals Wildcard(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard intervalsWildcard) => new Intervals("wildcard", intervalsWildcard);
}

internal sealed partial class IntervalsConverter : JsonConverter<Intervals>
{
	public override Intervals Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		reader.Read();
		if (reader.TokenType != JsonTokenType.PropertyName)
		{
			throw new JsonException("Expected a property name token representing the variant held within this container.");
		}

		var propertyName = reader.GetString();
		reader.Read();
		if (propertyName == "all_of")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf?>(ref reader, options);
			reader.Read();
			return new Intervals(propertyName, variant);
		}

		if (propertyName == "any_of")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf?>(ref reader, options);
			reader.Read();
			return new Intervals(propertyName, variant);
		}

		if (propertyName == "fuzzy")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy?>(ref reader, options);
			reader.Read();
			return new Intervals(propertyName, variant);
		}

		if (propertyName == "match")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch?>(ref reader, options);
			reader.Read();
			return new Intervals(propertyName, variant);
		}

		if (propertyName == "prefix")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix?>(ref reader, options);
			reader.Read();
			return new Intervals(propertyName, variant);
		}

		if (propertyName == "wildcard")
		{
			var variant = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard?>(ref reader, options);
			reader.Read();
			return new Intervals(propertyName, variant);
		}

		throw new JsonException();
	}

	public override void Write(Utf8JsonWriter writer, Intervals value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		writer.WritePropertyName(value.VariantName);
		switch (value.VariantName)
		{
			case "all_of":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAllOf)value.Variant, options);
				break;
			case "any_of":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsAnyOf)value.Variant, options);
				break;
			case "fuzzy":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFuzzy)value.Variant, options);
				break;
			case "match":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsMatch)value.Variant, options);
				break;
			case "prefix":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsPrefix)value.Variant, options);
				break;
			case "wildcard":
				JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard>(writer, (Elastic.Clients.Elasticsearch.QueryDsl.IntervalsWildcard)value.Variant, options);
				break;
		}

		writer.WriteEndObject();
	}
}

public sealed partial class IntervalsDescriptor<TDocument> : SerializableDescriptor<IntervalsDescriptor<TDocument>>
{
	internal IntervalsDescriptor(Action<IntervalsDescriptor<TDocument>> configure) => configure.Invoke(this);
	public IntervalsDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private IntervalsDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private IntervalsDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public IntervalsDescriptor<TDocument> AllOf(IntervalsAllOf intervalsAllOf) => Set(intervalsAllOf, "all_of");
	public IntervalsDescriptor<TDocument> AllOf(Action<IntervalsAllOfDescriptor<TDocument>> configure) => Set(configure, "all_of");
	public IntervalsDescriptor<TDocument> AnyOf(IntervalsAnyOf intervalsAnyOf) => Set(intervalsAnyOf, "any_of");
	public IntervalsDescriptor<TDocument> AnyOf(Action<IntervalsAnyOfDescriptor<TDocument>> configure) => Set(configure, "any_of");
	public IntervalsDescriptor<TDocument> Fuzzy(IntervalsFuzzy intervalsFuzzy) => Set(intervalsFuzzy, "fuzzy");
	public IntervalsDescriptor<TDocument> Fuzzy(Action<IntervalsFuzzyDescriptor<TDocument>> configure) => Set(configure, "fuzzy");
	public IntervalsDescriptor<TDocument> Match(IntervalsMatch intervalsMatch) => Set(intervalsMatch, "match");
	public IntervalsDescriptor<TDocument> Match(Action<IntervalsMatchDescriptor<TDocument>> configure) => Set(configure, "match");
	public IntervalsDescriptor<TDocument> Prefix(IntervalsPrefix intervalsPrefix) => Set(intervalsPrefix, "prefix");
	public IntervalsDescriptor<TDocument> Prefix(Action<IntervalsPrefixDescriptor<TDocument>> configure) => Set(configure, "prefix");
	public IntervalsDescriptor<TDocument> Wildcard(IntervalsWildcard intervalsWildcard) => Set(intervalsWildcard, "wildcard");
	public IntervalsDescriptor<TDocument> Wildcard(Action<IntervalsWildcardDescriptor<TDocument>> configure) => Set(configure, "wildcard");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}

public sealed partial class IntervalsDescriptor : SerializableDescriptor<IntervalsDescriptor>
{
	internal IntervalsDescriptor(Action<IntervalsDescriptor> configure) => configure.Invoke(this);
	public IntervalsDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }

	private string ContainedVariantName { get; set; }

	private object Variant { get; set; }

	private Descriptor Descriptor { get; set; }

	private IntervalsDescriptor Set<T>(Action<T> descriptorAction, string variantName)
		where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private IntervalsDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public IntervalsDescriptor AllOf(IntervalsAllOf intervalsAllOf) => Set(intervalsAllOf, "all_of");
	public IntervalsDescriptor AllOf(Action<IntervalsAllOfDescriptor> configure) => Set(configure, "all_of");
	public IntervalsDescriptor AllOf<TDocument>(Action<IntervalsAllOfDescriptor<TDocument>> configure) => Set(configure, "all_of");
	public IntervalsDescriptor AnyOf(IntervalsAnyOf intervalsAnyOf) => Set(intervalsAnyOf, "any_of");
	public IntervalsDescriptor AnyOf(Action<IntervalsAnyOfDescriptor> configure) => Set(configure, "any_of");
	public IntervalsDescriptor AnyOf<TDocument>(Action<IntervalsAnyOfDescriptor<TDocument>> configure) => Set(configure, "any_of");
	public IntervalsDescriptor Fuzzy(IntervalsFuzzy intervalsFuzzy) => Set(intervalsFuzzy, "fuzzy");
	public IntervalsDescriptor Fuzzy(Action<IntervalsFuzzyDescriptor> configure) => Set(configure, "fuzzy");
	public IntervalsDescriptor Fuzzy<TDocument>(Action<IntervalsFuzzyDescriptor<TDocument>> configure) => Set(configure, "fuzzy");
	public IntervalsDescriptor Match(IntervalsMatch intervalsMatch) => Set(intervalsMatch, "match");
	public IntervalsDescriptor Match(Action<IntervalsMatchDescriptor> configure) => Set(configure, "match");
	public IntervalsDescriptor Match<TDocument>(Action<IntervalsMatchDescriptor<TDocument>> configure) => Set(configure, "match");
	public IntervalsDescriptor Prefix(IntervalsPrefix intervalsPrefix) => Set(intervalsPrefix, "prefix");
	public IntervalsDescriptor Prefix(Action<IntervalsPrefixDescriptor> configure) => Set(configure, "prefix");
	public IntervalsDescriptor Prefix<TDocument>(Action<IntervalsPrefixDescriptor<TDocument>> configure) => Set(configure, "prefix");
	public IntervalsDescriptor Wildcard(IntervalsWildcard intervalsWildcard) => Set(intervalsWildcard, "wildcard");
	public IntervalsDescriptor Wildcard(Action<IntervalsWildcardDescriptor> configure) => Set(configure, "wildcard");
	public IntervalsDescriptor Wildcard<TDocument>(Action<IntervalsWildcardDescriptor<TDocument>> configure) => Set(configure, "wildcard");
	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (!ContainsVariant)
		{
			writer.WriteNullValue();
			return;
		}

		writer.WriteStartObject();
		writer.WritePropertyName(ContainedVariantName);
		if (Variant is not null)
		{
			JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
			writer.WriteEndObject();
			return;
		}

		JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		writer.WriteEndObject();
	}
}
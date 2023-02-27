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
namespace Elastic.Clients.Elasticsearch.Mapping;
public sealed partial class DateProperty : IProperty
{
	[JsonInclude, JsonPropertyName("boost")]
	public double? Boost { get; set; }

	[JsonInclude, JsonPropertyName("copy_to")]
	public Elastic.Clients.Elasticsearch.Fields? CopyTo { get; set; }

	[JsonInclude, JsonPropertyName("doc_values")]
	public bool? DocValues { get; set; }

	[JsonInclude, JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

	[JsonInclude, JsonPropertyName("fielddata")]
	public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? Fielddata { get; set; }

	[JsonInclude, JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }

	[JsonInclude, JsonPropertyName("format")]
	public string? Format { get; set; }

	[JsonInclude, JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }

	[JsonInclude, JsonPropertyName("ignore_malformed")]
	public bool? IgnoreMalformed { get; set; }

	[JsonInclude, JsonPropertyName("index")]
	public bool? Index { get; set; }

	[JsonInclude, JsonPropertyName("locale")]
	public string? Locale { get; set; }

	[JsonInclude, JsonPropertyName("meta")]
	public IDictionary<string, string>? Meta { get; set; }

	[JsonInclude, JsonPropertyName("null_value")]
	public DateTimeOffset? NullValue { get; set; }

	[JsonInclude, JsonPropertyName("precision_step")]
	public int? PrecisionStep { get; set; }

	[JsonInclude, JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

	[JsonInclude, JsonPropertyName("similarity")]
	public string? Similarity { get; set; }

	[JsonInclude, JsonPropertyName("store")]
	public bool? Store { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "date";
}

public sealed partial class DatePropertyDescriptor<TDocument> : SerializableDescriptor<DatePropertyDescriptor<TDocument>>, IBuildableDescriptor<DateProperty>
{
	internal DatePropertyDescriptor(Action<DatePropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
	public DatePropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

	private bool? DocValuesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? FielddataValue { get; set; }

	private IndexManagement.NumericFielddataDescriptor FielddataDescriptor { get; set; }

	private Action<IndexManagement.NumericFielddataDescriptor> FielddataDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private string? FormatValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IgnoreMalformedValue { get; set; }

	private bool? IndexValue { get; set; }

	private string? LocaleValue { get; set; }

	private IDictionary<string, string>? MetaValue { get; set; }

	private DateTimeOffset? NullValueValue { get; set; }

	private int? PrecisionStepValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private string? SimilarityValue { get; set; }

	private bool? StoreValue { get; set; }

	public DatePropertyDescriptor<TDocument> Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Fielddata(Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? fielddata)
	{
		FielddataDescriptor = null;
		FielddataDescriptorAction = null;
		FielddataValue = fielddata;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Fielddata(IndexManagement.NumericFielddataDescriptor descriptor)
	{
		FielddataValue = null;
		FielddataDescriptorAction = null;
		FielddataDescriptor = descriptor;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Fielddata(Action<IndexManagement.NumericFielddataDescriptor> configure)
	{
		FielddataValue = null;
		FielddataDescriptor = null;
		FielddataDescriptorAction = configure;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public DatePropertyDescriptor<TDocument> NullValue(DateTimeOffset? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> PrecisionStep(int? precisionStep)
	{
		PrecisionStepValue = precisionStep;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public DatePropertyDescriptor<TDocument> Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FielddataDescriptor is not null)
		{
			writer.WritePropertyName("fielddata");
			JsonSerializer.Serialize(writer, FielddataDescriptor, options);
		}
		else if (FielddataDescriptorAction is not null)
		{
			writer.WritePropertyName("fielddata");
			JsonSerializer.Serialize(writer, new IndexManagement.NumericFielddataDescriptor(FielddataDescriptorAction), options);
		}
		else if (FielddataValue is not null)
		{
			writer.WritePropertyName("fielddata");
			JsonSerializer.Serialize(writer, FielddataValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IgnoreMalformedValue.HasValue)
		{
			writer.WritePropertyName("ignore_malformed");
			writer.WriteBooleanValue(IgnoreMalformedValue.Value);
		}

		if (IndexValue.HasValue)
		{
			writer.WritePropertyName("index");
			writer.WriteBooleanValue(IndexValue.Value);
		}

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (NullValueValue is not null)
		{
			writer.WritePropertyName("null_value");
			JsonSerializer.Serialize(writer, NullValueValue, options);
		}

		if (PrecisionStepValue.HasValue)
		{
			writer.WritePropertyName("precision_step");
			writer.WriteNumberValue(PrecisionStepValue.Value);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(SimilarityValue))
		{
			writer.WritePropertyName("similarity");
			writer.WriteStringValue(SimilarityValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("date");
		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? BuildFielddata()
	{
		if (FielddataValue is not null)
		{
			return FielddataValue;
		}

		if (FielddataDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata?> buildable)
		{
			return buildable.Build();
		}

		if (FielddataDescriptorAction is not null)
		{
			var descriptor = new IndexManagement.NumericFielddataDescriptor(FielddataDescriptorAction);
			if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	DateProperty IBuildableDescriptor<DateProperty>.Build() => new()
	{
		Boost = BoostValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fielddata = BuildFielddata(),
		Fields = FieldsValue,
		Format = FormatValue,
		IgnoreAbove = IgnoreAboveValue,
		IgnoreMalformed = IgnoreMalformedValue,
		Index = IndexValue,
		Locale = LocaleValue,
		Meta = MetaValue,
		NullValue = NullValueValue,
		PrecisionStep = PrecisionStepValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		Store = StoreValue
	};
}

public sealed partial class DatePropertyDescriptor : SerializableDescriptor<DatePropertyDescriptor>, IBuildableDescriptor<DateProperty>
{
	internal DatePropertyDescriptor(Action<DatePropertyDescriptor> configure) => configure.Invoke(this);
	public DatePropertyDescriptor() : base()
	{
	}

	private double? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Fields? CopyToValue { get; set; }

	private bool? DocValuesValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? FielddataValue { get; set; }

	private IndexManagement.NumericFielddataDescriptor FielddataDescriptor { get; set; }

	private Action<IndexManagement.NumericFielddataDescriptor> FielddataDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private string? FormatValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IgnoreMalformedValue { get; set; }

	private bool? IndexValue { get; set; }

	private string? LocaleValue { get; set; }

	private IDictionary<string, string>? MetaValue { get; set; }

	private DateTimeOffset? NullValueValue { get; set; }

	private int? PrecisionStepValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private string? SimilarityValue { get; set; }

	private bool? StoreValue { get; set; }

	public DatePropertyDescriptor Boost(double? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public DatePropertyDescriptor CopyTo(Elastic.Clients.Elasticsearch.Fields? copyTo)
	{
		CopyToValue = copyTo;
		return Self;
	}

	public DatePropertyDescriptor DocValues(bool? docValues = true)
	{
		DocValuesValue = docValues;
		return Self;
	}

	public DatePropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public DatePropertyDescriptor Fielddata(Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? fielddata)
	{
		FielddataDescriptor = null;
		FielddataDescriptorAction = null;
		FielddataValue = fielddata;
		return Self;
	}

	public DatePropertyDescriptor Fielddata(IndexManagement.NumericFielddataDescriptor descriptor)
	{
		FielddataValue = null;
		FielddataDescriptorAction = null;
		FielddataDescriptor = descriptor;
		return Self;
	}

	public DatePropertyDescriptor Fielddata(Action<IndexManagement.NumericFielddataDescriptor> configure)
	{
		FielddataValue = null;
		FielddataDescriptor = null;
		FielddataDescriptorAction = configure;
		return Self;
	}

	public DatePropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public DatePropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor Format(string? format)
	{
		FormatValue = format;
		return Self;
	}

	public DatePropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public DatePropertyDescriptor IgnoreMalformed(bool? ignoreMalformed = true)
	{
		IgnoreMalformedValue = ignoreMalformed;
		return Self;
	}

	public DatePropertyDescriptor Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public DatePropertyDescriptor Locale(string? locale)
	{
		LocaleValue = locale;
		return Self;
	}

	public DatePropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public DatePropertyDescriptor NullValue(DateTimeOffset? nullValue)
	{
		NullValueValue = nullValue;
		return Self;
	}

	public DatePropertyDescriptor PrecisionStep(int? precisionStep)
	{
		PrecisionStepValue = precisionStep;
		return Self;
	}

	public DatePropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public DatePropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DatePropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	public DatePropertyDescriptor Store(bool? store = true)
	{
		StoreValue = store;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (CopyToValue is not null)
		{
			writer.WritePropertyName("copy_to");
			JsonSerializer.Serialize(writer, CopyToValue, options);
		}

		if (DocValuesValue.HasValue)
		{
			writer.WritePropertyName("doc_values");
			writer.WriteBooleanValue(DocValuesValue.Value);
		}

		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FielddataDescriptor is not null)
		{
			writer.WritePropertyName("fielddata");
			JsonSerializer.Serialize(writer, FielddataDescriptor, options);
		}
		else if (FielddataDescriptorAction is not null)
		{
			writer.WritePropertyName("fielddata");
			JsonSerializer.Serialize(writer, new IndexManagement.NumericFielddataDescriptor(FielddataDescriptorAction), options);
		}
		else if (FielddataValue is not null)
		{
			writer.WritePropertyName("fielddata");
			JsonSerializer.Serialize(writer, FielddataValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (!string.IsNullOrEmpty(FormatValue))
		{
			writer.WritePropertyName("format");
			writer.WriteStringValue(FormatValue);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IgnoreMalformedValue.HasValue)
		{
			writer.WritePropertyName("ignore_malformed");
			writer.WriteBooleanValue(IgnoreMalformedValue.Value);
		}

		if (IndexValue.HasValue)
		{
			writer.WritePropertyName("index");
			writer.WriteBooleanValue(IndexValue.Value);
		}

		if (!string.IsNullOrEmpty(LocaleValue))
		{
			writer.WritePropertyName("locale");
			writer.WriteStringValue(LocaleValue);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
		}

		if (NullValueValue is not null)
		{
			writer.WritePropertyName("null_value");
			JsonSerializer.Serialize(writer, NullValueValue, options);
		}

		if (PrecisionStepValue.HasValue)
		{
			writer.WritePropertyName("precision_step");
			writer.WriteNumberValue(PrecisionStepValue.Value);
		}

		if (PropertiesValue is not null)
		{
			writer.WritePropertyName("properties");
			JsonSerializer.Serialize(writer, PropertiesValue, options);
		}

		if (!string.IsNullOrEmpty(SimilarityValue))
		{
			writer.WritePropertyName("similarity");
			writer.WriteStringValue(SimilarityValue);
		}

		if (StoreValue.HasValue)
		{
			writer.WritePropertyName("store");
			writer.WriteBooleanValue(StoreValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("date");
		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? BuildFielddata()
	{
		if (FielddataValue is not null)
		{
			return FielddataValue;
		}

		if (FielddataDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata?> buildable)
		{
			return buildable.Build();
		}

		if (FielddataDescriptorAction is not null)
		{
			var descriptor = new IndexManagement.NumericFielddataDescriptor(FielddataDescriptorAction);
			if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	DateProperty IBuildableDescriptor<DateProperty>.Build() => new()
	{
		Boost = BoostValue,
		CopyTo = CopyToValue,
		DocValues = DocValuesValue,
		Dynamic = DynamicValue,
		Fielddata = BuildFielddata(),
		Fields = FieldsValue,
		Format = FormatValue,
		IgnoreAbove = IgnoreAboveValue,
		IgnoreMalformed = IgnoreMalformedValue,
		Index = IndexValue,
		Locale = LocaleValue,
		Meta = MetaValue,
		NullValue = NullValueValue,
		PrecisionStep = PrecisionStepValue,
		Properties = PropertiesValue,
		Similarity = SimilarityValue,
		Store = StoreValue
	};
}
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
public sealed partial class DenseVectorProperty : IProperty
{
	[JsonInclude]
	[JsonPropertyName("dims")]
	public int Dims { get; set; }

	[JsonInclude]
	[JsonPropertyName("dynamic")]
	public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

	[JsonInclude]
	[JsonPropertyName("fields")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Fields { get; set; }

	[JsonInclude]
	[JsonPropertyName("ignore_above")]
	public int? IgnoreAbove { get; set; }

	[JsonInclude]
	[JsonPropertyName("index")]
	public bool? Index { get; set; }

	[JsonInclude]
	[JsonPropertyName("index_options")]
	public Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? IndexOptions { get; set; }

	[JsonInclude]
	[JsonPropertyName("local_metadata")]
	public Dictionary<string, object>? LocalMetadata { get; set; }

	[JsonInclude]
	[JsonPropertyName("meta")]
	public Dictionary<string, string>? Meta { get; set; }

	[JsonInclude]
	[JsonPropertyName("properties")]
	public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

	[JsonInclude]
	[JsonPropertyName("similarity")]
	public string? Similarity { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "dense_vector";
}

public sealed partial class DenseVectorPropertyDescriptor<TDocument> : SerializableDescriptor<DenseVectorPropertyDescriptor<TDocument>>, IBuildableDescriptor<DenseVectorProperty>
{
	internal DenseVectorPropertyDescriptor(Action<DenseVectorPropertyDescriptor<TDocument>> configure) => configure.Invoke(this);
	public DenseVectorPropertyDescriptor() : base()
	{
	}

	private int DimsValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IndexValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? IndexOptionsValue { get; set; }

	private DenseVectorIndexOptionsDescriptor IndexOptionsDescriptor { get; set; }

	private Action<DenseVectorIndexOptionsDescriptor> IndexOptionsDescriptorAction { get; set; }

	private Dictionary<string, object>? LocalMetadataValue { get; set; }

	private Dictionary<string, string>? MetaValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private string? SimilarityValue { get; set; }

	public DenseVectorPropertyDescriptor<TDocument> Dims(int dims)
	{
		DimsValue = dims;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Fields(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Fields(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> IndexOptions(Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? indexOptions)
	{
		IndexOptionsDescriptor = null;
		IndexOptionsDescriptorAction = null;
		IndexOptionsValue = indexOptions;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> IndexOptions(DenseVectorIndexOptionsDescriptor descriptor)
	{
		IndexOptionsValue = null;
		IndexOptionsDescriptorAction = null;
		IndexOptionsDescriptor = descriptor;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> IndexOptions(Action<DenseVectorIndexOptionsDescriptor> configure)
	{
		IndexOptionsValue = null;
		IndexOptionsDescriptor = null;
		IndexOptionsDescriptorAction = configure;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Properties(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Properties(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor<TDocument> Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("dims");
		writer.WriteNumberValue(DimsValue);
		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IndexValue.HasValue)
		{
			writer.WritePropertyName("index");
			writer.WriteBooleanValue(IndexValue.Value);
		}

		if (IndexOptionsDescriptor is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsDescriptor, options);
		}
		else if (IndexOptionsDescriptorAction is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, new DenseVectorIndexOptionsDescriptor(IndexOptionsDescriptorAction), options);
		}
		else if (IndexOptionsValue is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsValue, options);
		}

		if (LocalMetadataValue is not null)
		{
			writer.WritePropertyName("local_metadata");
			JsonSerializer.Serialize(writer, LocalMetadataValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
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

		writer.WritePropertyName("type");
		writer.WriteStringValue("dense_vector");
		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? BuildIndexOptions()
	{
		if (IndexOptionsValue is not null)
		{
			return IndexOptionsValue;
		}

		if (IndexOptionsDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions?> buildable)
		{
			return buildable.Build();
		}

		if (IndexOptionsDescriptorAction is not null)
		{
			var descriptor = new DenseVectorIndexOptionsDescriptor(IndexOptionsDescriptorAction);
			if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	DenseVectorProperty IBuildableDescriptor<DenseVectorProperty>.Build() => new()
	{ Dims = DimsValue, Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, Index = IndexValue, IndexOptions = BuildIndexOptions(), LocalMetadata = LocalMetadataValue, Meta = MetaValue, Properties = PropertiesValue, Similarity = SimilarityValue };
}

public sealed partial class DenseVectorPropertyDescriptor : SerializableDescriptor<DenseVectorPropertyDescriptor>, IBuildableDescriptor<DenseVectorProperty>
{
	internal DenseVectorPropertyDescriptor(Action<DenseVectorPropertyDescriptor> configure) => configure.Invoke(this);
	public DenseVectorPropertyDescriptor() : base()
	{
	}

	private int DimsValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? FieldsValue { get; set; }

	private int? IgnoreAboveValue { get; set; }

	private bool? IndexValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? IndexOptionsValue { get; set; }

	private DenseVectorIndexOptionsDescriptor IndexOptionsDescriptor { get; set; }

	private Action<DenseVectorIndexOptionsDescriptor> IndexOptionsDescriptorAction { get; set; }

	private Dictionary<string, object>? LocalMetadataValue { get; set; }

	private Dictionary<string, string>? MetaValue { get; set; }

	private Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; set; }

	private string? SimilarityValue { get; set; }

	public DenseVectorPropertyDescriptor Dims(int dims)
	{
		DimsValue = dims;
		return Self;
	}

	public DenseVectorPropertyDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic)
	{
		DynamicValue = dynamic;
		return Self;
	}

	public DenseVectorPropertyDescriptor Fields(Elastic.Clients.Elasticsearch.Mapping.Properties? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	public DenseVectorPropertyDescriptor Fields<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor Fields<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		FieldsValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor IgnoreAbove(int? ignoreAbove)
	{
		IgnoreAboveValue = ignoreAbove;
		return Self;
	}

	public DenseVectorPropertyDescriptor Index(bool? index = true)
	{
		IndexValue = index;
		return Self;
	}

	public DenseVectorPropertyDescriptor IndexOptions(Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? indexOptions)
	{
		IndexOptionsDescriptor = null;
		IndexOptionsDescriptorAction = null;
		IndexOptionsValue = indexOptions;
		return Self;
	}

	public DenseVectorPropertyDescriptor IndexOptions(DenseVectorIndexOptionsDescriptor descriptor)
	{
		IndexOptionsValue = null;
		IndexOptionsDescriptorAction = null;
		IndexOptionsDescriptor = descriptor;
		return Self;
	}

	public DenseVectorPropertyDescriptor IndexOptions(Action<DenseVectorIndexOptionsDescriptor> configure)
	{
		IndexOptionsValue = null;
		IndexOptionsDescriptor = null;
		IndexOptionsDescriptorAction = configure;
		return Self;
	}

	public DenseVectorPropertyDescriptor LocalMetadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		LocalMetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	public DenseVectorPropertyDescriptor Meta(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		MetaValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	public DenseVectorPropertyDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties)
	{
		PropertiesValue = properties;
		return Self;
	}

	public DenseVectorPropertyDescriptor Properties<TDocument>(PropertiesDescriptor<TDocument> descriptor)
	{
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor Properties<TDocument>(Action<PropertiesDescriptor<TDocument>> configure)
	{
		var descriptor = new PropertiesDescriptor<TDocument>();
		configure?.Invoke(descriptor);
		PropertiesValue = descriptor.PromisedValue;
		return Self;
	}

	public DenseVectorPropertyDescriptor Similarity(string? similarity)
	{
		SimilarityValue = similarity;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("dims");
		writer.WriteNumberValue(DimsValue);
		if (DynamicValue is not null)
		{
			writer.WritePropertyName("dynamic");
			JsonSerializer.Serialize(writer, DynamicValue, options);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (IgnoreAboveValue.HasValue)
		{
			writer.WritePropertyName("ignore_above");
			writer.WriteNumberValue(IgnoreAboveValue.Value);
		}

		if (IndexValue.HasValue)
		{
			writer.WritePropertyName("index");
			writer.WriteBooleanValue(IndexValue.Value);
		}

		if (IndexOptionsDescriptor is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsDescriptor, options);
		}
		else if (IndexOptionsDescriptorAction is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, new DenseVectorIndexOptionsDescriptor(IndexOptionsDescriptorAction), options);
		}
		else if (IndexOptionsValue is not null)
		{
			writer.WritePropertyName("index_options");
			JsonSerializer.Serialize(writer, IndexOptionsValue, options);
		}

		if (LocalMetadataValue is not null)
		{
			writer.WritePropertyName("local_metadata");
			JsonSerializer.Serialize(writer, LocalMetadataValue, options);
		}

		if (MetaValue is not null)
		{
			writer.WritePropertyName("meta");
			JsonSerializer.Serialize(writer, MetaValue, options);
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

		writer.WritePropertyName("type");
		writer.WriteStringValue("dense_vector");
		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions? BuildIndexOptions()
	{
		if (IndexOptionsValue is not null)
		{
			return IndexOptionsValue;
		}

		if (IndexOptionsDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions?> buildable)
		{
			return buildable.Build();
		}

		if (IndexOptionsDescriptorAction is not null)
		{
			var descriptor = new DenseVectorIndexOptionsDescriptor(IndexOptionsDescriptorAction);
			if (descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Mapping.DenseVectorIndexOptions?> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	DenseVectorProperty IBuildableDescriptor<DenseVectorProperty>.Build() => new()
	{ Dims = DimsValue, Dynamic = DynamicValue, Fields = FieldsValue, IgnoreAbove = IgnoreAboveValue, Index = IndexValue, IndexOptions = BuildIndexOptions(), LocalMetadata = LocalMetadataValue, Meta = MetaValue, Properties = PropertiesValue, Similarity = SimilarityValue };
}
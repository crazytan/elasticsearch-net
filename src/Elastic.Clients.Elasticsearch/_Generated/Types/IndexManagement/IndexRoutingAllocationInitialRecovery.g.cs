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
namespace Elastic.Clients.Elasticsearch.IndexManagement;
public sealed partial class IndexRoutingAllocationInitialRecovery
{
	[JsonInclude]
	[JsonPropertyName("_id")]
	public Elastic.Clients.Elasticsearch.Id? Id { get; set; }
}

public sealed partial class IndexRoutingAllocationInitialRecoveryDescriptor : SerializableDescriptor<IndexRoutingAllocationInitialRecoveryDescriptor>
{
	internal IndexRoutingAllocationInitialRecoveryDescriptor(Action<IndexRoutingAllocationInitialRecoveryDescriptor> configure) => configure.Invoke(this);
	public IndexRoutingAllocationInitialRecoveryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id? IdValue { get; set; }

	public IndexRoutingAllocationInitialRecoveryDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		IdValue = id;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IdValue is not null)
		{
			writer.WritePropertyName("_id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		writer.WriteEndObject();
	}
}
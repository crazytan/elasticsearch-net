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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class DataStreamsStatsItem
	{
		[JsonInclude]
		[JsonPropertyName("backing_indices")]
		public int BackingIndices { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_stream")]
		public string DataStream { get; init; }

		[JsonInclude]
		[JsonPropertyName("maximum_timestamp")]
		public long MaximumTimestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("store_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? StoreSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("store_size_bytes")]
		public int StoreSizeBytes { get; init; }
	}
}
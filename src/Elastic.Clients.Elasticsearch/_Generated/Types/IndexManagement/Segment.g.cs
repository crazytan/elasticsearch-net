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
	public sealed partial class Segment
	{
		[JsonInclude]
		[JsonPropertyName("attributes")]
		public Dictionary<string, string> Attributes { get; init; }

		[JsonInclude]
		[JsonPropertyName("committed")]
		public bool Committed { get; init; }

		[JsonInclude]
		[JsonPropertyName("compound")]
		public bool Compound { get; init; }

		[JsonInclude]
		[JsonPropertyName("deleted_docs")]
		public long DeletedDocs { get; init; }

		[JsonInclude]
		[JsonPropertyName("generation")]
		public int Generation { get; init; }

		[JsonInclude]
		[JsonPropertyName("memory_in_bytes")]
		public double MemoryInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("num_docs")]
		public long NumDocs { get; init; }

		[JsonInclude]
		[JsonPropertyName("search")]
		public bool Search { get; init; }

		[JsonInclude]
		[JsonPropertyName("size_in_bytes")]
		public double SizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public string Version { get; init; }
	}
}
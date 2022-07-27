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
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public sealed partial class DataTiers
	{
		[JsonInclude]
		[JsonPropertyName("available")]
		public bool Available { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_cold")]
		public Elastic.Clients.Elasticsearch.Xpack.DataTierPhaseStatistics DataCold { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_content")]
		public Elastic.Clients.Elasticsearch.Xpack.DataTierPhaseStatistics DataContent { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_frozen")]
		public Elastic.Clients.Elasticsearch.Xpack.DataTierPhaseStatistics? DataFrozen { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_hot")]
		public Elastic.Clients.Elasticsearch.Xpack.DataTierPhaseStatistics DataHot { get; init; }

		[JsonInclude]
		[JsonPropertyName("data_warm")]
		public Elastic.Clients.Elasticsearch.Xpack.DataTierPhaseStatistics DataWarm { get; init; }

		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; init; }
	}
}
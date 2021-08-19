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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport.Products.Elasticsearch.Failures;
using OneOf;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.AsyncSearch
{
	public partial class AsyncSearch<TDocument>
	{
		[JsonPropertyName("aggregations")]
		public Dictionary<string, Nest.Aggregations.Aggregate>? Aggregations
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_clusters")]
		public Nest.ClusterStatistics? Clusters
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("fields")]
		public Dictionary<string, object>? Fields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("hits")]
		public Nest.Global.Search.HitsMetadata<TDocument> Hits
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("max_score")]
		public double? MaxScore
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("num_reduce_phases")]
		public long? NumReducePhases
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("pit_id")]
		public Nest.Id? PitId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("profile")]
		public Nest.Global.Search.Profile? Profile
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_scroll_id")]
		public Nest.Id? ScrollId
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("_shards")]
		public Nest.ShardStatistics Shards
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("suggest")]
		public Dictionary<Nest.SuggestionName, IReadOnlyCollection<Nest.Global.Search.Suggest<TDocument>>>? Suggest
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("terminated_early")]
		public bool? TerminatedEarly
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("timed_out")]
		public bool TimedOut
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("took")]
		public long Took
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}
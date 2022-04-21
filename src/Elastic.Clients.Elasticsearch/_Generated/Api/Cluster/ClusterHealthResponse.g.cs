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

using Elastic.Transport.Products.Elasticsearch;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public sealed partial class ClusterHealthResponse : ElasticsearchResponseBase
	{
		[JsonInclude]
		[JsonPropertyName("active_primary_shards")]
		public int ActivePrimaryShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("active_shards")]
		public int ActiveShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("active_shards_percent_as_number")]
		public double ActiveShardsPercentAsNumber { get; init; }

		[JsonInclude]
		[JsonPropertyName("cluster_name")]
		public string ClusterName { get; init; }

		[JsonInclude]
		[JsonPropertyName("delayed_unassigned_shards")]
		public int DelayedUnassignedShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.ReadOnlyIndexNameDictionary<Elastic.Clients.Elasticsearch.Cluster.IndexHealthStats>? Indices { get; init; }

		[JsonInclude]
		[JsonPropertyName("initializing_shards")]
		public int InitializingShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_data_nodes")]
		public int NumberOfDataNodes { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_in_flight_fetch")]
		public int NumberOfInFlightFetch { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_nodes")]
		public int NumberOfNodes { get; init; }

		[JsonInclude]
		[JsonPropertyName("number_of_pending_tasks")]
		public int NumberOfPendingTasks { get; init; }

		[JsonInclude]
		[JsonPropertyName("relocating_shards")]
		public int RelocatingShards { get; init; }

		[JsonInclude]
		[JsonPropertyName("status")]
		public Elastic.Clients.Elasticsearch.HealthStatus Status { get; init; }

		[JsonInclude]
		[JsonPropertyName("task_max_waiting_in_queue_millis")]
		public Elastic.Clients.Elasticsearch.EpochMillis TaskMaxWaitingInQueueMillis { get; init; }

		[JsonInclude]
		[JsonPropertyName("timed_out")]
		public bool TimedOut { get; init; }

		[JsonInclude]
		[JsonPropertyName("unassigned_shards")]
		public int UnassignedShards { get; init; }
	}
}
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
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed partial class DataCounts
	{
		[JsonInclude]
		[JsonPropertyName("bucket_count")]
		public long BucketCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("earliest_record_timestamp")]
		public long? EarliestRecordTimestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("empty_bucket_count")]
		public long EmptyBucketCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("input_bytes")]
		public long InputBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("input_field_count")]
		public long InputFieldCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("input_record_count")]
		public long InputRecordCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("invalid_date_count")]
		public long InvalidDateCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("job_id")]
		public string JobId { get; init; }

		[JsonInclude]
		[JsonPropertyName("last_data_time")]
		public long? LastDataTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("latest_bucket_timestamp")]
		public long? LatestBucketTimestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("latest_empty_bucket_timestamp")]
		public long? LatestEmptyBucketTimestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("latest_record_timestamp")]
		public long? LatestRecordTimestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("latest_sparse_bucket_timestamp")]
		public long? LatestSparseBucketTimestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("log_time")]
		public long? LogTime { get; init; }

		[JsonInclude]
		[JsonPropertyName("missing_field_count")]
		public long MissingFieldCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("out_of_order_timestamp_count")]
		public long OutOfOrderTimestampCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("processed_field_count")]
		public long ProcessedFieldCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("processed_record_count")]
		public long ProcessedRecordCount { get; init; }

		[JsonInclude]
		[JsonPropertyName("sparse_bucket_count")]
		public long SparseBucketCount { get; init; }
	}
}
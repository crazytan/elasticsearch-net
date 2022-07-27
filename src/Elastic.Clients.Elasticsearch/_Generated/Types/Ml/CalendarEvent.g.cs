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
	public sealed partial class CalendarEvent
	{
		[JsonInclude]
		[JsonPropertyName("calendar_id")]
		public Elastic.Clients.Elasticsearch.Id? CalendarId { get; set; }

		[JsonInclude]
		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonInclude]
		[JsonPropertyName("end_time")]
		public DateTimeOffset EndTime { get; set; }

		[JsonInclude]
		[JsonPropertyName("event_id")]
		public Elastic.Clients.Elasticsearch.Id? EventId { get; set; }

		[JsonInclude]
		[JsonPropertyName("start_time")]
		public DateTimeOffset StartTime { get; set; }
	}

	public sealed partial class CalendarEventDescriptor : SerializableDescriptorBase<CalendarEventDescriptor>
	{
		internal CalendarEventDescriptor(Action<CalendarEventDescriptor> configure) => configure.Invoke(this);
		public CalendarEventDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Id? CalendarIdValue { get; set; }

		private string DescriptionValue { get; set; }

		private DateTimeOffset EndTimeValue { get; set; }

		private Elastic.Clients.Elasticsearch.Id? EventIdValue { get; set; }

		private DateTimeOffset StartTimeValue { get; set; }

		public CalendarEventDescriptor CalendarId(Elastic.Clients.Elasticsearch.Id? calendarId)
		{
			CalendarIdValue = calendarId;
			return Self;
		}

		public CalendarEventDescriptor Description(string description)
		{
			DescriptionValue = description;
			return Self;
		}

		public CalendarEventDescriptor EndTime(DateTimeOffset endTime)
		{
			EndTimeValue = endTime;
			return Self;
		}

		public CalendarEventDescriptor EventId(Elastic.Clients.Elasticsearch.Id? eventId)
		{
			EventIdValue = eventId;
			return Self;
		}

		public CalendarEventDescriptor StartTime(DateTimeOffset startTime)
		{
			StartTimeValue = startTime;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CalendarIdValue is not null)
			{
				writer.WritePropertyName("calendar_id");
				JsonSerializer.Serialize(writer, CalendarIdValue, options);
			}

			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
			writer.WritePropertyName("end_time");
			JsonSerializer.Serialize(writer, EndTimeValue, options);
			if (EventIdValue is not null)
			{
				writer.WritePropertyName("event_id");
				JsonSerializer.Serialize(writer, EventIdValue, options);
			}

			writer.WritePropertyName("start_time");
			JsonSerializer.Serialize(writer, StartTimeValue, options);
			writer.WriteEndObject();
		}
	}
}
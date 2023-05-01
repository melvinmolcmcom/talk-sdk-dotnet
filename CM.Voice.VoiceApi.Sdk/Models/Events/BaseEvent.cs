using System;
using System.Text.Json.Serialization;

namespace CM.Voice.VoiceApi.Sdk.Models.Events;

public abstract record BaseEvent
{
    /// <summary>
    /// The type of event.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Type => EventType;

    /// <summary>
    /// The ID of the call this event belongs to.
    /// </summary>
    [JsonPropertyName("call-id")]
    public Guid CallId { get; init; }

    /// <summary>
    /// The ID of the instruction the event is a result of.
    /// </summary>
    [JsonPropertyName("instruction-id")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string InstructionId { get; init; }

    /// <summary>
    /// The event type of the event, used for parsing.
    /// </summary>
    protected abstract string EventType { get; }
}
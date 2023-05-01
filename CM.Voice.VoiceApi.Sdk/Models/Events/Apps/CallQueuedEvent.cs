﻿using Newtonsoft.Json;

namespace CM.Voice.VoiceApi.Sdk.Models.Events.Apps;

/// <summary>
/// Event that is a result (basically a direct response) to the PlaceCallInstruction.
/// This one is generally used in the async versions of the calls.
/// </summary>
public record CallQueuedEvent : BaseEvent
{
    /// <inheritdoc/>
    protected override string EventType => "call-queued";

    /// <summary>
    /// The id (e.g. number) of the caller.
    /// </summary>
    [JsonProperty("caller", Order = 4)]
    public string Caller { get; init; }

    /// <summary>
    /// The id (e.g. number) of the callee.
    /// </summary>
    [JsonProperty("callee", Order = 5)]
    public string Callee { get; init; }

    /// <summary>
    /// True iff the PlaceCallInstruction was accepted.
    /// </summary>
    [JsonProperty("success", Order = 6)]
    public bool Success { get; init; }

    /// <summary>
    /// True iff the PlaceCallInstruction was accepted.
    /// </summary>
    [JsonProperty("error", Order = 6, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore)]
    public string Error { get; init; }
}
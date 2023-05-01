using System.Text.Json.Serialization;

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
    [JsonPropertyName("caller")]
    public string Caller { get; init; }

    /// <summary>
    /// The id (e.g. number) of the callee.
    /// </summary>
    [JsonPropertyName("callee")]
    public string Callee { get; init; }

    /// <summary>
    /// True iff the PlaceCallInstruction was accepted.
    /// </summary>
    [JsonPropertyName("success")]
    public bool Success { get; init; }

    /// <summary>
    /// True iff the PlaceCallInstruction was accepted.
    /// </summary>
    [JsonPropertyName("error")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Error { get; init; }
}
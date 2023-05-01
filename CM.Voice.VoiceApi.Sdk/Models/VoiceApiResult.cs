using CM.Voice.VoiceApi.Sdk.Models.Events;
using System.Net;
using System.Text.Json;

namespace CM.Voice.VoiceApi.Sdk.Models;

public record VoiceApiResult<TEvent> where TEvent : BaseEvent
{
    public HttpStatusCode HttpStatusCode { get; init; }

    public bool Success { get; init; }

    public string Content { get; init; }

    public TEvent DeserializeEvent()
        => JsonSerializer.Deserialize<TEvent>(Content);
}
using System.Text.Json.Serialization;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <summary>
/// Base class for all the initiate outbound call instructions.
/// </summary>
public abstract record BaseAppInstruction
{
    /// <summary>
    /// The ID of the instruction.
    /// </summary>
    [JsonPropertyName("instruction-id")]
    public string InstructionId { get; init; }

    /// <summary>
    /// The number to dial.
    /// </summary>
    [JsonPropertyName("callee")]
    public string Callee { get; init; }

    /// <summary>
    /// The numbers to dial.
    /// </summary>
    [JsonPropertyName("callees")]
    public string[] Callees { get; init; }

    /// <summary>
    /// The caller id to show on the end user's phone.
    /// </summary>
    [JsonPropertyName("caller")]
    public string Caller { get; init; }

    /// <summary>
    /// The caller id is hidden iff anonymous = true.
    /// </summary>
    [JsonPropertyName("anonymous")]
    public bool Anonymous { get; init; }

    /// <summary>
    /// Iff true, the request is not rejected if (any of) the callees are invalid.
    /// Please note that the invalid callees are not dialed, but the valid ones are.
    /// </summary>
    [JsonPropertyName("disable-callees-validation")]
    public bool DisableCalleesValidation { get; init; }
        
    /// <summary>
    /// Iff true, the tts or stt voice has a higher quality and supports more languages.
    /// Please note that premium voices are more expensive.
    /// </summary>
    [JsonPropertyName("premium")]
    public bool? Premium { get; init; } = false;

    /// <summary>
    /// Information on the voice to use if (any of) the prompt(s) is of type tts.
    /// </summary>
    [JsonPropertyName("voice")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Voice? Voice { get; init; } = new();

    /// <summary>
    /// The url to send the POST command to for further VoiceAPI flow.
    /// </summary>
    [JsonPropertyName("callback-url")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? CallbackUrl { get; init; }
}
using Newtonsoft.Json;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <summary>
/// Base class for all the initiate outbound call instructions.
/// </summary>
public abstract record BaseAppInstruction
{
    /// <summary>
    /// The ID of the instruction.
    /// </summary>
    [JsonProperty("instruction-id", Order = 3)]
    public string InstructionId { get; init; }

    /// <summary>
    /// The number to dial.
    /// </summary>
    [JsonProperty("callee", Order = 4)]
    public string Callee { get; init; }

    /// <summary>
    /// The numbers to dial.
    /// </summary>
    [JsonProperty("callees", Order = 4)]
    public string[] Callees { get; init; }

    /// <summary>
    /// The caller id to show on the end user's phone.
    /// </summary>
    [JsonProperty("caller", Order = 5)]
    public string Caller { get; init; }

    /// <summary>
    /// The caller id is hidden iff anonymous = true.
    /// </summary>
    [JsonProperty("anonymous", Order = 6)]
    public bool Anonymous { get; init; }

    /// <summary>
    /// Iff true, the request is not rejected if (any of) the callees are invalid.
    /// Please note that the invalid callees are not dialed, but the valid ones are.
    /// </summary>
    [JsonProperty("disable-callees-validation", Order = 7)]
    public bool DisableCalleesValidation { get; init; }

    /// <summary>
    /// Information on the voice to use if (any of) the prompt(s) is of type tts.
    /// </summary>
    [JsonProperty("voice", Order = 99, NullValueHandling = NullValueHandling.Ignore)]
    public Voice Voice { get; init; } = new();

    /// <summary>
    /// The url to send the POST command to for further VoiceAPI flow.
    /// </summary>
    [JsonProperty("callback-url", Order = 100, NullValueHandling = NullValueHandling.Ignore)]
    public string CallbackUrl { get; init; }
}
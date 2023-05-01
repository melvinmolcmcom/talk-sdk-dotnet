using Newtonsoft.Json;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <inheritdoc />
/// <summary>
/// Instruction to place a call and request DTMF from the callee.
/// </summary>
public record RequestDtmfInstruction : BaseAppInstruction
{
    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("prompt", Order = 7, NullValueHandling = NullValueHandling.Ignore)]
    public string Prompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("prompt-type", Order = 8, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? PromptType { get; init; } = Models.PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("valid-prompt", Order = 9, NullValueHandling = NullValueHandling.Ignore)]
    public string ValidPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("valid-prompt-type", Order = 10, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? ValidPromptType { get; init; } = Models.PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("invalid-prompt", Order = 11, NullValueHandling = NullValueHandling.Ignore)]
    public string InvalidPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("invalid-prompt-type", Order = 12, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? InvalidPromptType { get; init; } = Models.PromptType.TTS;

    /// <summary>
    /// The minimum number of digits for the dtmf input
    /// </summary>
    [JsonProperty("min-digits", Order = 13, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinDigits { get; init; }

    /// <summary>
    /// The maximum number of digits for the dtmf input
    /// </summary>
    [JsonProperty("max-digits", Order = 14, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxDigits { get; init; }

    /// <summary>
    /// The maximum number of attempts to input valid dtmf.
    /// </summary>
    [JsonProperty("max-attempts", Order = 15, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxAttempts { get; init; }

    /// <summary>
    /// The max timeout for pressing a button.
    /// </summary>
    [JsonProperty("timeout", Order = 16, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeOut { get; init; }

    /// <summary>
    /// The keys that will end dtmf input.
    /// </summary>
    [JsonProperty("terminators", Order = 17, NullValueHandling = NullValueHandling.Ignore)]
    public string Terminators { get; init; }

    /// <summary>
    /// The match to use for validating the input.
    /// </summary>
    [JsonProperty("regex", Order = 18, NullValueHandling = NullValueHandling.Ignore)]
    public string DigitsRegex { get; init; }
}
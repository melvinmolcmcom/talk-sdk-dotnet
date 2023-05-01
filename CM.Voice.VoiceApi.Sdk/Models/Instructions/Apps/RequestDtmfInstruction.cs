using System.Text.Json.Serialization;

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
    [JsonPropertyName("prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Prompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? PromptType { get; init; } = Models.PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("valid-prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ValidPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("valid-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? ValidPromptType { get; init; } = Models.PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("invalid-prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string InvalidPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("invalid-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? InvalidPromptType { get; init; } = Models.PromptType.TTS;

    /// <summary>
    /// The minimum number of digits for the dtmf input
    /// </summary>
    [JsonPropertyName("min-digits")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MinDigits { get; init; }

    /// <summary>
    /// The maximum number of digits for the dtmf input
    /// </summary>
    [JsonPropertyName("max-digits")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxDigits { get; init; }

    /// <summary>
    /// The maximum number of attempts to input valid dtmf.
    /// </summary>
    [JsonPropertyName("max-attempts")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxAttempts { get; init; }

    /// <summary>
    /// The max timeout for pressing a button.
    /// </summary>
    [JsonPropertyName("timeout")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? TimeOut { get; init; }

    /// <summary>
    /// The keys that will end dtmf input.
    /// </summary>
    [JsonPropertyName("terminators")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Terminators { get; init; }

    /// <summary>
    /// The match to use for validating the input.
    /// </summary>
    [JsonPropertyName("regex")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string DigitsRegex { get; init; }
}
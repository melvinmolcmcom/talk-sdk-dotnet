using System.Text.Json.Serialization;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <summary>
/// Instruction to send a One Time Password (OTP) to the callee.
/// </summary>
public record OtpInstruction : BaseAppInstruction
{
    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("intro-prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? IntroPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("intro-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? IntroPromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("code-prompt")]
    public string CodePrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("code-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? CodePromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The OTP code.
    /// </summary>
    [JsonPropertyName("code")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Code { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("code-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public CodeType? CodeType { get; init; } = Models.CodeType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("replay-prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ReplayPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("replay-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? ReplayPromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("outro-prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? OutroPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("outro-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? OutroPromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The number of times the code can be played. Min = 1, Max = 3.
    /// </summary>
    [JsonPropertyName("max-replays")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? MaxReplays { get; init; }

    /// <summary>
    /// The code-prompt and code will replay automatically repeat if true, it will wait for a press on the "1" otherwise.
    /// </summary>
    [JsonPropertyName("auto-replay")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? AutoReplay { get; init; }

    /// <summary>
    /// Determines the Voicemail detection flow.
    /// </summary>
    [JsonPropertyName("voicemail-response")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public VoicemailResponse VoicemailResponse { get; init; } = VoicemailResponse.Ignore;
}
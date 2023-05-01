using Newtonsoft.Json;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <summary>
/// Instruction to send a One Time Password (OTP) to the callee.
/// </summary>
public record OtpInstruction : BaseAppInstruction
{
    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("intro-prompt", Order = 7, NullValueHandling = NullValueHandling.Ignore)]
    public string IntroPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("intro-prompt-type", Order = 8, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? IntroPromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("code-prompt", Order = 9, NullValueHandling = NullValueHandling.Ignore)]
    public string CodePrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("code-prompt-type", Order = 10, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? CodePromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The OTP code.
    /// </summary>
    [JsonProperty("code", Order = 11, NullValueHandling = NullValueHandling.Ignore)]
    public string Code { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("code-type", Order = 12, NullValueHandling = NullValueHandling.Ignore)]
    public CodeType? CodeType { get; init; } = Models.CodeType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("replay-prompt", Order = 13, NullValueHandling = NullValueHandling.Ignore)]
    public string ReplayPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("replay-prompt-type", Order = 14, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? ReplayPromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("outro-prompt", Order = 15, NullValueHandling = NullValueHandling.Ignore)]
    public string OutroPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("outro-prompt-type", Order = 16, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? OutroPromptType { get; init; } = PromptType.TTS;

    /// <summary>
    /// The number of times the code can be played. Min = 1, Max = 3.
    /// </summary>
    [JsonProperty("max-replays", Order = 17, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxReplays { get; init; }

    /// <summary>
    /// The code-prompt and code will replay automatically repeat if true, it will wait for a press on the "1" otherwise.
    /// </summary>
    [JsonProperty("auto-replay", Order = 18, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoReplay { get; init; }

    /// <summary>
    /// Determines the Voicemail detection flow.
    /// </summary>
    [JsonProperty("voicemail-response", Order = 19)]
    public VoicemailResponse VoicemailResponse { get; init; } = VoicemailResponse.Ignore;
}
using Newtonsoft.Json;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <summary>
/// This sends the instruction to make and outbound call and send a notification.
/// </summary>
public record NotificationInstruction : BaseAppInstruction
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
    /// Determines the Voicemail detection flow.
    /// </summary>
    [JsonProperty("voicemail-response", Order = 9)]
    public VoicemailResponse VoicemailResponse { get; init; } = VoicemailResponse.Ignore;

    /// <summary>
    /// The number of times the code can be played. Min = 1, Max = 3.
    /// </summary>
    [JsonProperty("max-replays", Order = 11, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxReplays { get; init; }

    /// <summary>
    /// The code-prompt and code will replay automatically repeat if true, it will wait for a press on the "1" otherwise.
    /// </summary>
    [JsonProperty("auto-replay", Order = 12, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoReplay { get; init; }

    /// <summary>
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonProperty("replay-prompt", Order = 13, NullValueHandling = NullValueHandling.Ignore)]
    public string ReplayPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonProperty("replay-prompt-type", Order = 14, NullValueHandling = NullValueHandling.Ignore)]
    public PromptType? ReplayPromptType { get; init; }
}
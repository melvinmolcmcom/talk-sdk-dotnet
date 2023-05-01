using System.Text.Json.Serialization;

namespace CM.Voice.VoiceApi.Sdk.Models.Instructions.Apps;

/// <summary>
/// This sends the instruction to make and outbound call and send a notification.
/// </summary>
public record NotificationInstruction : BaseAppInstruction
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
    /// Determines the Voicemail detection flow.
    /// </summary>
    [JsonPropertyName("voicemail-response")]
    public VoicemailResponse VoicemailResponse { get; init; } = VoicemailResponse.Ignore;

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
    /// The prompt, which is either the path and name of the file to play, or the string that needs to be tts-ed.
    /// </summary>
    [JsonPropertyName("replay-prompt")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string ReplayPrompt { get; init; }

    /// <summary>
    /// The type of the prompt, either file or tts.
    /// </summary>
    [JsonPropertyName("replay-prompt-type")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public PromptType? ReplayPromptType { get; init; }
}
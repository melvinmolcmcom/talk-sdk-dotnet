﻿using Newtonsoft.Json;

namespace CM.Voice.VoiceApi.Sdk.Models;

/// <summary>
/// The properties in this class are used to select the required TTS voice.
/// </summary>
public record Voice
{
    /// <summary>
    /// The language (5 character locale) of the voice to use. Examples: en-US, en-GB, nl-NL. Defaults to en-GB
    /// </summary>
    [JsonProperty("language", Order = 1)]
    public string Language { get; init; } = "en-GB";

    /// <summary>
    /// The gender of the voice, either female or male. Defaults to Female.
    /// </summary>
    [JsonProperty("gender", Order = 2)]
    public Gender Gender { get; init; } = Gender.Female;

    /// <summary>
    /// Usually one, but if the selected language and gender support multiple voices, you can use this to make a selection between the different ones. Defaults to 1.
    /// </summary>
    [JsonProperty("number", Order = 3)]
    public int Number { get; init; } = 1;

    /// <summary>
    /// Volume of the speaking voice. Defaults to 0.
    /// </summary>
    /// <remarks>Allowed values are -4, -3, -2, -1, 0, 1, 2, 3 or 4.</remarks>
    [JsonProperty("volume", Order = 4)]
    public sbyte Volume { get; init; }
    
    /// <summary>
    /// Iff true, the tts or stt voice has a higher quality and supports more languages.
    /// Please note that premium voices are more expensive.
    /// </summary>
    [JsonProperty("premium", Order = 5)]
    public bool? Premium { get; init; } = false;
}
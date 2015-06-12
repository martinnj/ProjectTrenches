using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class representing a playable card in the game.
/// </summary>
public class Card {

    /// <summary>
    /// Main Type for the card, decides where the card goes on the board.
    /// </summary>
    public readonly Enums.CardType Type;

    /// <summary>
    /// Unordered list of special abilities attached to the card. Most cards will have 0 or 1.
    /// </summary>
    public readonly List<Enums.CardAbility> Abilities;

    /// <summary>
    /// Field used for weather type, can be null if the CardType is not set to Weather.
    /// </summary>
    public readonly Enums.WeatherType WeatherType;
}

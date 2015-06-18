using UnityEngine;
using UnityEngine.UI;

using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Class representing a playable card in the game.
/// </summary>
[Serializable]
public class Card : MonoBehaviour
{

    /***********************
     * Attributes and data *
     ***********************/

    #region "Looks"
    /// <summary>
    /// String containing the name or title of the card.
    /// </summary>
    public string CardName;

    /// <summary>
    /// String containing the description/quote from the card.
    /// </summary>
    public string CardDescription;

    /// <summary>
    /// Image containing the cards monicker (area that contains strength).
    /// </summary>
    public Image CardMonicker;

    /// <summary>
    /// Image with card protrait.
    /// </summary>
    public Image CardPortrait;

    /// <summary>
    /// Image containing the cards background look.
    /// </summary>
    public Image CardBackground;
    #endregion

    #region "Stats & Attributes"
    /// <summary>
    /// Main Type for the card, decides where the card goes on the board.
    /// </summary>
    public Enums.CardType Type;

    /// <summary>
    /// Unordered list of special abilities attached to the card. Most cards will have 0 or 1.
    /// </summary>
    public List<Enums.CardAbility> Abilities;

    /// <summary>
    /// Field used for weather type, can be null if the CardType is not set to Weather.
    /// </summary>
    public Enums.WeatherType WeatherType;

    /// <summary>
    /// The base strength of the card before any modifiers.
    /// </summary>
    public int BaseStrength;
    #endregion


}

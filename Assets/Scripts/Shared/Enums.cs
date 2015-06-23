using System.Collections;

/// <summary>
/// Different enumerables used for the game.
/// </summary>
public class Enums {

    /// <summary>
    /// Different playable factions.
    /// </summary>
    public enum Faction
    {
        WesternAllies, // Representing Great Britain, France, USA and the other western allies.
        Soviet,        // Representing The Soviet Union.
        EuropeanAxis,  // Representing Germany, Italy and their allies.
        Japan          // Representing Japan.
    };

    /// <summary>
    /// Abilities that can be assigned to faction leaders.
    /// Abilities can be triggered once pr game.
    /// </summary>
    /// <remarks>Very temporary list, as in really very temporary.</remarks>
    public enum FactionLeaderAbilities
    {
        ClearWeather,  // May clear the weapther once pr game.
        KillStrongest, // Kills the strongest unit on the board. (Including players own?)
        Regroup,       // Take a card from discard pile, play at once
        FreeSupport    // Get a free support unit.
    };

    /// <summary>
    /// Enum to represent where on the board this card belongs.
    /// </summary>
    public enum CardType
    {
        Infantry, // Front row.
        Armour,   // Mid row.
        Artillery,// Rear row.
        Weather,  // Weather/environment box.
        Support   // Goes next to a row.
    };

    /// <summary>
    /// Abilies that can be attached to cards.
    /// </summary>
    public enum CardAbility
    {
        Hero,                 // Heroes cannot interact with special cards or abilities.
        Intelligence,         // Play to opponents area, take 2 random cards from your deck.
        SquadMates,           // For each card with same name in row, double strength.
        OrganizedDeplaoyment, // Play any card with same name from your deck.
        Regroup,              // Take a card from discard pile, play at once.
        Diversion,            // Replace a card on your battlefield and return it to hand.
        RowBuff               // Buff all cards in the row with +1 strength.
    };

    /// <summary>
    /// Different kind of weather cards.
    /// </summary>
    public enum WeatherType
    {
        Frost, // Reduce all infrantry to base strength 1.
        Rain,  // Reduce all armour to base strength 1.
        Fog,   // Reduce all artillery to base strength 1.
        Shine, // Disspell all active weather cards.
        None   // No Weather.
    };
}

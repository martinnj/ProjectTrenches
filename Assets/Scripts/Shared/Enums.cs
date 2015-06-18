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
        Monsters,  // Includes monsters/beasts and the wild hunt.
        Squirrels, // Scoia'tel.
        Nilfgaard, // Nilfgaardian empire.
        Northern   // The Northern Kingdoms.
    }

    /// <summary>
    /// Enum to represent where on the board this card belongs.
    /// </summary>
    public enum CardType
    {
        Infantry, // Front row.
        Ranged,   // Mid row.
        Siege,    // Rear row.
        Weather,  // Weather/environment box.
        Morale    // Goes next to a row.
    };

    /// <summary>
    /// Abilies that can be attached to cards.
    /// </summary>
    public enum CardAbility
    {
        Hero,       // Heroes cannot interact with special cards or abilities.
        Spy,        // Play to opponents area, take 2 random cards from your deck.
        TightBond,  // For each card with same name in row, double strength.
        Horde,      // Play any card with same name from your deck.
        Revive,     // Take a card from discard pile, play at once.
        Diversion,  // Replace a card on your battlefield and return it to hand.
        RowBuff     // Buff all cards in the row with +1 strength.
    };

    /// <summary>
    /// Different kind of weather cards.
    /// </summary>
    public enum WeatherType
    {
        Frost, // Reduce all infrantry to base strength 1.
        Fog,   // Reduce all ranged to base strength 1.
        Rain,  // Reduce all siege to base strength 1.
        Shine, // Disspell all active weather cards.
        None   // No Weather.
    };
}

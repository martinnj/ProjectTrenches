using UnityEngine;
using System.Collections;

using System.Collections.Generic;

/// <summary>
/// Class for representing an entire collection of cards.
/// Either all the cards a player have available or all cards that are valid for a single faction/leader.
/// </summary>
public class CardCollection : MonoBehaviour {

    /// <summary>
    /// Faction the collection belongs to.
    /// </summary>
    Enums.Faction Faction;

    /// <summary>
    /// Set of available leaders for the faction.
    /// </summary>
    HashSet<FactionLeader> AvailableLeaders;

    /// <summary>
    /// Set of available cards.
    /// </summary>
    HashSet<Card> AvailableCards;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using UnityEngine.UI;

using System.Collections.Generic;

/// <summary>
/// Class for representing a faction leader in the code.
/// </summary>
public class FactionLeader : MonoBehaviour {

    /// <summary>
    /// String with the leaders name.
    /// </summary>
    public string LeaderName;

    /// <summary>
    /// Portrait of the leader.
    /// </summary>
    public Image LeaderPortrait;

    /// <summary>
    /// What factions does the leader belong to.
    /// </summary>
    public Enums.Faction LeaderFaction;

    /// <summary>
    /// Set of abilities that is available to the faction leader.
    /// Should maybe just be changed to a single ability?
    /// </summary>
    public HashSet<Enums.FactionLeaderAbilities> Abilities;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}

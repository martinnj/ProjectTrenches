using UnityEngine;
using UnityEngine.UI;

using System.Collections;

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
    /// Small image with the faction badge.
    /// </summary>
    public Image FactionBadge;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

}

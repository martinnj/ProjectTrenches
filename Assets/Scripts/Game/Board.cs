using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Board : MonoBehaviour
{

    #region "Looks"
    public string Player1Name;
    public FactionLeader Player1Leader;

    public string Player2Name;
    public FactionLeader Player2Leader;
    #endregion

    #region "Card piles and areas"
    public List<Card> WeatherCards;

    public Deck Player1Deck;
    public List<Card> Player1Hand;
    public List<Card> Player1Discard;
    public CardRow Player1Infantry;
    public CardRow Player1Ranged;
    public CardRow Player1Siege;

    public Deck Player2Deck;
    public List<Card> Player2Hand;
    public List<Card> Player2Discard;
    public CardRow Player2Infantry;
    public CardRow Player2Ranged;
    public CardRow Player2Siege;
    #endregion

    #region "Unity functions"
    // Use this for initialization
    void Start()
    {
        Player1Hand = new List<Card>();
        Player1Discard = new List<Card>();
        Player2Hand = new List<Card>();
        Player2Discard = new List<Card>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion
}

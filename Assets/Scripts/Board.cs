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

    public List<Card> Player1Deck;
    public List<Card> Player1Hand;
    public List<Card> Player1Discard;
    public CardRow Player1Infantry;
    public CardRow Player1Ranged;
    public CardRow Player1Siege;

    public List<Card> Player2Deck;
    public List<Card> Player2Hand;
    public List<Card> Player2Discard;
    public CardRow Player2Infantry;
    public CardRow Player2Ranged;
    public CardRow Player2Siege;
    #endregion
}

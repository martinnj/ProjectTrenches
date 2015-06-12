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
    public List<Card> Player1Infantry;
    public List<Card> Player1Ranged;
    public List<Card> Player1Siege;

    public List<Card> Player2Deck;
    public List<Card> Player2Hand;
    public List<Card> Player2Discard;
    public List<Card> Player2Infantry;
    public List<Card> Player2Ranged;
    public List<Card> Player2Siege;
    #endregion
}

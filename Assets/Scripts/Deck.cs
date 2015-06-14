using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    public List<Card> Cards;

    /// <summary>
    /// Shuffles the deck resulting in a new order of cards.
    /// </summary>
    public void Shuffle()
    {
        Utils.Shuffle<Card>(Cards);
    }

    /// <summary>
    /// Draws a card from the top of the deck.
    /// </summary>
    /// <returns>A Card that was at index 0 of the card list.</returns>
    public Card Draw()
    {
        if (Cards.Count < 1) { throw new DeckEmptyException("No cards left in deck."); }
        Card ret = Cards[0];
        Cards.RemoveRange(0, 1);
        return ret;
    }

    /// <summary>
    /// Draws (and thus removes) the 'n' topmost cards from the deck. If there is less than n cards in the deck, the entire deck will be drawn.
    /// </summary>
    /// <param name="n">Numnber of cards to draw.</param>
    /// <remarks>Uses the draw function recursively.</remarks>
    /// <returns>A list of the Card type containing n elements or less if the deck is too small.</returns>
    public List<Card> Take(int n)
    {
        if (Cards.Count < 1) { throw new DeckEmptyException("No cards left in deck."); }
        List<Card> ret = new List<Card>();
        for (int i = 0; i < n; i++)
        {
            try
            {
                ret.Add(Draw());
            } catch (DeckEmptyException) {
                break;
            }
        }
        return ret;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

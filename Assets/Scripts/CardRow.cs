using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardRow : MonoBehaviour {


    public Enums.WeatherType CurrentWeather;
    public Card MoraleCard;
    public List<Card> Cards;

    public int TotalStength;

	// Use this for initialization
	void Start () {
        Cards = new List<Card>();
        MoraleCard = null;
        CurrentWeather = Enums.WeatherType.None;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

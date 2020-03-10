using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{ 
    #region Fields
    private int value;
    private CardSuit suit;

    public bool visible;
    #endregion

    #region Properties
    public int Value
    {
        get { return value; }
        private set { }
    }
    public CardSuit Suit
    {
        get { return suit; }
        private set { }
    }
    #endregion
    #region Constructor
    public Card(int value, CardSuit suit)
    {
        this.value = value;
        this.suit = suit;
    }
    #endregion

    #region Public Methods
    public override string ToString()
    {
        return this.value + " - " + this.Suit.ToString();
    }

    public void Show()
    {
        if (!visible)
        {
            visible = true;
        }
    }
    #endregion
}

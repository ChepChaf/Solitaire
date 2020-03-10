using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    #region Fields
    private int numberOfCardsPerSuit = 13;
    private Stack<Card> deck;
    #endregion

    #region Constructor
    public Deck(CardSuit[] suits)
    {
        List<Card> cards = new List<Card>();

        foreach(CardSuit suit in suits)
        {
            cards.AddRange(GenerateRanks(suit));
        }

        deck = new Stack<Card>();

        int remainingInDeck = cards.Count;
        while(remainingInDeck > 0)
        {
            int randomIndex = Random.Range(0, remainingInDeck) % remainingInDeck;
            Card randomCard = cards[randomIndex];

            deck.Push(randomCard);

            cards.RemoveAt(randomIndex);

            remainingInDeck = cards.Count;
        }
    }
    #endregion

    #region Private Methods
    private List<Card> GenerateRanks(CardSuit suit)
    {
        List<Card> cards = new List<Card>();
        for (int i = 0; i < numberOfCardsPerSuit; i++)
        {
            cards.Add(new Card(i + 1, suit));
        }

        return cards;
    }
    #endregion
    #region Public Methods

    public Card GetCardOnTop()
    {
        return deck.Peek();
    }

    public override string ToString()
    {
        string result = "";

        foreach(Card card in deck)
        {
            result += card.ToString() + "\n";
        }

        return result;
    }
    #endregion
}

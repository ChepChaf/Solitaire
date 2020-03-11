using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Fields
    private GameManager instance;
    private Deck deck;

    [SerializeField]
    private CardSuit[] cardSuits;

    [SerializeField]
    private Transform[] slots;

    [SerializeField]
    private GameObject cardPrefab;
    #endregion

    #region MonoBehaviour Methods
    private void Start()
    {
        if(instance != null)
        {
            Debug.LogError("Trying to create more than one GameManager.");
            return;
        }

        instance = this;

        BeginGame();
    }
    #endregion

    #region Public Methods
    private void BeginGame()
    {
        deck = new Deck(cardSuits);

        GameObject cardGameObject = Instantiate(cardPrefab, slots[0].transform.position, Quaternion.identity);
        cardGameObject.transform.SetParent(slots[0].transform);

        CardObject topCard = cardGameObject.GetComponent<CardObject>();
      
        topCard.SetCardValue(deck.GetCardOnTop());
        Debug.Log("Top Card: " + topCard);

        topCard.ShowCard();
    }
    #endregion

    #region Properties
    public GameManager Instance
    {
        get { return instance; }
        private set { }
    }
    #endregion
}

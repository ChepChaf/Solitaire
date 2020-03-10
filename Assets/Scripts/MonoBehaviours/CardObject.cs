using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour
{
    #region Fields
    private Card card;
    private GameObject cardGameObject;
    #endregion

    #region Public Methods
    public void SetCardValue(Card card)
    {
        this.card = card;
    }

    public void ShowCard()
    {
        this.card.Show();

        cardGameObject = transform.Find(this.card.Suit.ToString()).gameObject;
        
        SetCardText();

        cardGameObject.SetActive(true);
    }

    public void SetCardText()
    {
        string textValue;

        switch(this.card.Value)
        {
            case 1:
                textValue = "A";
                break;
            case 11:
                textValue = "J";
                break;
            case 12:
                textValue = "Q";
                break;
            case 13:
                textValue = "K";
                break;
            default:
                textValue = this.card.Value.ToString();
                break;
        }

        GetComponent<TextMesh>().text = textValue;
    }
    public override string ToString()
    {
        return card.ToString();
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class CardObject : MonoBehaviour
{
    #region Fields
    private Card card;
    private Image cardImage;

    [SerializeField]
    private List<Sprite> suitSprites;
    #endregion

    #region Public Methods
    public void SetCardValue(Card card)
    {
        this.card = card;
    }

    public void ShowCard()
    {
        this.card.Show();

        if (this.cardImage == null)
            cardImage = GetComponent<Image>();

        Sprite cardSprite = suitSprites.Find(x => x.name.Contains(this.card.Suit.ToString().ToLower()));

        this.cardImage.sprite = cardSprite;

        SetCardText();
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

        foreach(Text text in GetComponentsInChildren<Text>())
        {
            text.text = textValue;
        }
    }
    public override string ToString()
    {
        return card.ToString();
    }
    #endregion

}

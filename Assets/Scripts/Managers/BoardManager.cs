
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    #region Public methods
    public bool CanPlaceCardOver(Card movedCard, Card placedCard)
    {
        if (movedCard.Suit == movedCard.Suit)
        {
            return movedCard.Value == placedCard.Value + 1;
        }

        return false;
    }
    #endregion
}

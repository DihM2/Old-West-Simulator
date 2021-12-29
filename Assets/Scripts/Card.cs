using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    int cardValue;
    
    [SerializeField] List<Sprite> sprites;
    private Image cardSprite;

    private void Start()
    {
        cardSprite = GetComponent<Image>();
        cardValue = Random.Range(-1, 2);
    }


    public void ChangeSprite()
    {
        if(cardValue > 0)
        {
            cardSprite.sprite = sprites[0];
        }
        else if(cardValue < 0)
        {
            cardSprite.sprite = sprites[1];
        }
        else
        {
            cardSprite.sprite = sprites[2];
        }
    }

    public void CardClicked()
    {
        MiniGame miniGame = GameObject.Find("MiniGame").GetComponent<MiniGame>();

        miniGame.AddMoney(cardValue);
    }
}

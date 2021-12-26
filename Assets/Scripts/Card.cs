using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    int value;
    
    [SerializeField] List<Sprite> sprites;
    private Image cardSprite;

    

    private void Start()
    {
        cardSprite = GetComponent<Image>();
        value = Random.Range(-1, 2);
    }


    public void ChangeSprite()
    {
        if(value > 0)
        {
            cardSprite.sprite = sprites[0];
        }
        else if(value < 0)
        {
            cardSprite.sprite = sprites[1];
        }
        else
        {
            cardSprite.sprite = sprites[2];
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{

    [SerializeField] GameObject cardPrefab;

    public bool cardGameIsOn { get; private set; }

    public void PlayCards()
    {
        cardGameIsOn = true;

        for(int i = -1; i < 2; i++)
        {
            Instantiate(cardPrefab, new Vector3(i * 100, 0, 0) + transform.position, cardPrefab.transform.rotation, transform);
        }

    }

    public void AddMoney(int money)
    {
        GameManager gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        Card[] cards = GetComponentsInChildren<Card>();
        
        foreach(Card card in cards)
        {
            card.ChangeSprite();
        }

        gameManager.Money += money;

        
    }
}

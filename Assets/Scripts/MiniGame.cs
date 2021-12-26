using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGame : MonoBehaviour
{
    int cardValue;

    [SerializeField] GameObject cardPrefab;

    public bool cardGameIsOn { get; private set; }

    public void PlayCards()
    {
        cardGameIsOn = true;

        for(int i = -1; i < 2; i++)
        {
            Instantiate(cardPrefab, new Vector3(i * 100, 0, 0) + transform.position, cardPrefab.transform.rotation, transform);
        }

        
        //return cardValue;
    }
}

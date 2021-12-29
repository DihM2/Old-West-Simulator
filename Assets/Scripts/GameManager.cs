using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManager uiManager;


    private float money = 5f;
    public float Money
    {
        get => money;
        set
        {
            money = value;
            uiManager.ChangeMoneyText(money);
        }
    }

    

    

    

    
}

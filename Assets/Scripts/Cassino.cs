using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cassino : Build
{
    [SerializeField] MiniGame miniGameScript;

    public override void UseService()
    {
        miniGameScript.PlayCards();

        float gameMoney = MiniGame();

        string message;

        gameManagerScript.Money += gameMoney;
        if(gameMoney > 0)
        {
            message = $"You played poker and won $ {gameMoney.ToString("n2")}";
        }
        else if(gameMoney < 0)
        {
            message = $"You played poker and lose $ {((-1)*gameMoney).ToString("n2")}";
        }
        else
        {
            message = $"You played poker and didn't won anything.";
        }

        gameManagerScript.ChangeText(message);
    }

    public float MiniGame()
    {
        return Random.Range(-1f, 3f);
    }
}

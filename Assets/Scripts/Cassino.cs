using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cassino : Build
{
    

    public override void UseService()
    {
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

    float MiniGame()
    {
        return Random.Range(-1f, 3f);
    }
}

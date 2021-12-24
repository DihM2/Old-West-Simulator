using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cassino : Build
{
    

    public override void UseService()
    {
        float gameMoney = MiniGame();
        
        gameManagerScript.Money += gameMoney;
        if(gameMoney > 0)
        {
            Debug.Log("You played poker and won!");
        }
        else if(gameMoney < 0)
        {
            Debug.Log("You played poker and lose!");
        }
        else
        {
            Debug.Log("You played poker and didn't won or lose!");
        }
        
    }

    float MiniGame()
    {
        return Random.Range(-1f, 3f);
    }
}

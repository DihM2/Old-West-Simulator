using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saloon : Build
{
    public override void UseService()
    {
        if (gameManagerScript.Money >= 1)
        {
            gameManagerScript.Money -= 1;
            Debug.Log("You drinked a beer!");
        }
        else
        {
            Debug.Log("You don't have enought money!");
        }
        
    }

}

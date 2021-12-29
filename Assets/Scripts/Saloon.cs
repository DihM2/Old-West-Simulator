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
            uiManager.ChangeText("You drinked a beer!\nYou paid $ 1,00 to the barman!");
        }
        else
        {
            uiManager.ChangeText("You don't have enought money.");
        }
        
    }

}

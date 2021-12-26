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
            gameManagerScript.ChangeText("You drinked a beer!\nYou paid $ 1,00 to the barman!");
        }
        else
        {
            gameManagerScript.ChangeText("You don't have enought money.");
        }
        
    }

}

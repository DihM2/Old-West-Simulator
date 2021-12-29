using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StripClub : Build
{


    public override void UseService()
    {
        if(gameManagerScript.Money >= 5)
        {
            gameManagerScript.Money -= 5;
            uiManager.ChangeText("You gained a massage!\nYou paid $ 5,00 to the girl!");
        }
        else
        {
            uiManager.ChangeText("You don't have enought money.");
        }
        
    }
}

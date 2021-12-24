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
            Debug.Log("You have some fun with a hooker!");
        }
        else
        {
            Debug.Log("You don't have enought money!");
        }
        
    }
}

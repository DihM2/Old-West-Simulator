using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Build : MonoBehaviour
{
    string buildName;
    [SerializeField] string serviceName;

    protected GameManager gameManagerScript;



    // Start is called before the first frame update
    void Start()
    {
        buildName = gameObject.name;

        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public abstract void UseService();

    
    protected void OnTriggerEnter(Collider other)
    {
        gameManagerScript.ShowMessageBox(buildName, serviceName);
    }

    protected void OnTriggerExit(Collider other)
    {
        gameManagerScript.HideMessageBox();
    }
}

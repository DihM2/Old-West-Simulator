using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Build : MonoBehaviour
{
    string buildName;
    [SerializeField] string serviceName;

    protected GameManager gameManagerScript;
    protected UIManager uiManager;



    // Start is called before the first frame update
    void Start()
    {
        buildName = gameObject.name;

        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        uiManager = GameObject.Find("UI Canvas").GetComponent<UIManager>();
    }

    public abstract void UseService();

    
    protected void OnTriggerEnter(Collider other)
    {
        uiManager.ShowMessageBox(buildName, serviceName);
    }

    protected void OnTriggerExit(Collider other)
    {
        uiManager.HideMessageBox();
    }
}

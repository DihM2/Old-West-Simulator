using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] GameObject messageBox;
    [SerializeField] TextMeshProUGUI messageBoxText;


    private float money = 5f;
    public float Money
    {
        get => money;
        set
        {
            money = value;
            ChangeMoneyText();
        }
    }

    public void ShowMessageBox(string build, string service)
    {
        messageBox.SetActive(true);
        ChangeText(build, service);
    }

    public void HideMessageBox()
    {
        messageBox.SetActive(false);
    }

    private void ChangeText(string build, string service)
    {
        messageBoxText.SetText($"Build: {build} - Service: {service}" +
            $"\nPress Space to use service.");
    }

    public void ChangeText(string message)
    {
        messageBoxText.SetText(message);
    }

    private void ChangeMoneyText()
    {
        moneyText.SetText($"Money: {money.ToString("n2")}");
    }

    
}

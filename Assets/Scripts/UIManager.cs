using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] GameObject messageBox;
    [SerializeField] TextMeshProUGUI messageBoxText;

    public void ChangeText(string build, string service)
    {
        messageBoxText.SetText($"Build: {build} - Service: {service}" +
            $"\nPress Space to use service.");
    }

    public void ChangeText(string message)
    {
        messageBoxText.SetText(message);
    }

    public void ChangeMoneyText(float money)
    {
        moneyText.SetText($"Money: {money.ToString("n2")}");
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
}

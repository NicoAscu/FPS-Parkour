using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    //DInero
    public TextMeshProUGUI txtMoney;

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }

    // Health
    public TextMeshProUGUI txtHealth;
   
    public void UpdateHealthText (string health)
    {
        txtHealth.text = health + "HP";
    }
}

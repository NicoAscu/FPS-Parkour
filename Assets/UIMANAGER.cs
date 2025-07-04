using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI txtHealth;
    public MoneyManager moneyManager;
    public HealthManager healthManager;

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
        txtHealth.text = "HP " + healthManager.healthPoints.ToString();
    }

    public void UpdateHealthText(string health)
    {
        txtHealth.text = health;
    }
}

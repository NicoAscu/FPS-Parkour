using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    int amount = 100;
    public float money;
    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateMoney(float amount)
    {
        if(money < amount)
        {
            //Impedir Compra
            Debug.Log("Dinero Insuficiente");
            return false;
        }
        else
        {
            money += amount;
            uiManager.UpdateMoneyText(money.ToString());
            return true;
        }
    }
}

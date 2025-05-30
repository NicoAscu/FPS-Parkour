using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIMANAGER : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }
}

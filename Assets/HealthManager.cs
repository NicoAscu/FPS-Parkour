using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{

    public int health;
    public UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateHealth(int damageAmount)
    {
        if(health <= damageAmount)
        {
            Debug.Log("Game Over");
            return false;
        }
        health += damageAmount;
        uiManager.UpdateHealthText(health.ToString());
        return true;
    }
}

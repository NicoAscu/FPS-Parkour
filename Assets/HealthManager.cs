using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        health += damageAmount;
        if(health <= 0)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene("FPS PARKOUR");
            return false;
        }
        uiManager.UpdateHealthText(health.ToString());
        return true;
    }
}

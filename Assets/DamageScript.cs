using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour
{
    public int damage = 5;
    public HealthManager healthManager;
    private void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("p");
        if (collision.gameObject.CompareTag("Player"))
        {
            if (healthManager.HealthUpdate(-damage))
            {
                Destroy(gameObject);
            }
            else
            {
                SceneManager.LoadScene("FPS Parkour");
            }
        }
    }
}

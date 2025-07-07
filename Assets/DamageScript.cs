using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage = 5;
    public healthManager HealthManager;

    void Start()
    {
        HealthManager = FindObjectOfType<healthManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (HealthManager.UpdateHealth(-damage))
            {
                Debug.Log("Sufriste 5 de daño");
            }
        }
    }
}
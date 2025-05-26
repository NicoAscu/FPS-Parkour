using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collitionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }

    }
}

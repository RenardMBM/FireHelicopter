using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBomb : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Fire"))
        {
            other.gameObject.GetComponent<Fire>().Kill();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Earth")) Destroy(gameObject);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float time;
    IEnumerator TimerLife()
    {
        yield return new WaitForSeconds(0.01f);
        if (time <= 0f)
        {
            gameObject.GetComponentInParent<BadWolf>().Fail();
            Destroy(gameObject);
        }
        else
        {
            time -= 0.01f;
            GetComponentInChildren<Label>().Time = time;
            StartCoroutine(TimerLife());
        }
    }

    private void Start()
    {
        GetComponentInChildren<Label>().Time = time;
        StartCoroutine(TimerLife());
    }
    
    public void Kill()
    {
        gameObject.GetComponentInParent<BadWolf>().Success();
        Destroy(gameObject);
    }
}

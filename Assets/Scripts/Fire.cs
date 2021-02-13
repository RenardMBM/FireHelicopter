using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float time;
    IEnumerator TimerLife(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.GetComponentInParent<BadWolf>().Fail();
        Destroy(gameObject);
    }
    
    private void Start() { StartCoroutine(TimerLife(time)); }
    
    public void Kill()
    {
        gameObject.GetComponentInParent<BadWolf>().Success();
        Destroy(gameObject);
    }
}

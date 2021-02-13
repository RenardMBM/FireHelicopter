using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // TODO: Timer
    public void Kill()
    {
        gameObject.GetComponentInParent<BadWolf>().Success();
        Destroy(gameObject);
    }
    public void Die()
    {
        gameObject.GetComponentInParent<BadWolf>().Fail();
        Destroy(gameObject);
    }
}

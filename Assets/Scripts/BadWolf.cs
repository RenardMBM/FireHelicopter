using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadWolf : MonoBehaviour
{
    public GameObject helicopter;

    private void SpawnNewFire()
    {
        // TODO: Spawn fire
        // new_fire.GetComponent<Fire>().time = 120f;
    }
    public void Success()
    {
        helicopter.GetComponent<Helicopter>().Success();
        SpawnNewFire();
    }
    public void Fail()
    {
        helicopter.GetComponent<Helicopter>().Fail();
        SpawnNewFire();
    }
}

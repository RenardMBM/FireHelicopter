using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public Quaternion Rotation { get; private set; }
    
    private void Update()
    {
        Rotation = transform.rotation;
    }
}

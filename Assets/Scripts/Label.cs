using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Label : MonoBehaviour
{
    public GameObject Player;
    private float _time;
    public float Time { set => _time = value; }
    void Update()
    {
        transform.LookAt(Player.transform);
        GetComponentInChildren<Text>().text = _time.ToString("0.00");
    }
    
}

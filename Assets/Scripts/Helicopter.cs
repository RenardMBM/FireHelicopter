using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    private int _numSuccess;
    private int _numFail;

    void Start()
    {
        _numSuccess = 0;
        _numFail = 0;
    }
    void Update()
    {
        if (_numFail == 3)
        {
            // TODO: GameOver
        }
    }

    public int GETNumSuccess() { return _numSuccess; }
    public void Fail() { _numFail++; }
    public void Success() { _numSuccess++; }
}
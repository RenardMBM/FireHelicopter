﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Helicopter : MonoBehaviour
{
    [SerializeField] private Lever _leftLever;
    [SerializeField] private Lever _rightLever;
    
    private int _numSuccess;
    private int _numFail;
    public float speed = 1f;

    void Start()
    {
        _numSuccess = 0;
        _numFail = 0;
    }
    void Update()
    {
        Debug.Log(_leftLever);
        transform.Translate(new Vector3(_leftLever.Rotation.eulerAngles.x, 0, _leftLever.Rotation.eulerAngles.z % 90) * Time.deltaTime * speed);
        Debug.Log(new Vector3(_leftLever.Rotation.eulerAngles.x, 0, _leftLever.Rotation.eulerAngles.z));
        if (_numFail == 3)
        {
            // TODO: GameOver
        }
    }

    public int GETNumSuccess() { return _numSuccess; }
    public void Fail() { _numFail++; }
    public void Success() { _numSuccess++; }
}
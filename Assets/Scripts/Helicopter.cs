using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    [SerializeField] private Lever _leftLever;
    [SerializeField] private Lever _rightLever;
    
    private int _numSuccess;
    private int _numFail;
    private float _speed = 1f;

    void Start()
    {
        _numSuccess = 0;
        _numFail = 0;
    }
    void Update()
    {
        transform.Translate(new Vector3(_leftLever.Rotation.eulerAngles.x, 0, _leftLever.Rotation.eulerAngles.z) * Time.deltaTime);
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
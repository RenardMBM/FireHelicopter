using System.Collections;
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
    private Rigidbody _playerRigidbody;
    

    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
        _numSuccess = 0;
        _numFail = 0;
    }
    void Update()
    {
        Debug.Log(new Vector3(
            _leftLever.Rotation.eulerAngles.x - ((Mathf.Floor(_leftLever.Rotation.eulerAngles.x / 90) * 120)), 0,
            _leftLever.Rotation.eulerAngles.z - ((Mathf.Floor(_leftLever.Rotation.eulerAngles.z / 90) * 120))));
        _playerRigidbody.AddForce(new Vector3(_leftLever.Rotation.eulerAngles.x - ((Mathf.Floor(_leftLever.Rotation.eulerAngles.x / 90) * 120)), 0, 
            _leftLever.Rotation.eulerAngles.z - ((Mathf.Floor(_leftLever.Rotation.eulerAngles.z / 90) * 120))), ForceMode.Force);
        if (_numFail == 3)
        {
            // TODO: GameOver
        }
    }

    public int GETNumSuccess() { return _numSuccess; }
    public void Fail() { _numFail++; }
    public void Success() { _numSuccess++; }
}
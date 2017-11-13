using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCanWalk : MonoBehaviour {

    private Transform _myTransform = null;
    private Vector3 _lastPosition;

    private void Awake()
    {
        _myTransform = transform;
        _lastPosition = _myTransform.position;
    }

    private void Update()
    {
        if (_lastPosition == _myTransform.position)
        {
            Debug.Log("Did not move");
        }
        else
        {
            Debug.Log("Moved");
        }
        _lastPosition = _myTransform.position;
    }
}

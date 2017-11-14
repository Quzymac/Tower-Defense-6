using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCanWalk : MonoBehaviour {

    public bool checkIfReady = true;

    void Start()
    {
        
    }
    void Update()
    {
        if (GetComponent<Rigidbody>().IsSleeping() == true)
        {
            checkIfReady = false;
        }
    }
}

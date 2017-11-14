using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfCanWalk : MonoBehaviour {

    private bool checkIfReady = true;

    void Start()
    {
        
    }
    void Update()
    {

    }
    protected bool CheckIfReady()
    {
        if (this.GetComponent<Rigidbody>().IsSleeping().Equals(false))
        {
            Debug.Log("Jag är restattad");
            return true;
            //checkIfReady = true;
        }
        else if (this.GetComponent<Rigidbody>().IsSleeping().Equals(true))
        {
            Debug.Log("jag sa ju det");
            return false;
            //checkIfReady = false;
        }
        else
            return true;
    }
}

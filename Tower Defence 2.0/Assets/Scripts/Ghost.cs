using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ghost : MonoBehaviour {

    public Transform destinationPoint;
    private Transform curPos;
    private Transform lastPos;
    private float oldPos;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<NavMeshAgent>().destination = destinationPoint.position;
    }
}
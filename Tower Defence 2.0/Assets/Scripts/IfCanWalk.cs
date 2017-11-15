using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IfCanWalk : MonoBehaviour
{

    protected bool checkIfReady = true;
    [SerializeField] GameObject ghost;
    [SerializeField] protected GameObject spawnLocation;
    [SerializeField] GameObject targetLocation;

    private float oldPosX;
    private float oldPosZ;

    void Start()
    {

    }
    void Update()
    {
        //float currentX = spawnLocation.transform.position.x;
        //float currentZ = spawnLocation.transform.position.z;

        //NavMesh.CalculatePath(spawnLocation, targetLocation, NavMesh.AllAreas, path);
        /*if (this.ghost.GetComponent<Rigidbody>().IsSleeping().Equals(false))
        {
            Debug.Log("False");
            //return true;
            checkIfReady = true;
        }*/
        if (this.ghost.GetComponent<Rigidbody>().IsSleeping().Equals(true))
        {
            Debug.Log("True");
            //return false;
            checkIfReady = false;
           
        }
    }
    /*private void Update()
    {
        oldPosX = transform.position.x;
        oldPosZ = transform.position.z;
        if (oldPosX > transform.position.x)
        {
            print("moving right");
        }
        if (oldPosZ > transform.position.z)
        {
            print("moving left");
        }
        oldPosX = transform.position.x;
        oldPosZ = transform.position.z;
    }*/
}

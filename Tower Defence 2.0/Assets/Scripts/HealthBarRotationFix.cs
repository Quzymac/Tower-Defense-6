using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarRotationFix : MonoBehaviour {

    int XRotation = 90; //locking the rotation at a certain angle for X
    int YRotation; //locking the rotation at a certain angle for Y
    int ZRotation; //locking the rotation at a certain angle for Z
 
 
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(XRotation, YRotation, ZRotation);
    }
}

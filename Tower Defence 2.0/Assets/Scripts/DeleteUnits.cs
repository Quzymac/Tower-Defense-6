using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteUnits : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePosition2 = new Vector3((int)(Input.mousePosition.x) + 0.5f, (int)(Input.mousePosition.y) + 0.5f);

            Destroy(this.transform.gameObject);
        }
    }
}

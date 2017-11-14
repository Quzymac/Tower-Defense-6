using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DstinationGoal : MonoBehaviour
{

    [SerializeField] private GameObject ghost;
    [SerializeField] private GameObject spawnLocation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Ghost") == null)
        {
            //Debug.Log("Finns inte");
            float currentX = spawnLocation.transform.position.x;
            float currentZ = spawnLocation.transform.position.z;

            GameObject newGhost = (GameObject)Instantiate(ghost, transform.position, transform.rotation);

            newGhost.transform.position = new Vector3(currentX, 0.3f, currentZ);
            newGhost.transform.SetParent(spawnLocation.transform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Ghost")
        {
            //Debug.Log("Hej");
            //GameObject newGhost = (GameObject)Instantiate(ghost, transform.position, transform.rotation) as GameObject;

            Destroy(GameObject.FindGameObjectWithTag("Ghost"));

            //Destroy(newGhost);
            /*newGhost = (GameObject)Instantiate(ghost, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            newGhost = (GameObject)Instantiate(ghost, transform.position, transform.rotation);
            Destroy(newGhost);*/
        }
    }
}
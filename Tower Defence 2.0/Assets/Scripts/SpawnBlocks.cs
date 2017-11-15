using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour
{

    [SerializeField] GameObject blockToSpawn;
    [SerializeField] float objectHeight;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseUpAsButton()
    {
        if (Input.GetMouseButtonUp(0))
        {
            float currentX = transform.position.x;
            float currentZ = transform.position.z;

            GameObject cube = GameObject.Instantiate(blockToSpawn);
            cube.transform.position = new Vector3(currentX, objectHeight, currentZ);
            cube.transform.SetParent(transform);

            Debug.Log("Summon me!");
        }
    }
}

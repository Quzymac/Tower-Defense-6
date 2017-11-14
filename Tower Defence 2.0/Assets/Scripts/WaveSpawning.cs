using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawning : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject spawnLocation;

    private bool waveIsGoing = false;
    private int waveCounter;
    private int enemiesToSpawn = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GetComponent<IfCanWalk>().CheckIfReady == false)
            {
                Debug.Log("True");

                float currentX = spawnLocation.transform.position.x;
                float currentZ = spawnLocation.transform.position.z;

                if (waveIsGoing == false)
                {
                    waveIsGoing = true;
                    waveCounter++;
                    for (int i = 0; i < enemiesToSpawn + 1; i++)
                    {
                        GameObject newEnemy = (GameObject)Instantiate(enemy, transform.position, transform.rotation);

                        newEnemy.transform.position = new Vector3(currentX, 0.3f, currentZ);
                        newEnemy.transform.SetParent(spawnLocation.transform);
                    }
                    enemiesToSpawn += 3;
                }
                else
                {
                    Debug.Log("Wave is ongoing!");
                }
            }
        }
    }
}

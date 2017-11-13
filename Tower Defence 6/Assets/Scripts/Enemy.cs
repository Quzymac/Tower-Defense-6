using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public Transform targetPoint;

    public int health = 5;
    [SerializeField] int damageTakenFromCanon = 1;

    // Use this for initialization
    void Start()
    {
        transform.GetComponent<NavMeshAgent>().destination = targetPoint.position; //stops on arrival

    }

    // Update is called once per frame
    void Update()
    {

        if (health == 3)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color32(255, 255, 0, 0);
        }
        if (health == 4)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color32(255, 0, 255, 0);
        }
        if (health == 2)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 255);
        }
        if (health == 1)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 0);
        }


        if (health < 1)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider collider)
    {

        if (collider.CompareTag("Bullet"))
        {
            TakeDamage(damageTakenFromCanon);
        }
    }

    void TakeDamage(int Damage)
    {
        health -= Damage;
    }
}



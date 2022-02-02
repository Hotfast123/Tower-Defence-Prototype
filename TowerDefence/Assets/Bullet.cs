using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 70f;
    public int deathTime = 5;
    public int damage = 25;

    public GameObject deathExplosion;

    void Start()
    {
        //If bullet misses destroy after a certain amount of time
        Destroy(gameObject, deathTime);
    }

    void Update()
    {
        //Just moves the bullet in one direction 
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //If the bullet hits
            Instantiate(deathExplosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}

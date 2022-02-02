using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    public WaveSpawner wave;
    private int wavepointIndex = 0;

    void Start()
    {
        //Create an Array of waypoints and set them as a tranform object
        target = WayPoints.wayPoints[0];
    }

    void Update()
    {
        wave = GameObject.Find("GameController").GetComponent<WaveSpawner>();
        speed = wave.currentSpeed;
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNewtWayPoint();
        }
    }

    void GetNewtWayPoint()
    {
        //
        if (wavepointIndex >= WayPoints.wayPoints.Length - 1)
        {       
            Destroy(gameObject);
            return;
        }
        wavepointIndex++;
        target = WayPoints.wayPoints[wavepointIndex];
    }
}

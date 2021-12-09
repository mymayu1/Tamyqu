using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2WayPoint : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int currentWayPoint = 0;

    [SerializeField] private float speed = 2;
 
    void Update()
    {
        if (Vector2.Distance(wayPoints[currentWayPoint].transform.position, transform.position) < .1f)
        {
            currentWayPoint++;
            if (currentWayPoint >= wayPoints.Length)
            {
                currentWayPoint = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWayPoint].transform.position, Time.deltaTime * speed);
    }
}

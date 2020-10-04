using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{

   
    public Transform[] waypoints;
    public float moveSpeed = 2f;
    private int waypointIndex = 0;

    
     void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        waypointIndex++;
    }

  

    void Update()
    {
    
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

        
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex++;
            }
        }


   
}

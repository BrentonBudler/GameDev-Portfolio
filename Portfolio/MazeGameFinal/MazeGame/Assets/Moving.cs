using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Moving : MonoBehaviour
{
    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Transform[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;

    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;
    private Vector3 lastPos;
    private string dir;

    public Animator an;

    // Use this for initialization
    private void Start()
    {

        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;

        lastPos = transform.position;

    }

    // Update is called once per frame
    private void Update()
    {
        dir = " ";
        // Move Enemy
        Move();
        

        float movedx = transform.position.x - lastPos.x;
        float movedy = transform.position.y - lastPos.y;
        lastPos = transform.position;
        an.SetBool("WalkDown", false);
        an.SetBool("WalkUp", false);

        if (movedx>0)
        {

        }






        gameObject.transform.localScale = new Vector3(-0.6f, 0.6f, 1);

    

       

       






        Debug.Log(dir);




    }

    // Method that actually make Enemy walk
    private void Move()
    {
        // If Enemy didn't reach last waypoint it can move
        // If enemy reached last waypoint then it stops
        if (waypointIndex <= waypoints.Length - 1)
        {

            // Move Enemy from current waypoint to the next one
            // using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position,
               waypoints[waypointIndex].transform.position,
               moveSpeed * Time.deltaTime);

            // If Enemy reaches position of waypoint he walked towards
            // then waypointIndex is increased by 1
            // and Enemy starts to walk to the next waypoint
            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
            if (waypointIndex==24)
            {
                waypointIndex = 0; 
            }
        }
    }

    
}

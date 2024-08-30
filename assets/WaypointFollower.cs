using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    //variable keep the track of current waypoint
    private int currentWaypointIndex = 0;
    [SerializeField] private float speed = 2f;
    private void Update()
    {
        //distance calculate the distance between two vector it will compare two waypoint
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {//it will change the index  of currentwaypoint if initially it way 0 then it will be 1
            currentWaypointIndex++;
            //if at last waypoint
            if(currentWaypointIndex >= waypoints.Length)
            {
                //reset the current waypoint to 0
                currentWaypointIndex = 0;
            }

        }
        //speed define how many game unit we want to move (game unit is a one tile) 2f == 2 game unit = 2 tile
        transform.position = Vector2.MoveTowards(transform.position,waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}

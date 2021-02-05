﻿using UnityEngine;
using System.Collections.Generic;

public class FollowThePath : MonoBehaviour
{
    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }

    private void Update()
    {
        if (moveAllowed == true)
        {
            Move();
        }
    }
    private void Move()
    {
        if(waypointIndex <= waypoints.Length)
        { 
            transform.localPosition = Vector2.MoveTowards(transform.localPosition, waypoints[waypointIndex].localPosition, moveSpeed * Time.deltaTime);
            print(waypointIndex);
            if (transform.localPosition == waypoints[waypointIndex].transform.localPosition)
            {
                print("555");
                waypointIndex += 1;
            }
        }
    }
}

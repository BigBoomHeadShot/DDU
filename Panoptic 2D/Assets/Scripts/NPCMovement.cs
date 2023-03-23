using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;



public class NPCMovement : MonoBehaviour
{
    float distance;
    float timer;
    int index;
    GameObject currentPoint;
    NavMeshAgent agent;

    GameObject waypointGoal;

    List<GameObject> newWaypoint = new List<GameObject>();

    GameObject[] waypoints;


    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
        for (int i = 0; i < waypoints.Length; i++)
        {
            newWaypoint.Add(waypoints[i]);
        }
        choosePoint();
    }

    

    // Update is called once per frame
    void Update()
    {

       moveToWaypoint();
       distance = Vector2.Distance(transform.position, waypointGoal.transform.position);
       if (distance < 1f)
       {
            delayFunction();
       }
        
    }

    void delayFunction()
    {
        float delay = (Random.Range(2, 9));
        timer += Time.deltaTime;
        if (timer > delay)
        {
            choosePoint();
        }
    }


    void moveToWaypoint()
    {
        agent.destination = waypointGoal.transform.position;
    }

    void choosePoint()
    {
        index = Random.Range(0, waypoints.Length);
        waypointGoal = waypoints[index];
    }
}

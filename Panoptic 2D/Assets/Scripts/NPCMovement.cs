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
    
    NavMeshAgent agent;

    //GameObject waypointGoal;

    Vector2 waypointGoal;

    public Transform spriteHolder;
    GameObject[] waypoints;

    

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        

        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
        waypointGoal = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));
        
        StartCoroutine(FindPoint());
    }

    

    // Update is called once per frame
    void Update()
    {
        moveToWaypoint();
        //distance = Vector2.Distance(transform.position, waypointGoal);
        //if (distance < 1f)
        //{
        //delayFunction();
        //}

        

        spriteHolder.rotation = Quaternion.LookRotation(agent.velocity.normalized);

    }

    void delayFunction()
    {
        float delay = (Random.Range(4, 10));
        timer += Time.deltaTime;
        if (timer > delay)
        {
            choosePoint();
        }
    }

    IEnumerator FindPoint()
    {

        
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 6));
            waypointGoal = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));
            //Debug.Log(gameObject.name + " " + waypointGoal);

        }


    }

    void moveToWaypoint()
    {
        agent.destination = waypointGoal;
    }

    void choosePoint()
    {
        //index = Random.Range(0, waypoints.Length);
        //waypointGoal = waypoints[index];



    }
}

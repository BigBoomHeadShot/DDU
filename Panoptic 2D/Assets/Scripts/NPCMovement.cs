using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Linq;




public class NPCMovement : MonoBehaviour
{
    NavMeshAgent agent;

    //GameObject waypointGoal;
    bool runningAway;
    Vector2 waypointGoal;
    Vector2 direction;
    public GameObject spriteHolder;

    


    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        spriteHolder.GetComponent<SpriteRenderer>().sortingOrder = (Random.Range(-3, 4));
        waypointGoal = new Vector2(Random.Range(-10, 10), Random.Range(-5, 5));

        StartCoroutine(FindPoint());
    }

    // Update is called once per frame
    void Update()
    {

        moveToWaypoint();

        if (agent.velocity.x != 0 || agent.velocity.y != 0)
        {
            spriteHolder.transform.up = agent.velocity.normalized;
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

   

}       

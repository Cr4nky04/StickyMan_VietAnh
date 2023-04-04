using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotController : MonoBehaviour
{
    [SerializeField] private GameObject finishPoint;
    public NavMeshAgent agent;

    private Vector3 target;
    private float x, y, z;

    // Update is called once per frame
    void Update()
    {
        x = Random.Range(-22f, 22f);
        y = transform.position.y;
        z = Random.Range(-14, 14);
        target = new Vector3(x, y, z);
        Vector3 direction = target - agent.transform.position;
        RaycastHit hit;
        if(Physics.Raycast(agent.transform.position, direction, out hit, 1000f) && agent.GetComponent<Character>().EatBrick.Count<=5)
        { 
            agent.SetDestination(hit.point);
        }
        if(agent.GetComponent<Character>().EatBrick.Count > 5)
        {
            agent.SetDestination(finishPoint.transform.position);
        }

    }
}

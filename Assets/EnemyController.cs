using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    Transform target;
    NavMeshAgent agent;
    FieldOfView fov;


    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        fov = GetComponent<FieldOfView>();

    }

    void Update()
    {

        if (fov.getSeePlayer())
        {
            agent.SetDestination(target.position);
        }
        else
        {
            agent.SetDestination(transform.position);
        }
    }
}

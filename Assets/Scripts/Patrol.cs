using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform[] Points;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        var destPoint = Points[Random.Range(0, Points.Length)];
        if (!agent.pathPending || agent.pathStatus==NavMeshPathStatus.PathPartial ||agent.remainingDistance <= 1f)
        {
            agent.destination = destPoint.position;
        }
    }
}

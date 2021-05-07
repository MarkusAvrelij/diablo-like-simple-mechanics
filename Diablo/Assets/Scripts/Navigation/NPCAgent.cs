using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAgent : MonoBehaviour
{
    public GameObject characterDestination;
    NavMeshAgent theAfent;
    void Start()
    {
        theAfent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        theAfent.SetDestination(characterDestination.transform.position);
    }
}

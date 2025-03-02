using System;
using StarterAssets;
using UnityEngine;
using UnityEngine.AI;
public class Robot : MonoBehaviour
{
    NavMeshAgent agent;
    private FirstPersonController player;

    private void Awake()
    {
       agent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
    }
    
    void Update()
    {
     agent.SetDestination(player.transform.position);
    }
}
